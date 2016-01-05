using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']"
	[global::Android.Runtime.Register ("com/umeng/message/PushAgent", DoNotGenerateAcw=true)]
	public partial class PushAgent : global::Java.Lang.Object {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/PushAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushAgent); }
		}

		protected PushAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isAppLaunchByMessage;
		public static bool IsAppLaunchByMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='isAppLaunchByMessage' and count(parameter)=0]"
			[Register ("isAppLaunchByMessage", "()Z", "GetIsAppLaunchByMessageHandler")]
			get {
				if (id_isAppLaunchByMessage == IntPtr.Zero)
					id_isAppLaunchByMessage = JNIEnv.GetStaticMethodID (class_ref, "isAppLaunchByMessage", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAppLaunchByMessage);
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		public virtual bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
			}
		}

		static Delegate cb_isIncludesUmengUpdateSDK;
#pragma warning disable 0169
		static Delegate GetIsIncludesUmengUpdateSDKHandler ()
		{
			if (cb_isIncludesUmengUpdateSDK == null)
				cb_isIncludesUmengUpdateSDK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIncludesUmengUpdateSDK);
			return cb_isIncludesUmengUpdateSDK;
		}

		static bool n_IsIncludesUmengUpdateSDK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIncludesUmengUpdateSDK;
		}
#pragma warning restore 0169

		static IntPtr id_isIncludesUmengUpdateSDK;
		public virtual bool IsIncludesUmengUpdateSDK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='isIncludesUmengUpdateSDK' and count(parameter)=0]"
			[Register ("isIncludesUmengUpdateSDK", "()Z", "GetIsIncludesUmengUpdateSDKHandler")]
			get {
				if (id_isIncludesUmengUpdateSDK == IntPtr.Zero)
					id_isIncludesUmengUpdateSDK = JNIEnv.GetMethodID (class_ref, "isIncludesUmengUpdateSDK", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isIncludesUmengUpdateSDK);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIncludesUmengUpdateSDK", "()Z"));
			}
		}

		static Delegate cb_isRegistered;
#pragma warning disable 0169
		static Delegate GetIsRegisteredHandler ()
		{
			if (cb_isRegistered == null)
				cb_isRegistered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegistered);
			return cb_isRegistered;
		}

		static bool n_IsRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegistered;
		}
#pragma warning restore 0169

		static IntPtr id_isRegistered;
		public virtual bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "GetIsRegisteredHandler")]
			get {
				if (id_isRegistered == IntPtr.Zero)
					id_isRegistered = JNIEnv.GetMethodID (class_ref, "isRegistered", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isRegistered);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRegistered", "()Z"));
			}
		}

		static Delegate cb_getMergeNotificaiton;
#pragma warning disable 0169
		static Delegate GetGetMergeNotificaitonHandler ()
		{
			if (cb_getMergeNotificaiton == null)
				cb_getMergeNotificaiton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetMergeNotificaiton);
			return cb_getMergeNotificaiton;
		}

		static bool n_GetMergeNotificaiton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MergeNotificaiton;
		}
#pragma warning restore 0169

		static Delegate cb_setMergeNotificaiton_Z;
