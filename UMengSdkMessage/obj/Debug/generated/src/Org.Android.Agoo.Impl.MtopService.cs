using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='MtopService']"
	[global::Android.Runtime.Register ("org/android/agoo/impl/MtopService", DoNotGenerateAcw=true)]
	public sealed partial class MtopService : global::Java.Lang.Object, global::Org.Android.Agoo.IMtopService {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/impl/MtopService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopService); }
		}

		internal MtopService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='MtopService']/constructor[@name='MtopService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MtopService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MtopService)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='MtopService']/method[@name='getV3' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest']]"
		[Register ("getV3", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)Lorg/android/agoo/client/MtopSyncResult;", "")]
		public global::Org.Android.Agoo.Client.MtopSyncResult GetV3 (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1)
		{
			if (id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == IntPtr.Zero)
				id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNIEnv.GetMethodID (class_ref, "getV3", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)Lorg/android/agoo/client/MtopSyncResult;");
			global::Org.Android.Agoo.Client.MtopSyncResult __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MtopSyncResult> (JNIEnv.CallObjectMethod  (Handle, id_getV3_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='MtopService']/method[@name='sendMtop' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest']]"
		[Register ("sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V", "")]
		public void SendMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1)
		{
			if (id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == IntPtr.Zero)
				id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNIEnv.GetMethodID (class_ref, "sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V");
			JNIEnv.CallVoidMethod  (Handle, id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='MtopService']/method[@name='sendMtop' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest'] and parameter[3][@type='org.android.agoo.client.MtopProxyResponseHandler']]"
		[Register ("sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;Lorg/android/agoo/client/MtopProxyResponseHandler;)V", "")]
		public void SendMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1, global::Org.Android.Agoo.Client.IMtopProxyResponseHandler p2)
		{
			if (id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ == IntPtr.Zero)
				id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ = JNIEnv.GetMethodID (class_ref, "sendMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;Lorg/android/agoo/client/MtopProxyResponseHandler;)V");
			JNIEnv.CallVoidMethod  (Handle, id_sendMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
