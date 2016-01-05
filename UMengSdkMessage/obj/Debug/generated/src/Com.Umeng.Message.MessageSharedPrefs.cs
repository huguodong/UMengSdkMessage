using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']"
	[global::Android.Runtime.Register ("com/umeng/message/MessageSharedPrefs", DoNotGenerateAcw=true)]
	public partial class MessageSharedPrefs : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/MessageSharedPrefs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageSharedPrefs); }
		}

		protected MessageSharedPrefs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAliasCount;
#pragma warning disable 0169
		static Delegate GetGetAliasCountHandler ()
		{
			if (cb_getAliasCount == null)
				cb_getAliasCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAliasCount);
			return cb_getAliasCount;
		}

		static int n_GetAliasCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AliasCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAliasCount;
		public virtual int AliasCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getAliasCount' and count(parameter)=0]"
			[Register ("getAliasCount", "()I", "GetGetAliasCountHandler")]
			get {
				if (id_getAliasCount == IntPtr.Zero)
					id_getAliasCount = JNIEnv.GetMethodID (class_ref, "getAliasCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAliasCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAliasCount", "()I"));
			}
		}

		static Delegate cb_getAppLaunchLogSendPolicy;
#pragma warning disable 0169
		static Delegate GetGetAppLaunchLogSendPolicyHandler ()
		{
			if (cb_getAppLaunchLogSendPolicy == null)
				cb_getAppLaunchLogSendPolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAppLaunchLogSendPolicy);
			return cb_getAppLaunchLogSendPolicy;
		}

		static int n_GetAppLaunchLogSendPolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppLaunchLogSendPolicy;
		}
#pragma warning restore 0169

		static Delegate cb_setAppLaunchLogSendPolicy_I;
#pragma warning disable 0169
		static Delegate GetSetAppLaunchLogSendPolicy_IHandler ()
		{
			if (cb_setAppLaunchLogSendPolicy_I == null)
				cb_setAppLaunchLogSendPolicy_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAppLaunchLogSendPolicy_I);
			return cb_setAppLaunchLogSendPolicy_I;
		}

		static void n_SetAppLaunchLogSendPolicy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AppLaunchLogSendPolicy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppLaunchLogSendPolicy;
		static IntPtr id_setAppLaunchLogSendPolicy_I;
		public virtual int AppLaunchLogSendPolicy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getAppLaunchLogSendPolicy' and count(parameter)=0]"
			[Register ("getAppLaunchLogSendPolicy", "()I", "GetGetAppLaunchLogSendPolicyHandler")]
			get {
				if (id_getAppLaunchLogSendPolicy == IntPtr.Zero)
					id_getAppLaunchLogSendPolicy = JNIEnv.GetMethodID (class_ref, "getAppLaunchLogSendPolicy", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAppLaunchLogSendPolicy);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppLaunchLogSendPolicy", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setAppLaunchLogSendPolicy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAppLaunchLogSendPolicy", "(I)V", "GetSetAppLaunchLogSendPolicy_IHandler")]
			set {
				if (id_setAppLaunchLogSendPolicy_I == IntPtr.Zero)
					id_setAppLaunchLogSendPolicy_I = JNIEnv.GetMethodID (class_ref, "setAppLaunchLogSendPolicy", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppLaunchLogSendPolicy_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppLaunchLogSendPolicy", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getAppLaunchLogSentAt;
#pragma warning disable 0169
		static Delegate GetGetAppLaunchLogSentAtHandler ()
		{
			if (cb_getAppLaunchLogSentAt == null)
				cb_getAppLaunchLogSentAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAppLaunchLogSentAt);
			return cb_getAppLaunchLogSentAt;
		}

		static long n_GetAppLaunchLogSentAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AppLaunchLogSentAt;
		}
#pragma warning restore 0169

		static Delegate cb_setAppLaunchLogSentAt_J;