#pragma warning disable 0169
		static Delegate GetSetMergeNotificaiton_ZHandler ()
		{
			if (cb_setMergeNotificaiton_Z == null)
				cb_setMergeNotificaiton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMergeNotificaiton_Z);
			return cb_setMergeNotificaiton_Z;
		}

		static void n_SetMergeNotificaiton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MergeNotificaiton = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMergeNotificaiton;
		static IntPtr id_setMergeNotificaiton_Z;
		public virtual bool MergeNotificaiton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getMergeNotificaiton' and count(parameter)=0]"
			[Register ("getMergeNotificaiton", "()Z", "GetGetMergeNotificaitonHandler")]
			get {
				if (id_getMergeNotificaiton == IntPtr.Zero)
					id_getMergeNotificaiton = JNIEnv.GetMethodID (class_ref, "getMergeNotificaiton", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getMergeNotificaiton);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMergeNotificaiton", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setMergeNotificaiton' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMergeNotificaiton", "(Z)V", "GetSetMergeNotificaiton_ZHandler")]
			set {
				if (id_setMergeNotificaiton_Z == IntPtr.Zero)
					id_setMergeNotificaiton_Z = JNIEnv.GetMethodID (class_ref, "setMergeNotificaiton", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMergeNotificaiton_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMergeNotificaiton", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getMessageAppkey;
#pragma warning disable 0169
		static Delegate GetGetMessageAppkeyHandler ()
		{
			if (cb_getMessageAppkey == null)
				cb_getMessageAppkey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageAppkey);
			return cb_getMessageAppkey;
		}

		static IntPtr n_GetMessageAppkey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageAppkey);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageAppkey;
		public virtual string MessageAppkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getMessageAppkey' and count(parameter)=0]"
			[Register ("getMessageAppkey", "()Ljava/lang/String;", "GetGetMessageAppkeyHandler")]
			get {
				if (id_getMessageAppkey == IntPtr.Zero)
					id_getMessageAppkey = JNIEnv.GetMethodID (class_ref, "getMessageAppkey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageAppkey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageAppkey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessageChannel;
#pragma warning disable 0169
		static Delegate GetGetMessageChannelHandler ()
		{
			if (cb_getMessageChannel == null)
				cb_getMessageChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageChannel);
			return cb_getMessageChannel;
		}

		static IntPtr n_GetMessageChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageChannel);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageChannel_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageChannel_Ljava_lang_String_ == null)
				cb_setMessageChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageChannel_Ljava_lang_String_);
			return cb_setMessageChannel_Ljava_lang_String_;
		}

		static void n_SetMessageChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageChannel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageChannel;
		static IntPtr id_setMessageChannel_Ljava_lang_String_;
		public virtual string MessageChannel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getMessageChannel' and count(parameter)=0]"
			[Register ("getMessageChannel", "()Ljava/lang/String;", "GetGetMessageChannelHandler")]
			get {
				if (id_getMessageChannel == IntPtr.Zero)
					id_getMessageChannel = JNIEnv.GetMethodID (class_ref, "getMessageChannel", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageChannel), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageChannel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setMessageChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageChannel", "(Ljava/lang/String;)V", "GetSetMessageChannel_Ljava_lang_String_Handler")]
			set {
				if (id_setMessageChannel_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageChannel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMessageChannel_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageChannel", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getMessageHandler;
#pragma warning disable 0169
		static Delegate GetGetMessageHandlerHandler ()
		{
			if (cb_getMessageHandler == null)
				cb_getMessageHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageHandler);
			return cb_getMessageHandler;
		}

		static IntPtr n_GetMessageHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageHandler);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageHandler_Lcom_umeng_message_UHandler_;
#pragma warning disable 0169
		static Delegate GetSetMessageHandler_Lcom_umeng_message_UHandler_Handler ()
		{
			if (cb_setMessageHandler_Lcom_umeng_message_UHandler_ == null)
				cb_setMessageHandler_Lcom_umeng_message_UHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageHandler_Lcom_umeng_message_UHandler_);
			return cb_setMessageHandler_Lcom_umeng_message_UHandler_;
		}

		static void n_SetMessageHandler_Lcom_umeng_message_UHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.IUHandler p0 = (global::Com.Umeng.Message.IUHandler)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageHandler = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageHandler;
		static IntPtr id_setMessageHandler_Lcom_umeng_message_UHandler_;
		public virtual global::Com.Umeng.Message.IUHandler MessageHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getMessageHandler' and count(parameter)=0]"
			[Register ("getMessageHandler", "()Lcom/umeng/message/UHandler;", "GetGetMessageHandlerHandler")]
			get {
				if (id_getMessageHandler == IntPtr.Zero)
					id_getMessageHandler = JNIEnv.GetMethodID (class_ref, "getMessageHandler", "()Lcom/umeng/message/UHandler;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (JNIEnv.CallObjectMethod  (Handle, id_getMessageHandler), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageHandler", "()Lcom/umeng/message/UHandler;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setMessageHandler' and count(parameter)=1 and parameter[1][@type='com.umeng.message.UHandler']]"
			[Register ("setMessageHandler", "(Lcom/umeng/message/UHandler;)V", "GetSetMessageHandler_Lcom_umeng_message_UHandler_Handler")]
			set {
				if (id_setMessageHandler_Lcom_umeng_message_UHandler_ == IntPtr.Zero)
					id_setMessageHandler_Lcom_umeng_message_UHandler_ = JNIEnv.GetMethodID (class_ref, "setMessageHandler", "(Lcom/umeng/message/UHandler;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMessageHandler_Lcom_umeng_message_UHandler_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageHandler", "(Lcom/umeng/message/UHandler;)V"), new JValue (value));
			}
		}

		static Delegate cb_getMessageSecret;
