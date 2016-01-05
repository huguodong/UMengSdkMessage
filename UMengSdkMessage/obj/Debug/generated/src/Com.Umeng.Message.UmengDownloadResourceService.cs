using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']"
	[global::Android.Runtime.Register ("com/umeng/message/UmengDownloadResourceService", DoNotGenerateAcw=true)]
	public partial class UmengDownloadResourceService : global::Android.App.Service {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/UmengDownloadResourceService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengDownloadResourceService); }
		}

		protected UmengDownloadResourceService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/constructor[@name='UmengDownloadResourceService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UmengDownloadResourceService () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UmengDownloadResourceService)) {
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

		static Delegate cb_checkCache;
#pragma warning disable 0169
		static Delegate GetCheckCacheHandler ()
		{
			if (cb_checkCache == null)
				cb_checkCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckCache);
			return cb_checkCache;
		}

		static void n_CheckCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckCache ();
		}
#pragma warning restore 0169

		static IntPtr id_checkCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='checkCache' and count(parameter)=0]"
		[Register ("checkCache", "()V", "GetCheckCacheHandler")]
		public virtual void CheckCache ()
		{
			if (id_checkCache == IntPtr.Zero)
				id_checkCache = JNIEnv.GetMethodID (class_ref, "checkCache", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_checkCache);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkCache", "()V"));
		}

		static IntPtr id_checkDir_Ljava_io_File_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='checkDir' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("checkDir", "(Ljava/io/File;JJ)V", "")]
		public static void CheckDir (global::Java.IO.File p0, long p1, long p2)
		{
			if (id_checkDir_Ljava_io_File_JJ == IntPtr.Zero)
				id_checkDir_Ljava_io_File_JJ = JNIEnv.GetStaticMethodID (class_ref, "checkDir", "(Ljava/io/File;JJ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkDir_Ljava_io_File_JJ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_close_Ljava_io_Closeable_;
#pragma warning disable 0169
		static Delegate GetClose_Ljava_io_Closeable_Handler ()
		{
			if (cb_close_Ljava_io_Closeable_ == null)
				cb_close_Ljava_io_Closeable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Close_Ljava_io_Closeable_);
			return cb_close_Ljava_io_Closeable_;
		}

		static void n_Close_Ljava_io_Closeable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.ICloseable p0 = (global::Java.IO.ICloseable)global::Java.Lang.Object.GetObject<global::Java.IO.ICloseable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		static IntPtr id_close_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='close' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("close", "(Ljava/io/Closeable;)V", "GetClose_Ljava_io_Closeable_Handler")]
		public virtual void Close (global::Java.IO.ICloseable p0)
		{
			if (id_close_Ljava_io_Closeable_ == IntPtr.Zero)
				id_close_Ljava_io_Closeable_ = JNIEnv.GetMethodID (class_ref, "close", "(Ljava/io/Closeable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close_Ljava_io_Closeable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "(Ljava/io/Closeable;)V"), new JValue (p0));
		}

		static Delegate cb_deleteAlarm_Lcom_umeng_message_entity_UMessage_I;
#pragma warning disable 0169
		static Delegate GetDeleteAlarm_Lcom_umeng_message_entity_UMessage_IHandler ()
		{
			if (cb_deleteAlarm_Lcom_umeng_message_entity_UMessage_I == null)
				cb_deleteAlarm_Lcom_umeng_message_entity_UMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DeleteAlarm_Lcom_umeng_message_entity_UMessage_I);
			return cb_deleteAlarm_Lcom_umeng_message_entity_UMessage_I;
		}

		static void n_DeleteAlarm_Lcom_umeng_message_entity_UMessage_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAlarm (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAlarm_Lcom_umeng_message_entity_UMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='deleteAlarm' and count(parameter)=2 and parameter[1][@type='com.umeng.message.entity.UMessage'] and parameter[2][@type='int']]"
		[Register ("deleteAlarm", "(Lcom/umeng/message/entity/UMessage;I)V", "GetDeleteAlarm_Lcom_umeng_message_entity_UMessage_IHandler")]
		public virtual void DeleteAlarm (global::Com.Umeng.Message.Entity.UMessage p0, int p1)
		{
			if (id_deleteAlarm_Lcom_umeng_message_entity_UMessage_I == IntPtr.Zero)
				id_deleteAlarm_Lcom_umeng_message_entity_UMessage_I = JNIEnv.GetMethodID (class_ref, "deleteAlarm", "(Lcom/umeng/message/entity/UMessage;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_deleteAlarm_Lcom_umeng_message_entity_UMessage_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAlarm", "(Lcom/umeng/message/entity/UMessage;I)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_downloadResource_Lcom_umeng_message_entity_UMessage_I;
#pragma warning disable 0169
		static Delegate GetDownloadResource_Lcom_umeng_message_entity_UMessage_IHandler ()
		{
			if (cb_downloadResource_Lcom_umeng_message_entity_UMessage_I == null)
				cb_downloadResource_Lcom_umeng_message_entity_UMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_DownloadResource_Lcom_umeng_message_entity_UMessage_I);
			return cb_downloadResource_Lcom_umeng_message_entity_UMessage_I;
		}

		static void n_DownloadResource_Lcom_umeng_message_entity_UMessage_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadResource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_downloadResource_Lcom_umeng_message_entity_UMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='downloadResource' and count(parameter)=2 and parameter[1][@type='com.umeng.message.entity.UMessage'] and parameter[2][@type='int']]"
		[Register ("downloadResource", "(Lcom/umeng/message/entity/UMessage;I)V", "GetDownloadResource_Lcom_umeng_message_entity_UMessage_IHandler")]
		public virtual void DownloadResource (global::Com.Umeng.Message.Entity.UMessage p0, int p1)
		{
			if (id_downloadResource_Lcom_umeng_message_entity_UMessage_I == IntPtr.Zero)
				id_downloadResource_Lcom_umeng_message_entity_UMessage_I = JNIEnv.GetMethodID (class_ref, "downloadResource", "(Lcom/umeng/message/entity/UMessage;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_downloadResource_Lcom_umeng_message_entity_UMessage_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadResource", "(Lcom/umeng/message/entity/UMessage;I)V"), new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getMessageResourceFolder_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='getMessageResourceFolder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.entity.UMessage']]"
		[Register ("getMessageResourceFolder", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)Ljava/lang/String;", "")]
		public static string GetMessageResourceFolder (global::Android.Content.Context p0, global::Com.Umeng.Message.Entity.UMessage p1)
		{
			if (id_getMessageResourceFolder_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_getMessageResourceFolder_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageResourceFolder", "(Landroid/content/Context;Lcom/umeng/message/entity/UMessage;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessageResourceFolder_Landroid_content_Context_Lcom_umeng_message_entity_UMessage_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_notification_Lcom_umeng_message_entity_UMessage_;
#pragma warning disable 0169
		static Delegate GetNotification_Lcom_umeng_message_entity_UMessage_Handler ()
		{
			if (cb_notification_Lcom_umeng_message_entity_UMessage_ == null)
				cb_notification_Lcom_umeng_message_entity_UMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Notification_Lcom_umeng_message_entity_UMessage_);
			return cb_notification_Lcom_umeng_message_entity_UMessage_;
		}

		static void n_Notification_Lcom_umeng_message_entity_UMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notification (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notification_Lcom_umeng_message_entity_UMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='notification' and count(parameter)=1 and parameter[1][@type='com.umeng.message.entity.UMessage']]"
		[Register ("notification", "(Lcom/umeng/message/entity/UMessage;)V", "GetNotification_Lcom_umeng_message_entity_UMessage_Handler")]
		public virtual void Notification (global::Com.Umeng.Message.Entity.UMessage p0)
		{
			if (id_notification_Lcom_umeng_message_entity_UMessage_ == IntPtr.Zero)
				id_notification_Lcom_umeng_message_entity_UMessage_ = JNIEnv.GetMethodID (class_ref, "notification", "(Lcom/umeng/message/entity/UMessage;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notification_Lcom_umeng_message_entity_UMessage_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notification", "(Lcom/umeng/message/entity/UMessage;)V"), new JValue (p0));
		}

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
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
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

		static Delegate cb_setAlarm_Lcom_umeng_message_entity_UMessage_I;
#pragma warning disable 0169
		static Delegate GetSetAlarm_Lcom_umeng_message_entity_UMessage_IHandler ()
		{
			if (cb_setAlarm_Lcom_umeng_message_entity_UMessage_I == null)
				cb_setAlarm_Lcom_umeng_message_entity_UMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetAlarm_Lcom_umeng_message_entity_UMessage_I);
			return cb_setAlarm_Lcom_umeng_message_entity_UMessage_I;
		}

		static void n_SetAlarm_Lcom_umeng_message_entity_UMessage_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Message.UmengDownloadResourceService __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UmengDownloadResourceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAlarm (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAlarm_Lcom_umeng_message_entity_UMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengDownloadResourceService']/method[@name='setAlarm' and count(parameter)=2 and parameter[1][@type='com.umeng.message.entity.UMessage'] and parameter[2][@type='int']]"
		[Register ("setAlarm", "(Lcom/umeng/message/entity/UMessage;I)V", "GetSetAlarm_Lcom_umeng_message_entity_UMessage_IHandler")]
		public virtual void SetAlarm (global::Com.Umeng.Message.Entity.UMessage p0, int p1)
		{
			if (id_setAlarm_Lcom_umeng_message_entity_UMessage_I == IntPtr.Zero)
				id_setAlarm_Lcom_umeng_message_entity_UMessage_I = JNIEnv.GetMethodID (class_ref, "setAlarm", "(Lcom/umeng/message/entity/UMessage;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAlarm_Lcom_umeng_message_entity_UMessage_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlarm", "(Lcom/umeng/message/entity/UMessage;I)V"), new JValue (p0), new JValue (p1));
		}

	}
}
