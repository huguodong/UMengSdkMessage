using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo']/interface[@name='IMtopService']"
	[Register ("org/android/agoo/IMtopService", "", "Org.Android.Agoo.IMtopServiceInvoker")]
	public partial interface IMtopService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo']/interface[@name='IMtopService']/method[@name='getV3' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest']]"
		[Register ("getV3", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)Lorg/android/agoo/client/MtopSyncResult;", "GetGetV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Handler:Org.Android.Agoo.IMtopServiceInvoker, UMengSdkMessage")]
		global::Org.Android.Agoo.Client.MtopSyncResult GetV3 (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo']/interface[@name='IMtopService']/method[@name='sendMtop' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest']]"
		[Register ("sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V", "GetSendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Handler:Org.Android.Agoo.IMtopServiceInvoker, UMengSdkMessage")]
		void SendMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo']/interface[@name='IMtopService']/method[@name='sendMtop' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest'] and parameter[3][@type='org.android.agoo.client.MtopProxyResponseHandler']]"
		[Register ("sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;Lorg/android/agoo/client/MtopProxyResponseHandler;)V", "GetSendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_Handler:Org.Android.Agoo.IMtopServiceInvoker, UMengSdkMessage")]
		void SendMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1, global::Org.Android.Agoo.Client.IMtopProxyResponseHandler p2);

	}

	[global::Android.Runtime.Register ("org/android/agoo/IMtopService", DoNotGenerateAcw=true)]
	internal class IMtopServiceInvoker : global::Java.Lang.Object, IMtopService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/IMtopService");
		IntPtr class_ref;

		public static IMtopService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMtopService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.IMtopService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMtopServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMtopServiceInvoker); }
		}

		static Delegate cb_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
#pragma warning disable 0169
		static Delegate GetGetV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Handler ()
		{
			if (cb_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == null)
				cb_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_);
			return cb_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		}

		static IntPtr n_GetV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.IMtopService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IMtopService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Client.MtopProxyRequest p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MtopProxyRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetV3 (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		public global::Org.Android.Agoo.Client.MtopSyncResult GetV3 (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1)
		{
			if (id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == IntPtr.Zero)
				id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNIEnv.GetMethodID (class_ref, "getV3", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)Lorg/android/agoo/client/MtopSyncResult;");
			global::Org.Android.Agoo.Client.MtopSyncResult __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MtopSyncResult> (JNIEnv.CallObjectMethod (Handle, id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
#pragma warning disable 0169
		static Delegate GetSendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Handler ()
		{
			if (cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == null)
				cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_);
			return cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		}

		static void n_SendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.IMtopService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IMtopService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Client.MtopProxyRequest p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MtopProxyRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMtop (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		public void SendMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1)
		{
			if (id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == IntPtr.Zero)
				id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNIEnv.GetMethodID (class_ref, "sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V");
			JNIEnv.CallVoidMethod (Handle, id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_;
#pragma warning disable 0169
		static Delegate GetSendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_Handler ()
		{
			if (cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ == null)
				cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_);
			return cb_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_;
		}

		static void n_SendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.IMtopService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IMtopService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Client.MtopProxyRequest p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MtopProxyRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Client.IMtopProxyResponseHandler p2 = (global::Org.Android.Agoo.Client.IMtopProxyResponseHandler)global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.IMtopProxyResponseHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMtop (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_;
		public void SendMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1, global::Org.Android.Agoo.Client.IMtopProxyResponseHandler p2)
		{
			if (id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ == IntPtr.Zero)
				id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ = JNIEnv.GetMethodID (class_ref, "sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;Lorg/android/agoo/client/MtopProxyResponseHandler;)V");
			JNIEnv.CallVoidMethod (Handle, id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

}