#pragma warning disable 0169
		static Delegate GetGetMessageSecretHandler ()
		{
			if (cb_getMessageSecret == null)
				cb_getMessageSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageSecret);
			return cb_getMessageSecret;
		}

		static IntPtr n_GetMessageSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageSecret;
		public virtual string MessageSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getMessageSecret' and count(parameter)=0]"
			[Register ("getMessageSecret", "()Ljava/lang/String;", "GetGetMessageSecretHandler")]
			get {
				if (id_getMessageSecret == IntPtr.Zero)
					id_getMessageSecret = JNIEnv.GetMethodID (class_ref, "getMessageSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMuteDurationSeconds;
#pragma warning disable 0169
		static Delegate GetGetMuteDurationSecondsHandler ()
		{
			if (cb_getMuteDurationSeconds == null)
				cb_getMuteDurationSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMuteDurationSeconds);
			return cb_getMuteDurationSeconds;
		}

		static int n_GetMuteDurationSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MuteDurationSeconds;
		}
#pragma warning restore 0169

		static Delegate cb_setMuteDurationSeconds_I;
#pragma warning disable 0169
		static Delegate GetSetMuteDurationSeconds_IHandler ()
		{
			if (cb_setMuteDurationSeconds_I == null)
				cb_setMuteDurationSeconds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMuteDurationSeconds_I);
			return cb_setMuteDurationSeconds_I;
		}

		static void n_SetMuteDurationSeconds_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MuteDurationSeconds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMuteDurationSeconds;
		static IntPtr id_setMuteDurationSeconds_I;
		public virtual int MuteDurationSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getMuteDurationSeconds' and count(parameter)=0]"
			[Register ("getMuteDurationSeconds", "()I", "GetGetMuteDurationSecondsHandler")]
			get {
				if (id_getMuteDurationSeconds == IntPtr.Zero)
					id_getMuteDurationSeconds = JNIEnv.GetMethodID (class_ref, "getMuteDurationSeconds", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMuteDurationSeconds);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMuteDurationSeconds", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setMuteDurationSeconds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMuteDurationSeconds", "(I)V", "GetSetMuteDurationSeconds_IHandler")]
			set {
				if (id_setMuteDurationSeconds_I == IntPtr.Zero)
					id_setMuteDurationSeconds_I = JNIEnv.GetMethodID (class_ref, "setMuteDurationSeconds", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMuteDurationSeconds_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMuteDurationSeconds", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getNoDisturbEndHour;
#pragma warning disable 0169
		static Delegate GetGetNoDisturbEndHourHandler ()
		{
			if (cb_getNoDisturbEndHour == null)
				cb_getNoDisturbEndHour = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNoDisturbEndHour);
			return cb_getNoDisturbEndHour;
		}

		static int n_GetNoDisturbEndHour (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoDisturbEndHour;
		}
#pragma warning restore 0169

		static IntPtr id_getNoDisturbEndHour;
		public virtual int NoDisturbEndHour {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getNoDisturbEndHour' and count(parameter)=0]"
			[Register ("getNoDisturbEndHour", "()I", "GetGetNoDisturbEndHourHandler")]
			get {
				if (id_getNoDisturbEndHour == IntPtr.Zero)
					id_getNoDisturbEndHour = JNIEnv.GetMethodID (class_ref, "getNoDisturbEndHour", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNoDisturbEndHour);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoDisturbEndHour", "()I"));
			}
		}

		static Delegate cb_getNoDisturbEndMinute;
#pragma warning disable 0169
		static Delegate GetGetNoDisturbEndMinuteHandler ()
		{
			if (cb_getNoDisturbEndMinute == null)
				cb_getNoDisturbEndMinute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNoDisturbEndMinute);
			return cb_getNoDisturbEndMinute;
		}

		static int n_GetNoDisturbEndMinute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoDisturbEndMinute;
		}
#pragma warning restore 0169

		static IntPtr id_getNoDisturbEndMinute;
		public virtual int NoDisturbEndMinute {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getNoDisturbEndMinute' and count(parameter)=0]"
			[Register ("getNoDisturbEndMinute", "()I", "GetGetNoDisturbEndMinuteHandler")]
			get {
				if (id_getNoDisturbEndMinute == IntPtr.Zero)
					id_getNoDisturbEndMinute = JNIEnv.GetMethodID (class_ref, "getNoDisturbEndMinute", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNoDisturbEndMinute);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoDisturbEndMinute", "()I"));
			}
		}

		static Delegate cb_getNoDisturbStartHour;
#pragma warning disable 0169
		static Delegate GetGetNoDisturbStartHourHandler ()
		{
			if (cb_getNoDisturbStartHour == null)
				cb_getNoDisturbStartHour = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNoDisturbStartHour);
			return cb_getNoDisturbStartHour;
		}

		static int n_GetNoDisturbStartHour (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoDisturbStartHour;
		}