#pragma warning disable 0169
		static Delegate GetSetAppLaunchLogSentAt_JHandler ()
		{
			if (cb_setAppLaunchLogSentAt_J == null)
				cb_setAppLaunchLogSentAt_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAppLaunchLogSentAt_J);
			return cb_setAppLaunchLogSentAt_J;
		}

		static void n_SetAppLaunchLogSentAt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AppLaunchLogSentAt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppLaunchLogSentAt;
		static IntPtr id_setAppLaunchLogSentAt_J;
		public virtual long AppLaunchLogSentAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getAppLaunchLogSentAt' and count(parameter)=0]"
			[Register ("getAppLaunchLogSentAt", "()J", "GetGetAppLaunchLogSentAtHandler")]
			get {
				if (id_getAppLaunchLogSentAt == IntPtr.Zero)
					id_getAppLaunchLogSentAt = JNIEnv.GetMethodID (class_ref, "getAppLaunchLogSentAt", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAppLaunchLogSentAt);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppLaunchLogSentAt", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setAppLaunchLogSentAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAppLaunchLogSentAt", "(J)V", "GetSetAppLaunchLogSentAt_JHandler")]
			set {
				if (id_setAppLaunchLogSentAt_J == IntPtr.Zero)
					id_setAppLaunchLogSentAt_J = JNIEnv.GetMethodID (class_ref, "setAppLaunchLogSentAt", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAppLaunchLogSentAt_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppLaunchLogSentAt", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_hasAppLaunchLogSentToday;
#pragma warning disable 0169
		static Delegate GetHasAppLaunchLogSentTodayHandler ()
		{
			if (cb_hasAppLaunchLogSentToday == null)
				cb_hasAppLaunchLogSentToday = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAppLaunchLogSentToday);
			return cb_hasAppLaunchLogSentToday;
		}

		static bool n_HasAppLaunchLogSentToday (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAppLaunchLogSentToday;
		}
#pragma warning restore 0169

		static IntPtr id_hasAppLaunchLogSentToday;
		public virtual bool HasAppLaunchLogSentToday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='hasAppLaunchLogSentToday' and count(parameter)=0]"
			[Register ("hasAppLaunchLogSentToday", "()Z", "GetHasAppLaunchLogSentTodayHandler")]
			get {
				if (id_hasAppLaunchLogSentToday == IntPtr.Zero)
					id_hasAppLaunchLogSentToday = JNIEnv.GetMethodID (class_ref, "hasAppLaunchLogSentToday", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasAppLaunchLogSentToday);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAppLaunchLogSentToday", "()Z"));
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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MergeNotificaiton = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMergeNotificaiton;
		static IntPtr id_setMergeNotificaiton_Z;
		public virtual bool MergeNotificaiton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getMergeNotificaiton' and count(parameter)=0]"
			[Register ("getMergeNotificaiton", "()Z", "GetGetMergeNotificaitonHandler")]
			get {
				if (id_getMergeNotificaiton == IntPtr.Zero)
					id_getMergeNotificaiton = JNIEnv.GetMethodID (class_ref, "getMergeNotificaiton", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getMergeNotificaiton);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMergeNotificaiton", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setMergeNotificaiton' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getMessageAppKey;
#pragma warning disable 0169
		static Delegate GetGetMessageAppKeyHandler ()
		{
			if (cb_getMessageAppKey == null)
				cb_getMessageAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageAppKey);
			return cb_getMessageAppKey;
		}

		static IntPtr n_GetMessageAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageAppKey);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageAppKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageAppKey_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageAppKey_Ljava_lang_String_ == null)
				cb_setMessageAppKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageAppKey_Ljava_lang_String_);
			return cb_setMessageAppKey_Ljava_lang_String_;
		}

		static void n_SetMessageAppKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageAppKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageAppKey;
		static IntPtr id_setMessageAppKey_Ljava_lang_String_;
		public virtual string MessageAppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getMessageAppKey' and count(parameter)=0]"
			[Register ("getMessageAppKey", "()Ljava/lang/String;", "GetGetMessageAppKeyHandler")]
			get {
				if (id_getMessageAppKey == IntPtr.Zero)
					id_getMessageAppKey = JNIEnv.GetMethodID (class_ref, "getMessageAppKey", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageAppKey), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageAppKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setMessageAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageAppKey", "(Ljava/lang/String;)V", "GetSetMessageAppKey_Ljava_lang_String_Handler")]
			set {
				if (id_setMessageAppKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageAppKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMessageAppKey_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageAppKey", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getMessageAppSecret;
#pragma warning disable 0169
		static Delegate GetGetMessageAppSecretHandler ()
		{
			if (cb_getMessageAppSecret == null)
				cb_getMessageAppSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageAppSecret);
			return cb_getMessageAppSecret;
		}

		static IntPtr n_GetMessageAppSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageAppSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageAppSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageAppSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageAppSecret_Ljava_lang_String_ == null)
				cb_setMessageAppSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageAppSecret_Ljava_lang_String_);
			return cb_setMessageAppSecret_Ljava_lang_String_;
		}

		static void n_SetMessageAppSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageAppSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageAppSecret;
		static IntPtr id_setMessageAppSecret_Ljava_lang_String_;
		public virtual string MessageAppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getMessageAppSecret' and count(parameter)=0]"
			[Register ("getMessageAppSecret", "()Ljava/lang/String;", "GetGetMessageAppSecretHandler")]
			get {
				if (id_getMessageAppSecret == IntPtr.Zero)
					id_getMessageAppSecret = JNIEnv.GetMethodID (class_ref, "getMessageAppSecret", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageAppSecret), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageAppSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setMessageAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageAppSecret", "(Ljava/lang/String;)V", "GetSetMessageAppSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setMessageAppSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageAppSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMessageAppSecret_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageAppSecret", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageChannel = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageChannel;
		static IntPtr id_setMessageChannel_Ljava_lang_String_;
		public virtual string MessageChannel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getMessageChannel' and count(parameter)=0]"
			[Register ("getMessageChannel", "()Ljava/lang/String;", "GetGetMessageChannelHandler")]
			get {
				if (id_getMessageChannel == IntPtr.Zero)
					id_getMessageChannel = JNIEnv.GetMethodID (class_ref, "getMessageChannel", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageChannel), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageChannel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setMessageChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNotificaitonOnForeground;
#pragma warning disable 0169
		static Delegate GetGetNotificaitonOnForegroundHandler ()
		{
			if (cb_getNotificaitonOnForeground == null)
				cb_getNotificaitonOnForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNotificaitonOnForeground);
			return cb_getNotificaitonOnForeground;
		}

		static bool n_GetNotificaitonOnForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificaitonOnForeground;
		}
