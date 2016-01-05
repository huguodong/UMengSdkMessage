using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aO']"
	[Register ("com/umeng/message/proguard/aO", "", "Com.Umeng.Message.Proguard.IAOInvoker")]
	public partial interface IAO : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aO']/method[@name='onHandleError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onHandleError", "(Ljava/lang/String;)V", "GetOnHandleError_Ljava_lang_String_Handler:Com.Umeng.Message.Proguard.IAOInvoker, UMengSdkMessage")]
		void OnHandleError (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/interface[@name='aO']/method[@name='onHandleMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onHandleMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetOnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_Handler:Com.Umeng.Message.Proguard.IAOInvoker, UMengSdkMessage")]
		void OnHandleMessage (string p0, global::Android.OS.Bundle p1);

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/aO", DoNotGenerateAcw=true)]
	internal class IAOInvoker : global::Java.Lang.Object, IAO {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/message/proguard/aO");
		IntPtr class_ref;

		public static IAO GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAO> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.message.proguard.aO"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAOInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IAOInvoker); }
		}

		static Delegate cb_onHandleError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnHandleError_Ljava_lang_String_Handler ()
		{
			if (cb_onHandleError_Ljava_lang_String_ == null)
				cb_onHandleError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleError_Ljava_lang_String_);
			return cb_onHandleError_Ljava_lang_String_;
		}

		static void n_OnHandleError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.Proguard.IAO __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onHandleError_Ljava_lang_String_;
		public void OnHandleError (string p0)
		{
			if (id_onHandleError_Ljava_lang_String_ == IntPtr.Zero)
				id_onHandleError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onHandleError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onHandleError_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_OnHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.IAO __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.IAO> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_;
		public void OnHandleMessage (string p0, global::Android.OS.Bundle p1)
		{
			if (id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onHandleMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_onHandleMessage_Ljava_lang_String_Landroid_os_Bundle_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