#pragma warning restore 0169

		static IntPtr id_getNoDisturbStartHour;
		public virtual int NoDisturbStartHour {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getNoDisturbStartHour' and count(parameter)=0]"
			[Register ("getNoDisturbStartHour", "()I", "GetGetNoDisturbStartHourHandler")]
			get {
				if (id_getNoDisturbStartHour == IntPtr.Zero)
					id_getNoDisturbStartHour = JNIEnv.GetMethodID (class_ref, "getNoDisturbStartHour", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNoDisturbStartHour);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoDisturbStartHour", "()I"));
			}
		}

		static Delegate cb_getNoDisturbStartMinute;
#pragma warning disable 0169
		static Delegate GetGetNoDisturbStartMinuteHandler ()
		{
			if (cb_getNoDisturbStartMinute == null)
				cb_getNoDisturbStartMinute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNoDisturbStartMinute);
			return cb_getNoDisturbStartMinute;
		}

		static int n_GetNoDisturbStartMinute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoDisturbStartMinute;
		}
#pragma warning restore 0169

		static IntPtr id_getNoDisturbStartMinute;
		public virtual int NoDisturbStartMinute {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getNoDisturbStartMinute' and count(parameter)=0]"
			[Register ("getNoDisturbStartMinute", "()I", "GetGetNoDisturbStartMinuteHandler")]
			get {
				if (id_getNoDisturbStartMinute == IntPtr.Zero)
					id_getNoDisturbStartMinute = JNIEnv.GetMethodID (class_ref, "getNoDisturbStartMinute", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNoDisturbStartMinute);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoDisturbStartMinute", "()I"));
			}
		}

		static Delegate cb_getNotificationClickHandler;
#pragma warning disable 0169
		static Delegate GetGetNotificationClickHandlerHandler ()
		{
			if (cb_getNotificationClickHandler == null)
				cb_getNotificationClickHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationClickHandler);
			return cb_getNotificationClickHandler;
		}

		static IntPtr n_GetNotificationClickHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotificationClickHandler);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationClickHandler_Lcom_umeng_message_UHandler_;
#pragma warning disable 0169
		static Delegate GetSetNotificationClickHandler_Lcom_umeng_message_UHandler_Handler ()
		{
			if (cb_setNotificationClickHandler_Lcom_umeng_message_UHandler_ == null)
				cb_setNotificationClickHandler_Lcom_umeng_message_UHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationClickHandler_Lcom_umeng_message_UHandler_);
			return cb_setNotificationClickHandler_Lcom_umeng_message_UHandler_;
		}

		static void n_SetNotificationClickHandler_Lcom_umeng_message_UHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.IUHandler p0 = (global::Com.Umeng.Message.IUHandler)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationClickHandler = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationClickHandler;
		static IntPtr id_setNotificationClickHandler_Lcom_umeng_message_UHandler_;
		public virtual global::Com.Umeng.Message.IUHandler NotificationClickHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getNotificationClickHandler' and count(parameter)=0]"
			[Register ("getNotificationClickHandler", "()Lcom/umeng/message/UHandler;", "GetGetNotificationClickHandlerHandler")]
			get {
				if (id_getNotificationClickHandler == IntPtr.Zero)
					id_getNotificationClickHandler = JNIEnv.GetMethodID (class_ref, "getNotificationClickHandler", "()Lcom/umeng/message/UHandler;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (JNIEnv.CallObjectMethod  (Handle, id_getNotificationClickHandler), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUHandler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationClickHandler", "()Lcom/umeng/message/UHandler;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setNotificationClickHandler' and count(parameter)=1 and parameter[1][@type='com.umeng.message.UHandler']]"
			[Register ("setNotificationClickHandler", "(Lcom/umeng/message/UHandler;)V", "GetSetNotificationClickHandler_Lcom_umeng_message_UHandler_Handler")]
			set {
				if (id_setNotificationClickHandler_Lcom_umeng_message_UHandler_ == IntPtr.Zero)
					id_setNotificationClickHandler_Lcom_umeng_message_UHandler_ = JNIEnv.GetMethodID (class_ref, "setNotificationClickHandler", "(Lcom/umeng/message/UHandler;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNotificationClickHandler_Lcom_umeng_message_UHandler_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationClickHandler", "(Lcom/umeng/message/UHandler;)V"), new JValue (value));
			}
		}

		static Delegate cb_getNotificationOnForeground;
