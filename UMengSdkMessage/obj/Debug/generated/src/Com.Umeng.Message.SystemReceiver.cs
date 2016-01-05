using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='SystemReceiver']"
	[global::Android.Runtime.Register ("com/umeng/message/SystemReceiver", DoNotGenerateAcw=true)]
	public partial class SystemReceiver : global::Org.Android.Agoo.Client.BaseBroadcastReceiver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/SystemReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemReceiver); }
		}

		protected SystemReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='SystemReceiver']/constructor[@name='SystemReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SystemReceiver () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SystemReceiver)) {
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

		static Delegate cb_getIntentServiceClassName_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetIntentServiceClassName_Landroid_content_Context_Handler ()
		{
			if (cb_getIntentServiceClassName_Landroid_content_Context_ == null)
				cb_getIntentServiceClassName_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIntentServiceClassName_Landroid_content_Context_);
			return cb_getIntentServiceClassName_Landroid_content_Context_;
		}

		static IntPtr n_GetIntentServiceClassName_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.SystemReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.SystemReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetIntentServiceClassName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIntentServiceClassName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='SystemReceiver']/method[@name='getIntentServiceClassName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetIntentServiceClassName_Landroid_content_Context_Handler")]
		protected override string GetIntentServiceClassName (global::Android.Content.Context p0)
		{
			if (id_getIntentServiceClassName_Landroid_content_Context_ == IntPtr.Zero)
				id_getIntentServiceClassName_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIntentServiceClassName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
