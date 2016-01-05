using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Impl {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='ControlService']"
	[global::Android.Runtime.Register ("org/android/agoo/impl/ControlService", DoNotGenerateAcw=true)]
	public sealed partial class ControlService : global::Java.Lang.Object, global::Org.Android.Agoo.IControlService {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/impl/ControlService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ControlService); }
		}

		internal ControlService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='ControlService']/constructor[@name='ControlService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ControlService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ControlService)) {
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

		static IntPtr id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.impl']/class[@name='ControlService']/method[@name='onHandleIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='org.android.agoo.callback.IControlCallBack']]"
		[Register ("onHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;Lorg/android/agoo/callback/IControlCallBack;)V", "")]
		public void OnHandleIntent (global::Android.Content.Context p0, global::Android.Content.Intent p1, global::Org.Android.Agoo.Callback.IControlCallBack p2)
		{
			if (id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ == IntPtr.Zero)
				id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_ = JNIEnv.GetMethodID (class_ref, "onHandleIntent", "(Landroid/content/Context;Landroid/content/Intent;Lorg/android/agoo/callback/IControlCallBack;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onHandleIntent_Landroid_content_Context_Landroid_content_Intent_Lorg_android_agoo_callback_IControlCallBack_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