#pragma warning disable 0169
		static Delegate GetGetNotificationOnForegroundHandler ()
		{
			if (cb_getNotificationOnForeground == null)
				cb_getNotificationOnForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNotificationOnForeground);
			return cb_getNotificationOnForeground;
		}

		static bool n_GetNotificationOnForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationOnForeground;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationOnForeground;
		public virtual bool NotificationOnForeground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getNotificationOnForeground' and count(parameter)=0]"
			[Register ("getNotificationOnForeground", "()Z", "GetGetNotificationOnForegroundHandler")]
			get {
				if (id_getNotificationOnForeground == IntPtr.Zero)
					id_getNotificationOnForeground = JNIEnv.GetMethodID (class_ref, "getNotificationOnForeground", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getNotificationOnForeground);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationOnForeground", "()Z"));
			}
		}

		static Delegate cb_getPushIntentServiceClass;
#pragma warning disable 0169
		static Delegate GetGetPushIntentServiceClassHandler ()
		{
			if (cb_getPushIntentServiceClass == null)
				cb_getPushIntentServiceClass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushIntentServiceClass);
			return cb_getPushIntentServiceClass;
		}

		static IntPtr n_GetPushIntentServiceClass (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PushIntentServiceClass);
		}
#pragma warning restore 0169

		static IntPtr id_getPushIntentServiceClass;
		public virtual string PushIntentServiceClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getPushIntentServiceClass' and count(parameter)=0]"
			[Register ("getPushIntentServiceClass", "()Ljava/lang/String;", "GetGetPushIntentServiceClassHandler")]
			get {
				if (id_getPushIntentServiceClass == IntPtr.Zero)
					id_getPushIntentServiceClass = JNIEnv.GetMethodID (class_ref, "getPushIntentServiceClass", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPushIntentServiceClass), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPushIntentServiceClass", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRegisterCallback;
#pragma warning disable 0169
		static Delegate GetGetRegisterCallbackHandler ()
		{
			if (cb_getRegisterCallback == null)
				cb_getRegisterCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegisterCallback);
			return cb_getRegisterCallback;
		}

		static IntPtr n_GetRegisterCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RegisterCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_;
#pragma warning disable 0169
		static Delegate GetSetRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_Handler ()
		{
			if (cb_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_ == null)
				cb_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_);
			return cb_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_;
		}

		static void n_SetRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.IUmengRegisterCallback p0 = (global::Com.Umeng.Message.IUmengRegisterCallback)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengRegisterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegisterCallback;
		static IntPtr id_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_;
		public virtual global::Com.Umeng.Message.IUmengRegisterCallback RegisterCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getRegisterCallback' and count(parameter)=0]"
			[Register ("getRegisterCallback", "()Lcom/umeng/message/IUmengRegisterCallback;", "GetGetRegisterCallbackHandler")]
			get {
				if (id_getRegisterCallback == IntPtr.Zero)
					id_getRegisterCallback = JNIEnv.GetMethodID (class_ref, "getRegisterCallback", "()Lcom/umeng/message/IUmengRegisterCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengRegisterCallback> (JNIEnv.CallObjectMethod  (Handle, id_getRegisterCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengRegisterCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegisterCallback", "()Lcom/umeng/message/IUmengRegisterCallback;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setRegisterCallback' and count(parameter)=1 and parameter[1][@type='com.umeng.message.IUmengRegisterCallback']]"
			[Register ("setRegisterCallback", "(Lcom/umeng/message/IUmengRegisterCallback;)V", "GetSetRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_Handler")]
			set {
				if (id_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_ == IntPtr.Zero)
					id_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_ = JNIEnv.GetMethodID (class_ref, "setRegisterCallback", "(Lcom/umeng/message/IUmengRegisterCallback;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRegisterCallback_Lcom_umeng_message_IUmengRegisterCallback_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegisterCallback", "(Lcom/umeng/message/IUmengRegisterCallback;)V"), new JValue (value));
			}
		}

		static Delegate cb_getRegistrationId;
#pragma warning disable 0169
		static Delegate GetGetRegistrationIdHandler ()
		{
			if (cb_getRegistrationId == null)
				cb_getRegistrationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegistrationId);
			return cb_getRegistrationId;
		}

		static IntPtr n_GetRegistrationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegistrationId);
		}
#pragma warning restore 0169

		static IntPtr id_getRegistrationId;
		public virtual string RegistrationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getRegistrationId' and count(parameter)=0]"
			[Register ("getRegistrationId", "()Ljava/lang/String;", "GetGetRegistrationIdHandler")]
			get {
				if (id_getRegistrationId == IntPtr.Zero)
					id_getRegistrationId = JNIEnv.GetMethodID (class_ref, "getRegistrationId", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRegistrationId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegistrationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTagManager;
#pragma warning disable 0169
		static Delegate GetGetTagManagerHandler ()
		{
			if (cb_getTagManager == null)
				cb_getTagManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTagManager);
			return cb_getTagManager;
		}

		static IntPtr n_GetTagManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TagManager);
		}