#pragma warning restore 0169

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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificaitonOnForeground = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificaitonOnForeground;
		static IntPtr id_setNotificaitonOnForeground_Z;
		public virtual bool NotificaitonOnForeground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getNotificaitonOnForeground' and count(parameter)=0]"
			[Register ("getNotificaitonOnForeground", "()Z", "GetGetNotificaitonOnForegroundHandler")]
			get {
				if (id_getNotificaitonOnForeground == IntPtr.Zero)
					id_getNotificaitonOnForeground = JNIEnv.GetMethodID (class_ref, "getNotificaitonOnForeground", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getNotificaitonOnForeground);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificaitonOnForeground", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setNotificaitonOnForeground' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNotificaitonOnForeground", "(Z)V", "GetSetNotificaitonOnForeground_ZHandler")]
			set {
				if (id_setNotificaitonOnForeground_Z == IntPtr.Zero)
					id_setNotificaitonOnForeground_Z = JNIEnv.GetMethodID (class_ref, "setNotificaitonOnForeground", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNotificaitonOnForeground_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificaitonOnForeground", "(Z)V"), new JValue (value));
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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PushIntentServiceClass);
		}
#pragma warning restore 0169

		static IntPtr id_getPushIntentServiceClass;
		public virtual string PushIntentServiceClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getPushIntentServiceClass' and count(parameter)=0]"
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

		static Delegate cb_getSerialNo;
#pragma warning disable 0169
		static Delegate GetGetSerialNoHandler ()
		{
			if (cb_getSerialNo == null)
				cb_getSerialNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSerialNo);
			return cb_getSerialNo;
		}

		static int n_GetSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SerialNo;
		}
#pragma warning restore 0169

		static Delegate cb_setSerialNo_I;
#pragma warning disable 0169
		static Delegate GetSetSerialNo_IHandler ()
		{
			if (cb_setSerialNo_I == null)
				cb_setSerialNo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSerialNo_I);
			return cb_setSerialNo_I;
		}

		static void n_SetSerialNo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SerialNo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSerialNo;
		static IntPtr id_setSerialNo_I;
		public virtual int SerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getSerialNo' and count(parameter)=0]"
			[Register ("getSerialNo", "()I", "GetGetSerialNoHandler")]
			get {
				if (id_getSerialNo == IntPtr.Zero)
					id_getSerialNo = JNIEnv.GetMethodID (class_ref, "getSerialNo", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSerialNo);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialNo", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setSerialNo' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSerialNo", "(I)V", "GetSetSerialNo_IHandler")]
			set {
				if (id_setSerialNo_I == IntPtr.Zero)
					id_setSerialNo_I = JNIEnv.GetMethodID (class_ref, "setSerialNo", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSerialNo_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSerialNo", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getTagCount;
#pragma warning disable 0169
		static Delegate GetGetTagCountHandler ()
		{
			if (cb_getTagCount == null)
				cb_getTagCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTagCount);
			return cb_getTagCount;
		}

		static int n_GetTagCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TagCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTagCount;
		public virtual int TagCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getTagCount' and count(parameter)=0]"
			[Register ("getTagCount", "()I", "GetGetTagCountHandler")]
			get {
				if (id_getTagCount == IntPtr.Zero)
					id_getTagCount = JNIEnv.GetMethodID (class_ref, "getTagCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTagCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTagCount", "()I"));
			}
		}

		static Delegate cb_getTagRemain;
