using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Mtop {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.net.mtop']/interface[@name='IMtopAsynClient']"
	[Register ("org/android/agoo/net/mtop/IMtopAsynClient", "", "Org.Android.Agoo.Net.Mtop.IMtopAsynClientInvoker")]
	public partial interface IMtopAsynClient : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/interface[@name='IMtopAsynClient']/method[@name='getV3' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.net.mtop.MtopRequest'] and parameter[3][@type='org.android.agoo.net.mtop.MtopResponseHandler']]"
		[Register ("getV3", "(Landroid/content/Context;Lorg/android/agoo/net/mtop/MtopRequest;Lorg/android/agoo/net/mtop/MtopResponseHandler;)V", "GetGetV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_Handler:Org.Android.Agoo.Net.Mtop.IMtopAsynClientInvoker, UMengSdkMessage")]
		void GetV3 (global::Android.Content.Context p0, global::Org.Android.Agoo.Net.Mtop.MtopRequest p1, global::Org.Android.Agoo.Net.Mtop.MtopResponseHandler p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/interface[@name='IMtopAsynClient']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBaseUrl", "(Ljava/lang/String;)V", "GetSetBaseUrl_Ljava_lang_String_Handler:Org.Android.Agoo.Net.Mtop.IMtopAsynClientInvoker, UMengSdkMessage")]
		void SetBaseUrl (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/interface[@name='IMtopAsynClient']/method[@name='setDefaultAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDefaultAppSecret", "(Ljava/lang/String;)V", "GetSetDefaultAppSecret_Ljava_lang_String_Handler:Org.Android.Agoo.Net.Mtop.IMtopAsynClientInvoker, UMengSdkMessage")]
		void SetDefaultAppSecret (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/interface[@name='IMtopAsynClient']/method[@name='setDefaultAppkey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDefaultAppkey", "(Ljava/lang/String;)V", "GetSetDefaultAppkey_Ljava_lang_String_Handler:Org.Android.Agoo.Net.Mtop.IMtopAsynClientInvoker, UMengSdkMessage")]
		void SetDefaultAppkey (string p0);

	}

	[global::Android.Runtime.Register ("org/android/agoo/net/mtop/IMtopAsynClient", DoNotGenerateAcw=true)]
	internal class IMtopAsynClientInvoker : global::Java.Lang.Object, IMtopAsynClient {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/net/mtop/IMtopAsynClient");
		IntPtr class_ref;

		public static IMtopAsynClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMtopAsynClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.net.mtop.IMtopAsynClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMtopAsynClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMtopAsynClientInvoker); }
		}

		static Delegate cb_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_;
#pragma warning disable 0169
		static Delegate GetGetV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_Handler ()
		{
			if (cb_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_ == null)
				cb_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_);
			return cb_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_;
		}

		static void n_GetV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Net.Mtop.MtopRequest p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.MtopRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Net.Mtop.MtopResponseHandler p2 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.MtopResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetV3 (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_;
		public void GetV3 (global::Android.Content.Context p0, global::Org.Android.Agoo.Net.Mtop.MtopRequest p1, global::Org.Android.Agoo.Net.Mtop.MtopResponseHandler p2)
		{
			if (id_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_ == IntPtr.Zero)
				id_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_ = JNIEnv.GetMethodID (class_ref, "getV3", "(Landroid/content/Context;Lorg/android/agoo/net/mtop/MtopRequest;Lorg/android/agoo/net/mtop/MtopResponseHandler;)V");
			JNIEnv.CallVoidMethod (Handle, id_getV3_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_Lorg_android_agoo_net_mtop_MtopResponseHandler_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_setBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setBaseUrl_Ljava_lang_String_ == null)
				cb_setBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBaseUrl_Ljava_lang_String_);
			return cb_setBaseUrl_Ljava_lang_String_;
		}

		static void n_SetBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBaseUrl (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBaseUrl_Ljava_lang_String_;
		public void SetBaseUrl (string p0)
		{
			if (id_setBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBaseUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setBaseUrl_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setDefaultAppSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultAppSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultAppSecret_Ljava_lang_String_ == null)
				cb_setDefaultAppSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultAppSecret_Ljava_lang_String_);
			return cb_setDefaultAppSecret_Ljava_lang_String_;
		}

		static void n_SetDefaultAppSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultAppSecret (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDefaultAppSecret_Ljava_lang_String_;
		public void SetDefaultAppSecret (string p0)
		{
			if (id_setDefaultAppSecret_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultAppSecret", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setDefaultAppSecret_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setDefaultAppkey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultAppkey_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultAppkey_Ljava_lang_String_ == null)
				cb_setDefaultAppkey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultAppkey_Ljava_lang_String_);
			return cb_setDefaultAppkey_Ljava_lang_String_;
		}

		static void n_SetDefaultAppkey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Mtop.IMtopAsynClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultAppkey (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDefaultAppkey_Ljava_lang_String_;
		public void SetDefaultAppkey (string p0)
		{
			if (id_setDefaultAppkey_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultAppkey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultAppkey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setDefaultAppkey_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