#pragma warning restore 0169

		static IntPtr id_getTagManager;
		public virtual global::Com.Umeng.Message.Tag.TagManager TagManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getTagManager' and count(parameter)=0]"
			[Register ("getTagManager", "()Lcom/umeng/message/tag/TagManager;", "GetGetTagManagerHandler")]
			get {
				if (id_getTagManager == IntPtr.Zero)
					id_getTagManager = JNIEnv.GetMethodID (class_ref, "getTagManager", "()Lcom/umeng/message/tag/TagManager;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (JNIEnv.CallObjectMethod  (Handle, id_getTagManager), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Tag.TagManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTagManager", "()Lcom/umeng/message/tag/TagManager;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUnregisterCallback;
#pragma warning disable 0169
		static Delegate GetGetUnregisterCallbackHandler ()
		{
			if (cb_getUnregisterCallback == null)
				cb_getUnregisterCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnregisterCallback);
			return cb_getUnregisterCallback;
		}

		static IntPtr n_GetUnregisterCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnregisterCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_;
#pragma warning disable 0169
		static Delegate GetSetUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_Handler ()
		{
			if (cb_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_ == null)
				cb_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_);
			return cb_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_;
		}

		static void n_SetUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.IUmengUnregisterCallback p0 = (global::Com.Umeng.Message.IUmengUnregisterCallback)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengUnregisterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterCallback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnregisterCallback;
		static IntPtr id_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_;
		public virtual global::Com.Umeng.Message.IUmengUnregisterCallback UnregisterCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getUnregisterCallback' and count(parameter)=0]"
			[Register ("getUnregisterCallback", "()Lcom/umeng/message/IUmengUnregisterCallback;", "GetGetUnregisterCallbackHandler")]
			get {
				if (id_getUnregisterCallback == IntPtr.Zero)
					id_getUnregisterCallback = JNIEnv.GetMethodID (class_ref, "getUnregisterCallback", "()Lcom/umeng/message/IUmengUnregisterCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengUnregisterCallback> (JNIEnv.CallObjectMethod  (Handle, id_getUnregisterCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengUnregisterCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnregisterCallback", "()Lcom/umeng/message/IUmengUnregisterCallback;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setUnregisterCallback' and count(parameter)=1 and parameter[1][@type='com.umeng.message.IUmengUnregisterCallback']]"
			[Register ("setUnregisterCallback", "(Lcom/umeng/message/IUmengUnregisterCallback;)V", "GetSetUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_Handler")]
			set {
				if (id_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_ == IntPtr.Zero)
					id_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_ = JNIEnv.GetMethodID (class_ref, "setUnregisterCallback", "(Lcom/umeng/message/IUmengUnregisterCallback;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUnregisterCallback_Lcom_umeng_message_IUmengUnregisterCallback_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnregisterCallback", "(Lcom/umeng/message/IUmengUnregisterCallback;)V"), new JValue (value));
			}
		}

		static Delegate cb_getUpdateResponse;