#pragma warning disable 0169
		static Delegate GetGetTagRemainHandler ()
		{
			if (cb_getTagRemain == null)
				cb_getTagRemain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTagRemain);
			return cb_getTagRemain;
		}

		static int n_GetTagRemain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TagRemain;
		}
#pragma warning restore 0169

		static Delegate cb_setTagRemain_I;
#pragma warning disable 0169
		static Delegate GetSetTagRemain_IHandler ()
		{
			if (cb_setTagRemain_I == null)
				cb_setTagRemain_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTagRemain_I);
			return cb_setTagRemain_I;
		}

		static void n_SetTagRemain_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TagRemain = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTagRemain;
		static IntPtr id_setTagRemain_I;
		public virtual int TagRemain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getTagRemain' and count(parameter)=0]"
			[Register ("getTagRemain", "()I", "GetGetTagRemainHandler")]
			get {
				if (id_getTagRemain == IntPtr.Zero)
					id_getTagRemain = JNIEnv.GetMethodID (class_ref, "getTagRemain", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTagRemain);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTagRemain", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setTagRemain' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTagRemain", "(I)V", "GetSetTagRemain_IHandler")]
			set {
				if (id_setTagRemain_I == IntPtr.Zero)
					id_setTagRemain_I = JNIEnv.GetMethodID (class_ref, "setTagRemain", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTagRemain_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTagRemain", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getTagSendPolicy;
#pragma warning disable 0169
		static Delegate GetGetTagSendPolicyHandler ()
		{
			if (cb_getTagSendPolicy == null)
				cb_getTagSendPolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTagSendPolicy);
			return cb_getTagSendPolicy;
		}

		static int n_GetTagSendPolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TagSendPolicy;
		}
#pragma warning restore 0169

		static Delegate cb_setTagSendPolicy_I;
