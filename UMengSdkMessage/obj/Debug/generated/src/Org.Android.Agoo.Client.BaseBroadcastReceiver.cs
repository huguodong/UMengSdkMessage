using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseBroadcastReceiver']"
	[global::Android.Runtime.Register ("org/android/agoo/client/BaseBroadcastReceiver", DoNotGenerateAcw=true)]
	public abstract partial class BaseBroadcastReceiver : global::Android.Content.BroadcastReceiver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/BaseBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseBroadcastReceiver); }
		}

		protected BaseBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseBroadcastReceiver']/constructor[@name='BaseBroadcastReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BaseBroadcastReceiver () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseBroadcastReceiver)) {
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
			global::Org.Android.Agoo.Client.BaseBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.BaseBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetIntentServiceClassName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseBroadcastReceiver']/method[@name='getIntentServiceClassName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetIntentServiceClassName_Landroid_content_Context_Handler")]
		protected abstract string GetIntentServiceClassName (global::Android.Content.Context p0);

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public override sealed void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onUserReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnUserReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onUserReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onUserReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUserReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onUserReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnUserReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.Client.BaseBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.BaseBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnUserReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUserReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseBroadcastReceiver']/method[@name='onUserReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onUserReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnUserReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		protected virtual void OnUserReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onUserReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onUserReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onUserReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onUserReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUserReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), new JValue (p0), new JValue (p1));
		}

	}

	[global::Android.Runtime.Register ("org/android/agoo/client/BaseBroadcastReceiver", DoNotGenerateAcw=true)]
	internal partial class BaseBroadcastReceiverInvoker : BaseBroadcastReceiver {

		public BaseBroadcastReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseBroadcastReceiverInvoker); }
		}

		static IntPtr id_getIntentServiceClassName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseBroadcastReceiver']/method[@name='getIntentServiceClassName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetIntentServiceClassName_Landroid_content_Context_Handler")]
		protected override string GetIntentServiceClassName (global::Android.Content.Context p0)
		{
			if (id_getIntentServiceClassName_Landroid_content_Context_ == IntPtr.Zero)
				id_getIntentServiceClassName_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIntentServiceClassName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
