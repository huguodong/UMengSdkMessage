using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Intent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']"
	[global::Android.Runtime.Register ("org/android/agoo/intent/IntentUtil", DoNotGenerateAcw=true)]
	public sealed partial class IntentUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND']"
		[Register ("AGOO_COMMAND")]
		public const string AgooCommand = (string) "command";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_BIND_USER']"
		[Register ("AGOO_COMMAND_BIND_USER")]
		public const string AgooCommandBindUser = (string) "command_bind_user";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_BIND_USER_XTOKEN']"
		[Register ("AGOO_COMMAND_BIND_USER_XTOKEN")]
		public const string AgooCommandBindUserXtoken = (string) "command_bind_user_xtoken";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_OTHER_CHANNEL']"
		[Register ("AGOO_COMMAND_OTHER_CHANNEL")]
		public const string AgooCommandOtherChannel = (string) "command_other_channel";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_REGISTRATION_CALLBACK']"
		[Register ("AGOO_COMMAND_REGISTRATION_CALLBACK")]
		public const string AgooCommandRegistrationCallback = (string) "registration";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_RESTART_SUDO']"
		[Register ("AGOO_COMMAND_RESTART_SUDO")]
		public const string AgooCommandRestartSudo = (string) "command_restart_sudo";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_RESTART_SUDO_APP']"
		[Register ("AGOO_COMMAND_RESTART_SUDO_APP")]
		public const string AgooCommandRestartSudoApp = (string) "agoo_command_restart_sudo_app";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_RE_BIND_USER']"
		[Register ("AGOO_COMMAND_RE_BIND_USER")]
		public const string AgooCommandReBindUser = (string) "re_user";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='AGOO_COMMAND_UNBIND_USER']"
		[Register ("AGOO_COMMAND_UNBIND_USER")]
		public const string AgooCommandUnbindUser = (string) "command_unbind_user";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='INTENT_FROM_AGOO_ELECTION_RESULT']"
		[Register ("INTENT_FROM_AGOO_ELECTION_RESULT")]
		public const string IntentFromAgooElectionResult = (string) "org.agoo.android.intent.action.ELECTION_RESULT_V4";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='INTENT_FROM_AGOO_MESSAGE']"
		[Register ("INTENT_FROM_AGOO_MESSAGE")]
		public const string IntentFromAgooMessage = (string) "org.agoo.android.intent.action.RECEIVE";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='INTENT_FROM_AGOO_PING']"
		[Register ("INTENT_FROM_AGOO_PING")]
		public const string IntentFromAgooPing = (string) "org.agoo.android.intent.action.PING_V4";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='INTENT_FROM_AGOO_SEND']"
		[Register ("INTENT_FROM_AGOO_SEND")]
		public const string IntentFromAgooSend = (string) ".intent.action.SEND";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='OTHER_CHANNEL_ANDROID_DEVICE_TOKEN']"
		[Register ("OTHER_CHANNEL_ANDROID_DEVICE_TOKEN")]
		public const string OtherChannelAndroidDeviceToken = (string) "channel_android_device_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/field[@name='OTHER_CHANNEL_ANDROID_DEVICE_TYPE']"
		[Register ("OTHER_CHANNEL_ANDROID_DEVICE_TYPE")]
		public const string OtherChannelAndroidDeviceType = (string) "channel_android_device_type";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/intent/IntentUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntentUtil); }
		}

		internal IntentUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/constructor[@name='IntentUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public IntentUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IntentUtil)) {
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

		static IntPtr id_createComandIntent_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='createComandIntent' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createComandIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent CreateComandIntent (global::Android.Content.Context p0, string p1)
		{
			if (id_createComandIntent_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createComandIntent_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createComandIntent", "(Landroid/content/Context;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createComandIntent_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_getAgooCockroach_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='getAgooCockroach' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAgooCockroach", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAgooCockroach (global::Android.Content.Context p0)
		{
			if (id_getAgooCockroach_Landroid_content_Context_ == IntPtr.Zero)
				id_getAgooCockroach_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAgooCockroach", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAgooCockroach_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAgooCommand_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='getAgooCommand' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAgooCommand", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAgooCommand (global::Android.Content.Context p0)
		{
			if (id_getAgooCommand_Landroid_content_Context_ == IntPtr.Zero)
				id_getAgooCommand_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAgooCommand", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAgooCommand_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAgooSendAction_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='getAgooSendAction' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAgooSendAction", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAgooSendAction (global::Android.Content.Context p0)
		{
			if (id_getAgooSendAction_Landroid_content_Context_ == IntPtr.Zero)
				id_getAgooSendAction_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAgooSendAction", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAgooSendAction_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getAgooStart_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='getAgooStart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAgooStart", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetAgooStart (global::Android.Content.Context p0)
		{
			if (id_getAgooStart_Landroid_content_Context_ == IntPtr.Zero)
				id_getAgooStart_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAgooStart", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAgooStart_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_sendOtherChannel_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='sendOtherChannel' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendOtherChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void SendOtherChannel (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_sendOtherChannel_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOtherChannel_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendOtherChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOtherChannel_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_sendOtherMessage_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.intent']/class[@name='IntentUtil']/method[@name='sendOtherMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendOtherMessage", "(Landroid/content/Context;Landroid/content/Intent;Ljava/lang/String;)V", "")]
		public static void SendOtherMessage (global::Android.Content.Context p0, global::Android.Content.Intent p1, string p2)
		{
			if (id_sendOtherMessage_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOtherMessage_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendOtherMessage", "(Landroid/content/Context;Landroid/content/Intent;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOtherMessage_Landroid_content_Context_Landroid_content_Intent_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}
}
