using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']"
	[global::Android.Runtime.Register ("com/umeng/message/MsgConstant", DoNotGenerateAcw=true)]
	public partial class MsgConstant : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='ACTION_TYPE_MSG_ARRIVAL']"
		[Register ("ACTION_TYPE_MSG_ARRIVAL")]
		public const int ActionTypeMsgArrival = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='ACTION_TYPE_MSG_CLICK']"
		[Register ("ACTION_TYPE_MSG_CLICK")]
		public const int ActionTypeMsgClick = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='ACTION_TYPE_MSG_DISMISS']"
		[Register ("ACTION_TYPE_MSG_DISMISS")]
		public const int ActionTypeMsgDismiss = (int) 2;

		static IntPtr ALIAS_ENDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='ALIAS_ENDPOINT']"
		[Register ("ALIAS_ENDPOINT")]
		public static string AliasEndpoint {
			get {
				if (ALIAS_ENDPOINT_jfieldId == IntPtr.Zero)
					ALIAS_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIAS_ENDPOINT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALIAS_ENDPOINT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALIAS_ENDPOINT_jfieldId == IntPtr.Zero)
					ALIAS_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIAS_ENDPOINT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, ALIAS_ENDPOINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='APP_LAUNCH_BY_MESSAGE']"
		[Register ("APP_LAUNCH_BY_MESSAGE")]
		public const int AppLaunchByMessage = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='APP_LAUNCH_BY_UNSET']"
		[Register ("APP_LAUNCH_BY_UNSET")]
		public const int AppLaunchByUnset = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='APP_LAUNCH_BY_USER']"
		[Register ("APP_LAUNCH_BY_USER")]
		public const int AppLaunchByUser = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='CACHE_LOG_COUNT_MAX']"
		[Register ("CACHE_LOG_COUNT_MAX")]
		public const int CacheLogCountMax = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='CACHE_LOG_FILE_EXT']"
		[Register ("CACHE_LOG_FILE_EXT")]
		public const string CacheLogFileExt = (string) ".log";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='CACHE_LOG_FILE_PREFIX']"
		[Register ("CACHE_LOG_FILE_PREFIX")]
		public const string CacheLogFilePrefix = (string) "umeng_message_log_cache_";

		static IntPtr DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='DEFAULT_INTENT_SERVICE_CLASS_NAME']"
		[Register ("DEFAULT_INTENT_SERVICE_CLASS_NAME")]
		public static string DefaultIntentServiceClassName {
			get {
				if (DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId == IntPtr.Zero)
					DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_INTENT_SERVICE_CLASS_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId == IntPtr.Zero)
					DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_INTENT_SERVICE_CLASS_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_INTENT_SERVICE_CLASS_NAME_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DELETE_ALIAS_ENDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='DELETE_ALIAS_ENDPOINT']"
		[Register ("DELETE_ALIAS_ENDPOINT")]
		public static string DeleteAliasEndpoint {
			get {
				if (DELETE_ALIAS_ENDPOINT_jfieldId == IntPtr.Zero)
					DELETE_ALIAS_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE_ALIAS_ENDPOINT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_ALIAS_ENDPOINT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DELETE_ALIAS_ENDPOINT_jfieldId == IntPtr.Zero)
					DELETE_ALIAS_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE_ALIAS_ENDPOINT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, DELETE_ALIAS_ENDPOINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_ACTION_TYPE']"
		[Register ("KEY_ACTION_TYPE")]
		public const string KeyActionType = (string) "action_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_ALIAS']"
		[Register ("KEY_ALIAS")]
		public const string KeyAlias = (string) "alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_APP_LAUNCH_LOG_SEND_POLICY']"
		[Register ("KEY_APP_LAUNCH_LOG_SEND_POLICY")]
		public const string KeyAppLaunchLogSendPolicy = (string) "KEY_APP_LAUNCH_LOG_SEND_POLICY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_CACHE_FILE_TRANSFER_TO_SQL']"
		[Register ("KEY_CACHE_FILE_TRANSFER_TO_SQL")]
		public const string KeyCacheFileTransferToSql = (string) "KEY_CACHE_FILE_TRANSFER_TO_SQL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_DEVICE_TOKEN']"
		[Register ("KEY_DEVICE_TOKEN")]
		public const string KeyDeviceToken = (string) "device_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_ENEABLED']"
		[Register ("KEY_ENEABLED")]
		public const string KeyEneabled = (string) "KEY_ENEABLED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_HEADER']"
		[Register ("KEY_HEADER")]
		public const string KeyHeader = (string) "header";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_LAST_ALIAS']"
		[Register ("KEY_LAST_ALIAS")]
		public const string KeyLastAlias = (string) "last_alias";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_LAST_MSG_ID']"
		[Register ("KEY_LAST_MSG_ID")]
		public const string KeyLastMsgId = (string) "last_msg_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_LAUNCH_LOG_SENT_MARK']"
		[Register ("KEY_LAUNCH_LOG_SENT_MARK")]
		public const string KeyLaunchLogSentMark = (string) "KEY_LAUNCH_LOG_SENT_MARK";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_MERGE_NOTIFICATION']"
		[Register ("KEY_MERGE_NOTIFICATION")]
		public const string KeyMergeNotification = (string) "KEY_MERGE_NOTIFICATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_MSG_ID']"
		[Register ("KEY_MSG_ID")]
		public const string KeyMsgId = (string) "msg_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_MSG_RESOURCE_DOWNLOAD_PREFIX']"
		[Register ("KEY_MSG_RESOURCE_DOWNLOAD_PREFIX")]
		public const string KeyMsgResourceDownloadPrefix = (string) "KEY_MSG_RESOURCE_DOWNLOAD_PREFIX";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_MUTE_DURATION']"
		[Register ("KEY_MUTE_DURATION")]
		public const string KeyMuteDuration = (string) "mute_duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_NO_DISTURB_END_HOUR']"
		[Register ("KEY_NO_DISTURB_END_HOUR")]
		public const string KeyNoDisturbEndHour = (string) "KEY_NO_DISTURB_END_HOUR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_NO_DISTURB_END_MINUTE']"
		[Register ("KEY_NO_DISTURB_END_MINUTE")]
		public const string KeyNoDisturbEndMinute = (string) "KEY_NO_DISTURB_END_MINUTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_NO_DISTURB_START_HOUR']"
		[Register ("KEY_NO_DISTURB_START_HOUR")]
		public const string KeyNoDisturbStartHour = (string) "KEY_NO_DISTURB_START_HOUR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_NO_DISTURB_START_MINUTE']"
		[Register ("KEY_NO_DISTURB_START_MINUTE")]
		public const string KeyNoDisturbStartMinute = (string) "KEY_NO_DISTURB_START_MINUTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_PUSH_INTENT_SERVICE_CLASSNAME']"
		[Register ("KEY_PUSH_INTENT_SERVICE_CLASSNAME")]
		public const string KeyPushIntentServiceClassname = (string) "KEY_PUSH_INTENT_SERVICE_CLASSNAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_REGISTERED_TO_UMENG']"
		[Register ("KEY_REGISTERED_TO_UMENG")]
		public const string KeyRegisteredToUmeng = (string) "KEY_REGISTERED_TO_UMENG_";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_SERIA_NO']"
		[Register ("KEY_SERIA_NO")]
		public const string KeySeriaNo = (string) "serial_no";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_SET_NOTIFICATION_ON_FOREGROUND']"
		[Register ("KEY_SET_NOTIFICATION_ON_FOREGROUND")]
		public const string KeySetNotificationOnForeground = (string) "KEY_SET_NOTIFICATION_ON_FOREGROUND";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_SET_PUSH_INTENT_SERVICE_VERSION_CODE']"
		[Register ("KEY_SET_PUSH_INTENT_SERVICE_VERSION_CODE")]
		public const string KeySetPushIntentServiceVersionCode = (string) "KEY_SET_PUSH_INTENT_SERVICE_VERSION_CODE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_TAGS']"
		[Register ("KEY_TAGS")]
		public const string KeyTags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_TAG_SEND_POLICY']"
		[Register ("KEY_TAG_SEND_POLICY")]
		public const string KeyTagSendPolicy = (string) "KEY_TAG_SEND_POLICY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_TS']"
		[Register ("KEY_TS")]
		public const string KeyTs = (string) "ts";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_TYPE']"
		[Register ("KEY_TYPE")]
		public const string KeyType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_UMENG_MESSAGE_APP_CHANNEL']"
		[Register ("KEY_UMENG_MESSAGE_APP_CHANNEL")]
		public const string KeyUmengMessageAppChannel = (string) "KEY_UMENG_MESSAGE_APP_CHANNEL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_UMENG_MESSAGE_APP_KEY']"
		[Register ("KEY_UMENG_MESSAGE_APP_KEY")]
		public const string KeyUmengMessageAppKey = (string) "KEY_UMENG_MESSAGE_APP_KEY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_UMENG_MESSAGE_APP_SECRET']"
		[Register ("KEY_UMENG_MESSAGE_APP_SECRET")]
		public const string KeyUmengMessageAppSecret = (string) "KEY_UMENG_MESSAGE_APP_SECRET";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='KEY_UTDID']"
		[Register ("KEY_UTDID")]
		public const string KeyUtdid = (string) "utdid";

		static IntPtr LAUNCH_ENDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='LAUNCH_ENDPOINT']"
		[Register ("LAUNCH_ENDPOINT")]
		public static string LaunchEndpoint {
			get {
				if (LAUNCH_ENDPOINT_jfieldId == IntPtr.Zero)
					LAUNCH_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAUNCH_ENDPOINT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAUNCH_ENDPOINT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LAUNCH_ENDPOINT_jfieldId == IntPtr.Zero)
					LAUNCH_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAUNCH_ENDPOINT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, LAUNCH_ENDPOINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr LOG_ENDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='LOG_ENDPOINT']"
		[Register ("LOG_ENDPOINT")]
		public static string LogEndpoint {
			get {
				if (LOG_ENDPOINT_jfieldId == IntPtr.Zero)
					LOG_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_ENDPOINT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_ENDPOINT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LOG_ENDPOINT_jfieldId == IntPtr.Zero)
					LOG_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG_ENDPOINT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, LOG_ENDPOINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='PROTOCOL_VERSION']"
		[Register ("PROTOCOL_VERSION")]
		public const string ProtocolVersion = (string) "1.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='PUSH_SHARED_PREFERENCES_FILE_NAME']"
		[Register ("PUSH_SHARED_PREFERENCES_FILE_NAME")]
		public const string PushSharedPreferencesFileName = (string) "umeng_message_state";

		static IntPtr REGISTER_ENDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='REGISTER_ENDPOINT']"
		[Register ("REGISTER_ENDPOINT")]
		public static string RegisterEndpoint {
			get {
				if (REGISTER_ENDPOINT_jfieldId == IntPtr.Zero)
					REGISTER_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER_ENDPOINT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTER_ENDPOINT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (REGISTER_ENDPOINT_jfieldId == IntPtr.Zero)
					REGISTER_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER_ENDPOINT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, REGISTER_ENDPOINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "2.2.0";

		static IntPtr TAG_ENDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='TAG_ENDPOINT']"
		[Register ("TAG_ENDPOINT")]
		public static string TagEndpoint {
			get {
				if (TAG_ENDPOINT_jfieldId == IntPtr.Zero)
					TAG_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG_ENDPOINT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_ENDPOINT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_ENDPOINT_jfieldId == IntPtr.Zero)
					TAG_ENDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG_ENDPOINT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetStaticField (class_ref, TAG_ENDPOINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/field[@name='d']"
		[Register ("d")]
		protected const string D = (string) "TD";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/MsgConstant", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MsgConstant); }
		}

		protected MsgConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='MsgConstant']/constructor[@name='MsgConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MsgConstant () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MsgConstant)) {
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

	}
}
