using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']"
	[global::Android.Runtime.Register ("com/umeng/message/UTrack", DoNotGenerateAcw=true)]
	public partial class UTrack : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/UTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTrack); }
		}

		protected UTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		public virtual global::Org.Json.JSONObject Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Lorg/json/JSONObject;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addAlias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAlias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addAlias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddAlias_Ljava_lang_String_Ljava_lang_String_);
			return cb_addAlias_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_AddAlias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAlias (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAlias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='addAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAlias", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAddAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool AddAlias (string p0, string p1)
		{
			if (id_addAlias_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addAlias_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAlias", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addAlias_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAlias", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/UTrack;", "")]
		public static global::Com.Umeng.Message.UTrack GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/UTrack;");
			global::Com.Umeng.Message.UTrack __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_removeAlias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeAlias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeAlias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RemoveAlias_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeAlias_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_RemoveAlias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAlias (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAlias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='removeAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAlias", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetRemoveAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool RemoveAlias (string p0, string p1)
		{
			if (id_removeAlias_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAlias_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAlias", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeAlias_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAlias", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_sendCachedMsgLog_J;
#pragma warning disable 0169
		static Delegate GetSendCachedMsgLog_JHandler ()
		{
			if (cb_sendCachedMsgLog_J == null)
				cb_sendCachedMsgLog_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SendCachedMsgLog_J);
			return cb_sendCachedMsgLog_J;
		}

		static void n_SendCachedMsgLog_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendCachedMsgLog (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendCachedMsgLog_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='sendCachedMsgLog' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("sendCachedMsgLog", "(J)V", "GetSendCachedMsgLog_JHandler")]
		public virtual void SendCachedMsgLog (long p0)
		{
			if (id_sendCachedMsgLog_J == IntPtr.Zero)
				id_sendCachedMsgLog_J = JNIEnv.GetMethodID (class_ref, "sendCachedMsgLog", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sendCachedMsgLog_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCachedMsgLog", "(J)V"), new JValue (p0));
		}

		static Delegate cb_trackAppLaunch_J;
#pragma warning disable 0169
		static Delegate GetTrackAppLaunch_JHandler ()
		{
			if (cb_trackAppLaunch_J == null)
				cb_trackAppLaunch_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_TrackAppLaunch_J);
			return cb_trackAppLaunch_J;
		}

		static void n_TrackAppLaunch_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackAppLaunch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_trackAppLaunch_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='trackAppLaunch' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("trackAppLaunch", "(J)V", "GetTrackAppLaunch_JHandler")]
		public virtual void TrackAppLaunch (long p0)
		{
			if (id_trackAppLaunch_J == IntPtr.Zero)
				id_trackAppLaunch_J = JNIEnv.GetMethodID (class_ref, "trackAppLaunch", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_trackAppLaunch_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackAppLaunch", "(J)V"), new JValue (p0));
		}

		static Delegate cb_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z;
#pragma warning disable 0169
		static Delegate GetTrackMsgClick_Lcom_umeng_message_entity_UMessage_ZHandler ()
		{
			if (cb_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z == null)
				cb_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_TrackMsgClick_Lcom_umeng_message_entity_UMessage_Z);
			return cb_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z;
		}

		static void n_TrackMsgClick_Lcom_umeng_message_entity_UMessage_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackMsgClick (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='trackMsgClick' and count(parameter)=2 and parameter[1][@type='com.umeng.message.entity.UMessage'] and parameter[2][@type='boolean']]"
		[Register ("trackMsgClick", "(Lcom/umeng/message/entity/UMessage;Z)V", "GetTrackMsgClick_Lcom_umeng_message_entity_UMessage_ZHandler")]
		public virtual void TrackMsgClick (global::Com.Umeng.Message.Entity.UMessage p0, bool p1)
		{
			if (id_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z == IntPtr.Zero)
				id_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z = JNIEnv.GetMethodID (class_ref, "trackMsgClick", "(Lcom/umeng/message/entity/UMessage;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_trackMsgClick_Lcom_umeng_message_entity_UMessage_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackMsgClick", "(Lcom/umeng/message/entity/UMessage;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z;
#pragma warning disable 0169
		static Delegate GetTrackMsgDismissed_Lcom_umeng_message_entity_UMessage_ZHandler ()
		{
			if (cb_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z == null)
				cb_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_TrackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z);
			return cb_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z;
		}

		static void n_TrackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Entity.UMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Entity.UMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackMsgDismissed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='trackMsgDismissed' and count(parameter)=2 and parameter[1][@type='com.umeng.message.entity.UMessage'] and parameter[2][@type='boolean']]"
		[Register ("trackMsgDismissed", "(Lcom/umeng/message/entity/UMessage;Z)V", "GetTrackMsgDismissed_Lcom_umeng_message_entity_UMessage_ZHandler")]
		public virtual void TrackMsgDismissed (global::Com.Umeng.Message.Entity.UMessage p0, bool p1)
		{
			if (id_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z == IntPtr.Zero)
				id_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z = JNIEnv.GetMethodID (class_ref, "trackMsgDismissed", "(Lcom/umeng/message/entity/UMessage;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_trackMsgDismissed_Lcom_umeng_message_entity_UMessage_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackMsgDismissed", "(Lcom/umeng/message/entity/UMessage;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_trackRegister;
#pragma warning disable 0169
		static Delegate GetTrackRegisterHandler ()
		{
			if (cb_trackRegister == null)
				cb_trackRegister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrackRegister);
			return cb_trackRegister;
		}

		static void n_TrackRegister (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.UTrack __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.UTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackRegister ();
		}
#pragma warning restore 0169

		static IntPtr id_trackRegister;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UTrack']/method[@name='trackRegister' and count(parameter)=0]"
		[Register ("trackRegister", "()V", "GetTrackRegisterHandler")]
		public virtual void TrackRegister ()
		{
			if (id_trackRegister == IntPtr.Zero)
				id_trackRegister = JNIEnv.GetMethodID (class_ref, "trackRegister", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_trackRegister);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackRegister", "()V"));
		}

	}
}