#pragma warning disable 0169
		static Delegate GetGetUpdateResponseHandler ()
		{
			if (cb_getUpdateResponse == null)
				cb_getUpdateResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateResponse);
			return cb_getUpdateResponse;
		}

		static IntPtr n_GetUpdateResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpdateResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setUpdateResponse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetUpdateResponse_Ljava_lang_Object_Handler ()
		{
			if (cb_setUpdateResponse_Ljava_lang_Object_ == null)
				cb_setUpdateResponse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUpdateResponse_Ljava_lang_Object_);
			return cb_setUpdateResponse_Ljava_lang_Object_;
		}

		static void n_SetUpdateResponse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateResponse;
		static IntPtr id_setUpdateResponse_Ljava_lang_Object_;
		public virtual global::Java.Lang.Object UpdateResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getUpdateResponse' and count(parameter)=0]"
			[Register ("getUpdateResponse", "()Ljava/lang/Object;", "GetGetUpdateResponseHandler")]
			get {
				if (id_getUpdateResponse == IntPtr.Zero)
					id_getUpdateResponse = JNIEnv.GetMethodID (class_ref, "getUpdateResponse", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getUpdateResponse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateResponse", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setUpdateResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setUpdateResponse", "(Ljava/lang/Object;)V", "GetSetUpdateResponse_Ljava_lang_Object_Handler")]
			set {
				if (id_setUpdateResponse_Ljava_lang_Object_ == IntPtr.Zero)
					id_setUpdateResponse_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setUpdateResponse", "(Ljava/lang/Object;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUpdateResponse_Ljava_lang_Object_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpdateResponse", "(Ljava/lang/Object;)V"), new JValue (value));
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
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAlias (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAlias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='addAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public virtual void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
		}

		static Delegate cb_disable_Lcom_umeng_message_IUmengUnregisterCallback_;
#pragma warning disable 0169
		static Delegate GetDisable_Lcom_umeng_message_IUmengUnregisterCallback_Handler ()
		{
			if (cb_disable_Lcom_umeng_message_IUmengUnregisterCallback_ == null)
				cb_disable_Lcom_umeng_message_IUmengUnregisterCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disable_Lcom_umeng_message_IUmengUnregisterCallback_);
			return cb_disable_Lcom_umeng_message_IUmengUnregisterCallback_;
		}

		static void n_Disable_Lcom_umeng_message_IUmengUnregisterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.IUmengUnregisterCallback p0 = (global::Com.Umeng.Message.IUmengUnregisterCallback)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengUnregisterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disable_Lcom_umeng_message_IUmengUnregisterCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='disable' and count(parameter)=1 and parameter[1][@type='com.umeng.message.IUmengUnregisterCallback']]"
		[Register ("disable", "(Lcom/umeng/message/IUmengUnregisterCallback;)V", "GetDisable_Lcom_umeng_message_IUmengUnregisterCallback_Handler")]
		public virtual void Disable (global::Com.Umeng.Message.IUmengUnregisterCallback p0)
		{
			if (id_disable_Lcom_umeng_message_IUmengUnregisterCallback_ == IntPtr.Zero)
				id_disable_Lcom_umeng_message_IUmengUnregisterCallback_ = JNIEnv.GetMethodID (class_ref, "disable", "(Lcom/umeng/message/IUmengUnregisterCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disable_Lcom_umeng_message_IUmengUnregisterCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "(Lcom/umeng/message/IUmengUnregisterCallback;)V"), new JValue (p0));
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler")]
		public virtual void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "()V"));
		}

		static Delegate cb_enable_Lcom_umeng_message_IUmengRegisterCallback_;
#pragma warning disable 0169
		static Delegate GetEnable_Lcom_umeng_message_IUmengRegisterCallback_Handler ()
		{
			if (cb_enable_Lcom_umeng_message_IUmengRegisterCallback_ == null)
				cb_enable_Lcom_umeng_message_IUmengRegisterCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Enable_Lcom_umeng_message_IUmengRegisterCallback_);
			return cb_enable_Lcom_umeng_message_IUmengRegisterCallback_;
		}

		static void n_Enable_Lcom_umeng_message_IUmengRegisterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.IUmengRegisterCallback p0 = (global::Com.Umeng.Message.IUmengRegisterCallback)global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.IUmengRegisterCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Lcom_umeng_message_IUmengRegisterCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='com.umeng.message.IUmengRegisterCallback']]"
		[Register ("enable", "(Lcom/umeng/message/IUmengRegisterCallback;)V", "GetEnable_Lcom_umeng_message_IUmengRegisterCallback_Handler")]
		public virtual void Enable (global::Com.Umeng.Message.IUmengRegisterCallback p0)
		{
			if (id_enable_Lcom_umeng_message_IUmengRegisterCallback_ == IntPtr.Zero)
				id_enable_Lcom_umeng_message_IUmengRegisterCallback_ = JNIEnv.GetMethodID (class_ref, "enable", "(Lcom/umeng/message/IUmengRegisterCallback;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enable_Lcom_umeng_message_IUmengRegisterCallback_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(Lcom/umeng/message/IUmengRegisterCallback;)V"), new JValue (p0));
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/PushAgent;", "")]
		public static global::Com.Umeng.Message.PushAgent GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/PushAgent;");
			global::Com.Umeng.Message.PushAgent __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onAppStart;
