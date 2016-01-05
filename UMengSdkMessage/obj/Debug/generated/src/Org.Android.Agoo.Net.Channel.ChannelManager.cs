using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']"
	[global::Android.Runtime.Register ("org/android/agoo/net/channel/ChannelManager", DoNotGenerateAcw=true)]
	public partial class ChannelManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/field[@name='a']"
		[Register ("a")]
		public const int A = (int) 307;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/field[@name='b']"
		[Register ("b")]
		public const int B = (int) 401;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/field[@name='c']"
		[Register ("c")]
		public const int C = (int) 403;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/field[@name='d']"
		[Register ("d")]
		public const int D = (int) 404;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/field[@name='e']"
		[Register ("e")]
		public const int E = (int) 408;
		// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']"
		[global::Android.Runtime.Register ("org/android/agoo/net/channel/ChannelManager$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/android/agoo/net/channel/ChannelManager$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/constructor[@name='ChannelManager.Builder' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public Builder (global::Android.Content.Context p0, string p1, string p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				IntPtr native_p2 = JNIEnv.NewString (p2);;
				if (GetType () != typeof (Builder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", new JValue (p0), new JValue (native_p1), new JValue (native_p2));
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder AddHeader (string p0, string p1)
			{
				if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static IntPtr id_addHeaders_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='addHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("addHeaders", "(Ljava/util/Map;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder AddHeaders (global::System.Collections.Generic.IDictionary<string, string> p0)
			{
				if (id_addHeaders_Ljava_util_Map_ == IntPtr.Zero)
					id_addHeaders_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addHeaders", "(Ljava/util/Map;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addHeaders_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_addLastTcpConnectedEndTime_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='addLastTcpConnectedEndTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("addLastTcpConnectedEndTime", "(J)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder AddLastTcpConnectedEndTime (long p0)
			{
				if (id_addLastTcpConnectedEndTime_J == IntPtr.Zero)
					id_addLastTcpConnectedEndTime_J = JNIEnv.GetMethodID (class_ref, "addLastTcpConnectedEndTime", "(J)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addLastTcpConnectedEndTime_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_addLastTcpConnectedSuccessfully_JJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='addLastTcpConnectedSuccessfully' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("addLastTcpConnectedSuccessfully", "(JJ)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder AddLastTcpConnectedSuccessfully (long p0, long p1)
			{
				if (id_addLastTcpConnectedSuccessfully_JJ == IntPtr.Zero)
					id_addLastTcpConnectedSuccessfully_JJ = JNIEnv.GetMethodID (class_ref, "addLastTcpConnectedSuccessfully", "(JJ)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addLastTcpConnectedSuccessfully_JJ, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_addPushHandler_Lorg_android_agoo_net_channel_IPushHandler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='addPushHandler' and count(parameter)=1 and parameter[1][@type='org.android.agoo.net.channel.IPushHandler']]"
			[Register ("addPushHandler", "(Lorg/android/agoo/net/channel/IPushHandler;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder AddPushHandler (global::Org.Android.Agoo.Net.Channel.IPushHandler p0)
			{
				if (id_addPushHandler_Lorg_android_agoo_net_channel_IPushHandler_ == IntPtr.Zero)
					id_addPushHandler_Lorg_android_agoo_net_channel_IPushHandler_ = JNIEnv.GetMethodID (class_ref, "addPushHandler", "(Lorg/android/agoo/net/channel/IPushHandler;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addPushHandler_Lorg_android_agoo_net_channel_IPushHandler_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_addServiceStartTime_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='addServiceStartTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("addServiceStartTime", "(J)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder AddServiceStartTime (long p0)
			{
				if (id_addServiceStartTime_J == IntPtr.Zero)
					id_addServiceStartTime_J = JNIEnv.GetMethodID (class_ref, "addServiceStartTime", "(J)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addServiceStartTime_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lorg/android/agoo/net/channel/ChannelManager;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lorg/android/agoo/net/channel/ChannelManager;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_forceInit;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='forceInit' and count(parameter)=0]"
			[Register ("forceInit", "()Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder ForceInit ()
			{
				if (id_forceInit == IntPtr.Zero)
					id_forceInit = JNIEnv.GetMethodID (class_ref, "forceInit", "()Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_forceInit), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_putParams_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='putParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("putParams", "(Ljava/lang/String;Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder PutParams (string p0, string p1)
			{
				if (id_putParams_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_putParams_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putParams", "(Ljava/lang/String;Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_putParams_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static IntPtr id_putParams_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='putParams' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("putParams", "(Ljava/util/Map;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder PutParams (global::System.Collections.Generic.IDictionary<string, string> p0)
			{
				if (id_putParams_Ljava_util_Map_ == IntPtr.Zero)
					id_putParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "putParams", "(Ljava/util/Map;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_putParams_Ljava_util_Map_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_refreshHost;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='refreshHost' and count(parameter)=0]"
			[Register ("refreshHost", "()Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder RefreshHost ()
			{
				if (id_refreshHost == IntPtr.Zero)
					id_refreshHost = JNIEnv.GetMethodID (class_ref, "refreshHost", "()Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_refreshHost), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_removeHeader_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='removeHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeHeader", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder RemoveHeader (string p0)
			{
				if (id_removeHeader_Ljava_lang_String_ == IntPtr.Zero)
					id_removeHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeHeader", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_removeHeader_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setApi_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setApi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApi", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetApi (string p0)
			{
				if (id_setApi_Ljava_lang_String_ == IntPtr.Zero)
					id_setApi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApi", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setApi_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setAppSecret_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppSecret", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetAppSecret (string p0)
			{
				if (id_setAppSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppSecret", "(Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAppSecret_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setChannel_Lorg_android_agoo_net_channel_ChannelType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='org.android.agoo.net.channel.ChannelType']]"
			[Register ("setChannel", "(Lorg/android/agoo/net/channel/ChannelType;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetChannel (global::Org.Android.Agoo.Net.Channel.ChannelType p0)
			{
				if (id_setChannel_Lorg_android_agoo_net_channel_ChannelType_ == IntPtr.Zero)
					id_setChannel_Lorg_android_agoo_net_channel_ChannelType_ = JNIEnv.GetMethodID (class_ref, "setChannel", "(Lorg/android/agoo/net/channel/ChannelType;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setChannel_Lorg_android_agoo_net_channel_ChannelType_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setDNS_Ljava_lang_String_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setDNS' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
			[Register ("setDNS", "(Ljava/lang/String;J)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetDNS (string p0, long p1)
			{
				if (id_setDNS_Ljava_lang_String_J == IntPtr.Zero)
					id_setDNS_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setDNS", "(Ljava/lang/String;J)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDNS_Ljava_lang_String_J, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setDNSProxy_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setDNSProxy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("setDNSProxy", "(Ljava/lang/String;I)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetDNSProxy (string p0, int p1)
			{
				if (id_setDNSProxy_Ljava_lang_String_I == IntPtr.Zero)
					id_setDNSProxy_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setDNSProxy", "(Ljava/lang/String;I)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDNSProxy_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_setIfNeedMore_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setIfNeedMore' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIfNeedMore", "(Z)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetIfNeedMore (bool p0)
			{
				if (id_setIfNeedMore_Z == IntPtr.Zero)
					id_setIfNeedMore_Z = JNIEnv.GetMethodID (class_ref, "setIfNeedMore", "(Z)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setIfNeedMore_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setRequestInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setRequestInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("setRequestInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetRequestInfo (string p0, string p1, string p2)
			{
				if (id_setRequestInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRequestInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

			static IntPtr id_setTimeout_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimeout", "(J)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetTimeout (long p0)
			{
				if (id_setTimeout_J == IntPtr.Zero)
					id_setTimeout_J = JNIEnv.GetMethodID (class_ref, "setTimeout", "(J)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setTimeout_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

			static IntPtr id_setVote_Lorg_android_agoo_net_channel_VoteResult_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setVote' and count(parameter)=1 and parameter[1][@type='org.android.agoo.net.channel.VoteResult']]"
			[Register ("setVote", "(Lorg/android/agoo/net/channel/VoteResult;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetVote (global::Org.Android.Agoo.Net.Channel.VoteResult p0)
			{
				if (id_setVote_Lorg_android_agoo_net_channel_VoteResult_ == IntPtr.Zero)
					id_setVote_Lorg_android_agoo_net_channel_VoteResult_ = JNIEnv.GetMethodID (class_ref, "setVote", "(Lorg/android/agoo/net/channel/VoteResult;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setVote_Lorg_android_agoo_net_channel_VoteResult_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static IntPtr id_setlastEventType_Lorg_android_agoo_net_channel_AndroidEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager.Builder']/method[@name='setlastEventType' and count(parameter)=1 and parameter[1][@type='org.android.agoo.net.channel.AndroidEvent']]"
			[Register ("setlastEventType", "(Lorg/android/agoo/net/channel/AndroidEvent;)Lorg/android/agoo/net/channel/ChannelManager$Builder;", "")]
			public global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder SetlastEventType (global::Org.Android.Agoo.Net.Channel.AndroidEvent p0)
			{
				if (id_setlastEventType_Lorg_android_agoo_net_channel_AndroidEvent_ == IntPtr.Zero)
					id_setlastEventType_Lorg_android_agoo_net_channel_AndroidEvent_ = JNIEnv.GetMethodID (class_ref, "setlastEventType", "(Lorg/android/agoo/net/channel/AndroidEvent;)Lorg/android/agoo/net/channel/ChannelManager$Builder;");
				global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelManager.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setlastEventType_Lorg_android_agoo_net_channel_AndroidEvent_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/channel/ChannelManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelManager); }
		}

		protected ChannelManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ACK_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='ACK' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("ACK", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public int ACK (string p0, string p1, string p2)
		{
			if (id_ACK_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ACK_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ACK", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_ACK_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_connenct_Lcom_umeng_message_proguard_aT_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='connenct' and count(parameter)=2 and parameter[1][@type='com.umeng.message.proguard.aT'] and parameter[2][@type='java.lang.String']]"
		[Register ("connenct", "(Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V", "")]
		public void Connenct (global::Com.Umeng.Message.Proguard.AT p0, string p1)
		{
			if (id_connenct_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ == IntPtr.Zero)
				id_connenct_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connenct", "(Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_connenct_Lcom_umeng_message_proguard_aT_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "")]
		public void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_disconnect);
		}

		static IntPtr id_hisMessage_Lcom_umeng_message_proguard_aV_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='hisMessage' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.aV']]"
		[Register ("hisMessage", "(Lcom/umeng/message/proguard/aV;)Lcom/umeng/message/proguard/aV;", "")]
		public global::Com.Umeng.Message.Proguard.AV HisMessage (global::Com.Umeng.Message.Proguard.AV p0)
		{
			if (id_hisMessage_Lcom_umeng_message_proguard_aV_ == IntPtr.Zero)
				id_hisMessage_Lcom_umeng_message_proguard_aV_ = JNIEnv.GetMethodID (class_ref, "hisMessage", "(Lcom/umeng/message/proguard/aV;)Lcom/umeng/message/proguard/aV;");
			global::Com.Umeng.Message.Proguard.AV __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AV> (JNIEnv.CallObjectMethod  (Handle, id_hisMessage_Lcom_umeng_message_proguard_aV_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_ping;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()J", "")]
		public long Ping ()
		{
			if (id_ping == IntPtr.Zero)
				id_ping = JNIEnv.GetMethodID (class_ref, "ping", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_ping);
		}

		static IntPtr id_readyChannelState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='readyChannelState' and count(parameter)=0]"
		[Register ("readyChannelState", "()Lorg/android/agoo/net/channel/ChannelState;", "")]
		public global::Org.Android.Agoo.Net.Channel.ChannelState ReadyChannelState ()
		{
			if (id_readyChannelState == IntPtr.Zero)
				id_readyChannelState = JNIEnv.GetMethodID (class_ref, "readyChannelState", "()Lorg/android/agoo/net/channel/ChannelState;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelState> (JNIEnv.CallObjectMethod  (Handle, id_readyChannelState), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_readyChannelType;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='readyChannelType' and count(parameter)=0]"
		[Register ("readyChannelType", "()Lorg/android/agoo/net/channel/ChannelType;", "")]
		public global::Org.Android.Agoo.Net.Channel.ChannelType ReadyChannelType ()
		{
			if (id_readyChannelType == IntPtr.Zero)
				id_readyChannelType = JNIEnv.GetMethodID (class_ref, "readyChannelType", "()Lorg/android/agoo/net/channel/ChannelType;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelType> (JNIEnv.CallObjectMethod  (Handle, id_readyChannelType), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='send' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='org.android.agoo.net.channel.IPullHandler']]"
		[Register ("send", "(Ljava/lang/String;[BLorg/android/agoo/net/channel/IPullHandler;)V", "")]
		public void Send (string p0, byte[] p1, global::Org.Android.Agoo.Net.Channel.IPullHandler p2)
		{
			if (id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_ == IntPtr.Zero)
				id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;[BLorg/android/agoo/net/channel/IPullHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod  (Handle, id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setConnectContext_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='setConnectContext' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setConnectContext", "(Ljava/lang/Object;)V", "")]
		public void SetConnectContext (global::Java.Lang.Object p0)
		{
			if (id_setConnectContext_Ljava_lang_Object_ == IntPtr.Zero)
				id_setConnectContext_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setConnectContext", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setConnectContext_Ljava_lang_Object_, new JValue (p0));
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='ChannelManager']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_shutdown);
		}

	}
}