#pragma warning disable 0169
		static Delegate GetSetTagSendPolicy_IHandler ()
		{
			if (cb_setTagSendPolicy_I == null)
				cb_setTagSendPolicy_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTagSendPolicy_I);
			return cb_setTagSendPolicy_I;
		}

		static void n_SetTagSendPolicy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TagSendPolicy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTagSendPolicy;
		static IntPtr id_setTagSendPolicy_I;
		public virtual int TagSendPolicy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getTagSendPolicy' and count(parameter)=0]"
			[Register ("getTagSendPolicy", "()I", "GetGetTagSendPolicyHandler")]
			get {
				if (id_getTagSendPolicy == IntPtr.Zero)
					id_getTagSendPolicy = JNIEnv.GetMethodID (class_ref, "getTagSendPolicy", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTagSendPolicy);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTagSendPolicy", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setTagSendPolicy' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTagSendPolicy", "(I)V", "GetSetTagSendPolicy_IHandler")]
			set {
				if (id_setTagSendPolicy_I == IntPtr.Zero)
					id_setTagSendPolicy_I = JNIEnv.GetMethodID (class_ref, "setTagSendPolicy", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTagSendPolicy_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTagSendPolicy", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_addAlias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addAlias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addAlias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAlias_Ljava_lang_String_Ljava_lang_String_);
			return cb_addAlias_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddAlias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddAlias (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addAlias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='addAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAlias", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void AddAlias (string p0, string p1)
		{
			if (id_addAlias_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addAlias_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAlias", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAlias_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAlias", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addTags_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTags_arrayLjava_lang_String_Handler ()
		{
			if (cb_addTags_arrayLjava_lang_String_ == null)
				cb_addTags_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTags_arrayLjava_lang_String_);
			return cb_addTags_arrayLjava_lang_String_;
		}

		static void n_AddTags_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.AddTags (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addTags_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='addTags' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("addTags", "([Ljava/lang/String;)V", "GetAddTags_arrayLjava_lang_String_Handler")]
		public virtual void AddTags (params  string[] p0)
		{
			if (id_addTags_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addTags_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTags", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addTags_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTags", "([Ljava/lang/String;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MessageSharedPrefs;", "")]
		public static global::Com.Umeng.Message.MessageSharedPrefs GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/message/MessageSharedPrefs;");
			global::Com.Umeng.Message.MessageSharedPrefs __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getLastAlias_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLastAlias_Ljava_lang_String_Handler ()
		{
			if (cb_getLastAlias_Ljava_lang_String_ == null)
				cb_getLastAlias_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLastAlias_Ljava_lang_String_);
			return cb_getLastAlias_Ljava_lang_String_;
		}

		static IntPtr n_GetLastAlias_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLastAlias (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLastAlias_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='getLastAlias' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastAlias", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetLastAlias_Ljava_lang_String_Handler")]
		public virtual string GetLastAlias (string p0)
		{
			if (id_getLastAlias_Ljava_lang_String_ == IntPtr.Zero)
				id_getLastAlias_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLastAlias", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLastAlias_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastAlias", "(Ljava/lang/String;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isAliasSet_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsAliasSet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isAliasSet_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isAliasSet_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsAliasSet_Ljava_lang_String_Ljava_lang_String_);
			return cb_isAliasSet_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsAliasSet_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAliasSet (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAliasSet_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='isAliasSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isAliasSet", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsAliasSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual bool IsAliasSet (string p0, string p1)
		{
			if (id_isAliasSet_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isAliasSet_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isAliasSet", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isAliasSet_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAliasSet", "(Ljava/lang/String;Ljava/lang/String;)Z"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_isAliaseTypeSet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsAliaseTypeSet_Ljava_lang_String_Handler ()
		{
			if (cb_isAliaseTypeSet_Ljava_lang_String_ == null)
				cb_isAliaseTypeSet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAliaseTypeSet_Ljava_lang_String_);
			return cb_isAliaseTypeSet_Ljava_lang_String_;
		}

		static bool n_IsAliaseTypeSet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAliaseTypeSet (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAliaseTypeSet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='isAliaseTypeSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAliaseTypeSet", "(Ljava/lang/String;)Z", "GetIsAliaseTypeSet_Ljava_lang_String_Handler")]
		public virtual bool IsAliaseTypeSet (string p0)
		{
			if (id_isAliaseTypeSet_Ljava_lang_String_ == IntPtr.Zero)
				id_isAliaseTypeSet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isAliaseTypeSet", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isAliaseTypeSet_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAliaseTypeSet", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isTagSet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsTagSet_Ljava_lang_String_Handler ()
		{
			if (cb_isTagSet_Ljava_lang_String_ == null)
				cb_isTagSet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsTagSet_Ljava_lang_String_);
			return cb_isTagSet_Ljava_lang_String_;
		}

		static bool n_IsTagSet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTagSet (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isTagSet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='isTagSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isTagSet", "(Ljava/lang/String;)Z", "GetIsTagSet_Ljava_lang_String_Handler")]
		public virtual bool IsTagSet (string p0)
		{
			if (id_isTagSet_Ljava_lang_String_ == IntPtr.Zero)
				id_isTagSet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isTagSet", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_isTagSet_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTagSet", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeAlias_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAlias_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeAlias_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeAlias_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAlias_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeAlias_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveAlias_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAlias (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeAlias_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='removeAlias' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeAlias", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveAlias_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual void RemoveAlias (string p0, string p1)
		{
			if (id_removeAlias_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAlias_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAlias", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAlias_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAlias", "(Ljava/lang/String;Ljava/lang/String;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_removeTags_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveTags_arrayLjava_lang_String_Handler ()
		{
			if (cb_removeTags_arrayLjava_lang_String_ == null)
				cb_removeTags_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTags_arrayLjava_lang_String_);
			return cb_removeTags_arrayLjava_lang_String_;
		}

		static void n_RemoveTags_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RemoveTags (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeTags_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='removeTags' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("removeTags", "([Ljava/lang/String;)V", "GetRemoveTags_arrayLjava_lang_String_Handler")]
		public virtual void RemoveTags (params  string[] p0)
		{
			if (id_removeTags_arrayLjava_lang_String_ == IntPtr.Zero)
				id_removeTags_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeTags", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeTags_arrayLjava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeTags", "([Ljava/lang/String;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_resetTags;
#pragma warning disable 0169
		static Delegate GetResetTagsHandler ()
		{
			if (cb_resetTags == null)
				cb_resetTags = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetTags);
			return cb_resetTags;
		}

		static void n_ResetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetTags ();
		}
#pragma warning restore 0169

		static IntPtr id_resetTags;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='resetTags' and count(parameter)=0]"
		[Register ("resetTags", "()V", "GetResetTagsHandler")]
		public virtual void ResetTags ()
		{
			if (id_resetTags == IntPtr.Zero)
				id_resetTags = JNIEnv.GetMethodID (class_ref, "resetTags", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resetTags);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetTags", "()V"));
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
			global::Com.Umeng.Message.MessageSharedPrefs __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.MessageSharedPrefs> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPushIntentServiceClass (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPushIntentServiceClass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='MessageSharedPrefs']/method[@name='setPushIntentServiceClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
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
