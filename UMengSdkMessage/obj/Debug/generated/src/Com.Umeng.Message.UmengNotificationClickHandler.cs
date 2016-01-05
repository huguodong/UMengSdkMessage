using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']"
	[global::Android.Runtime.Register ("com/umeng/message/UmengNotificationClickHandler", DoNotGenerateAcw=true)]
	public partial class UmengNotificationClickHandler : global::Java.Lang.Object, global::Com.Umeng.Message.IUHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/UmengNotificationClickHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengNotificationClickHandler); }
		}

		protected UmengNotificationClickHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']/constructor[@name='UmengNotificationClickHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UmengNotificationClickHandler () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UmengNotificationClickHandler)) {
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

		static Delegate cb_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetDealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == null)
				cb_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_);
			return cb_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_DealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UmengNotificationClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengNotificationClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DealWithCustomAction (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']/method[@name='dealWithCustomAction' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("dealWithCustomAction", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V", "GetDealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler")]
		public virtual void DealWithCustomAction (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "dealWithCustomAction", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dealWithCustomAction_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dealWithCustomAction", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == null)
				cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_);
			return cb_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_HandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UmengNotificationClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengNotificationClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']/method[@name='handleMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("handleMessage", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V", "GetHandleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler")]
		public virtual void HandleMessage (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_handleMessage_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMessage", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetLaunchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == null)
				cb_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LaunchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_);
			return cb_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_LaunchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UmengNotificationClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengNotificationClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LaunchApp (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']/method[@name='launchApp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("launchApp", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V", "GetLaunchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler")]
		public virtual void LaunchApp (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "launchApp", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_launchApp_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "launchApp", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetOpenActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == null)
				cb_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_);
			return cb_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_OpenActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UmengNotificationClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengNotificationClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OpenActivity (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']/method[@name='openActivity' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("openActivity", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V", "GetOpenActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler")]
		public virtual void OpenActivity (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "openActivity", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openActivity_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openActivity", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetOpenUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == null)
				cb_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_);
			return cb_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_OpenUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UmengNotificationClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengNotificationClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OpenUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengNotificationClickHandler']/method[@name='openUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("openUrl", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V", "GetOpenUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_Handler")]
		public virtual void OpenUrl (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "openUrl", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openUrl_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openUrl", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
