using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MessageReceiverService']"
	[global::Android.Runtime.Register ("org/android/agoo/client/MessageReceiverService", DoNotGenerateAcw=true)]
	public abstract partial class MessageReceiverService : global::Android.App.Service {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/MessageReceiverService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageReceiverService); }
		}

		protected MessageReceiverService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MessageReceiverService']/constructor[@name='MessageReceiverService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MessageReceiverService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MessageReceiverService)) {
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
			global::Org.Android.Agoo.Client.MessageReceiverService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MessageReceiverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetIntentServiceClassName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MessageReceiverService']/method[@name='getIntentServiceClassName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetIntentServiceClassName_Landroid_content_Context_Handler")]
		public abstract string GetIntentServiceClassName (global::Android.Content.Context p0);

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Client.MessageReceiverService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.MessageReceiverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MessageReceiverService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");

			global::Android.OS.IBinder __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_onBind_Landroid_content_Intent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("org/android/agoo/client/MessageReceiverService", DoNotGenerateAcw=true)]
	internal partial class MessageReceiverServiceInvoker : MessageReceiverService {

		public MessageReceiverServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageReceiverServiceInvoker); }
		}

		static IntPtr id_getIntentServiceClassName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MessageReceiverService']/method[@name='getIntentServiceClassName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetIntentServiceClassName_Landroid_content_Context_Handler")]
		public override string GetIntentServiceClassName (global::Android.Content.Context p0)
		{
			if (id_getIntentServiceClassName_Landroid_content_Context_ == IntPtr.Zero)
				id_getIntentServiceClassName_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getIntentServiceClassName", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIntentServiceClassName_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
