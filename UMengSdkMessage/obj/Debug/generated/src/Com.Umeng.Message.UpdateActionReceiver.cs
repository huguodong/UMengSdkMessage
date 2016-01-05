using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='UpdateActionReceiver']"
	[global::Android.Runtime.Register ("com/umeng/message/UpdateActionReceiver", DoNotGenerateAcw=true)]
	public partial class UpdateActionReceiver : global::Android.Content.BroadcastReceiver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/UpdateActionReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UpdateActionReceiver); }
		}

		protected UpdateActionReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='UpdateActionReceiver']/constructor[@name='UpdateActionReceiver' and count(parameter)=1 and parameter[1][@type='com.umeng.message.entity.UMessage']]"
		[Register (".ctor", "(Lcom/umeng/message/entity/UMessage;)V", "")]
		public UpdateActionReceiver (global::Com.Umeng.Message.Entity.UMessage p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UpdateActionReceiver)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/umeng/message/entity/UMessage;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/umeng/message/entity/UMessage;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_ctor_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/message/entity/UMessage;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_message_entity_UMessage_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_umeng_message_entity_UMessage_, new JValue (p0));
		}

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UpdateActionReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UpdateActionReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UpdateActionReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