#pragma warning disable 0169
		static Delegate GetOnAppStartHandler ()
		{
			if (cb_onAppStart == null)
				cb_onAppStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAppStart);
			return cb_onAppStart;
		}

		static void n_OnAppStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAppStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onAppStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='onAppStart' and count(parameter)=0]"
		[Register ("onAppStart", "()V", "GetOnAppStartHandler")]
		public virtual void OnAppStart ()
		{
			if (id_onAppStart == IntPtr.Zero)
				id_onAppStart = JNIEnv.GetMethodID (class_ref, "onAppStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAppStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAppStart", "()V"));
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
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAlias (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAlias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='removeAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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

		static IntPtr id_setAppLaunchByMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setAppLaunchByMessage' and count(parameter)=0]"
		[Register ("setAppLaunchByMessage", "()V", "")]
		public static void SetAppLaunchByMessage ()
		{
			if (id_setAppLaunchByMessage == IntPtr.Zero)
				id_setAppLaunchByMessage = JNIEnv.GetStaticMethodID (class_ref, "setAppLaunchByMessage", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppLaunchByMessage);
		}

		static Delegate cb_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAppkeyAndSecret (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setAppkeyAndSecret' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAppkeyAndSecret", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void SetAppkeyAndSecret (string p0, string p1)
		{
			if (id_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppkeyAndSecret", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAppkeyAndSecret_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppkeyAndSecret", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setDebugMode_Z;
#pragma warning disable 0169
		static Delegate GetSetDebugMode_ZHandler ()
		{
			if (cb_setDebugMode_Z == null)
				cb_setDebugMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebugMode_Z);
			return cb_setDebugMode_Z;
		}

		static void n_SetDebugMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebugMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugMode", "(Z)V", "GetSetDebugMode_ZHandler")]
		public virtual void SetDebugMode (bool p0)
		{
			if (id_setDebugMode_Z == IntPtr.Zero)
				id_setDebugMode_Z = JNIEnv.GetMethodID (class_ref, "setDebugMode", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDebugMode_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugMode", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setNoDisturbMode_IIII;
#pragma warning disable 0169
		static Delegate GetSetNoDisturbMode_IIIIHandler ()
		{
			if (cb_setNoDisturbMode_IIII == null)
				cb_setNoDisturbMode_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_SetNoDisturbMode_IIII);
			return cb_setNoDisturbMode_IIII;
		}

		static void n_SetNoDisturbMode_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNoDisturbMode (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setNoDisturbMode_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setNoDisturbMode' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setNoDisturbMode", "(IIII)V", "GetSetNoDisturbMode_IIIIHandler")]
		public virtual void SetNoDisturbMode (int p0, int p1, int p2, int p3)
		{
			if (id_setNoDisturbMode_IIII == IntPtr.Zero)
				id_setNoDisturbMode_IIII = JNIEnv.GetMethodID (class_ref, "setNoDisturbMode", "(IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNoDisturbMode_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNoDisturbMode", "(IIII)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_setNotificaitonOnForeground_Z;
#pragma warning disable 0169
		static Delegate GetSetNotificaitonOnForeground_ZHandler ()
		{
			if (cb_setNotificaitonOnForeground_Z == null)
				cb_setNotificaitonOnForeground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNotificaitonOnForeground_Z);
			return cb_setNotificaitonOnForeground_Z;
		}

		static void n_SetNotificaitonOnForeground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificaitonOnForeground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNotificaitonOnForeground_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setNotificaitonOnForeground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNotificaitonOnForeground", "(Z)V", "GetSetNotificaitonOnForeground_ZHandler")]
		public virtual void SetNotificaitonOnForeground (bool p0)
		{
			if (id_setNotificaitonOnForeground_Z == IntPtr.Zero)
				id_setNotificaitonOnForeground_Z = JNIEnv.GetMethodID (class_ref, "setNotificaitonOnForeground", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNotificaitonOnForeground_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificaitonOnForeground", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setPushIntentServiceClass_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetPushIntentServiceClass_Ljava_lang_Class_Handler ()
		{
			if (cb_setPushIntentServiceClass_Ljava_lang_Class_ == null)
				cb_setPushIntentServiceClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPushIntentServiceClass_Ljava_lang_Class_);
			return cb_setPushIntentServiceClass_Ljava_lang_Class_;
		}

		static void n_SetPushIntentServiceClass_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.PushAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.PushAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPushIntentServiceClass (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPushIntentServiceClass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='PushAgent']/method[@name='setPushIntentServiceClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("setPushIntentServiceClass", "(Ljava/lang/Class;)V", "GetSetPushIntentServiceClass_Ljava_lang_Class_Handler")]
		public virtual void SetPushIntentServiceClass (global::Java.Lang.Class p0)
		{
			if (id_setPushIntentServiceClass_Ljava_lang_Class_ == IntPtr.Zero)
				id_setPushIntentServiceClass_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setPushIntentServiceClass", "(Ljava/lang/Class;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPushIntentServiceClass_Ljava_lang_Class_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushIntentServiceClass", "(Ljava/lang/Class;)V"), new JValue (p0));
		}

	}
}
