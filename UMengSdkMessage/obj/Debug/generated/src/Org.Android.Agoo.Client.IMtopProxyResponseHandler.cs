using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='MtopProxyResponseHandler']"
	[Register ("org/android/agoo/client/MtopProxyResponseHandler", "", "Org.Android.Agoo.Client.IMtopProxyResponseHandlerInvoker")]
	public partial interface IMtopProxyResponseHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='MtopProxyResponseHandler']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFailure", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Ljava_lang_String_Handler:Org.Android.Agoo.Client.IMtopProxyResponseHandlerInvoker, UMengSdkMessage")]
		void OnFailure (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/interface[@name='MtopProxyResponseHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Org.Android.Agoo.Client.IMtopProxyResponseHandlerInvoker, UMengSdkMessage")]
		void OnSuccess (string p0);

	}

	[global::Android.Runtime.Register ("org/android/agoo/client/MtopProxyResponseHandler", DoNotGenerateAcw=true)]
	internal class IMtopProxyResponseHandlerInvoker : global::Java.Lang.Object, IMtopProxyResponseHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/client/MtopProxyResponseHandler");
		IntPtr class_ref;

		public static IMtopProxyResponseHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMtopProxyResponseHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.client.MtopProxyResponseHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMtopProxyResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMtopProxyResponseHandlerInvoker); }
		}

		static Delegate cb_onFailure_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onFailure_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_Ljava_lang_String_);
			return cb_onFailure_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFailure_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Client.IMtopProxyResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.IMtopProxyResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_String_Ljava_lang_String_;
		public void OnFailure (string p0, string p1)
		{
			if (id_onFailure_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod (Handle, id_onFailure_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Client.IMtopProxyResponseHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.IMtopProxyResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_;
		public void OnSuccess (string p0)
		{
			if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onSuccess_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
