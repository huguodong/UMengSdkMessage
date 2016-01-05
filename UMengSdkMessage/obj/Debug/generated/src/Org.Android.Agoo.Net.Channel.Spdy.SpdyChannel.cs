using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']"
	[global::Android.Runtime.Register ("org/android/agoo/net/channel/spdy/SpdyChannel", DoNotGenerateAcw=true)]
	public partial class SpdyChannel : global::Java.Lang.Object, global::Org.Android.Agoo.Net.Channel.IDataChannel, global::Org.Android.Spdy.ISpdycb {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='a']"
		[Register ("a")]
		protected global::Org.Android.Agoo.Net.Channel.ChannelState A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelState;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Lorg/android/agoo/net/channel/ChannelState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, a_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='b']"
		[Register ("b")]
		public const string B = (string) "agoo_push_errorid";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='c']"
		[Register ("c")]
		public const string C = (string) "agoo_push_path";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='d']"
		[Register ("d")]
		public const string D = (string) "agoo_connect_type";

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='e']"
		[Register ("e")]
		protected global::Android.Content.Context E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, e_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, e_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='f']"
		[Register ("f")]
		protected global::Com.Umeng.Message.Proguard.AT F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Lcom/umeng/message/proguard/aT;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, f_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Lcom/umeng/message/proguard/aT;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, f_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/field[@name='g']"
		[Register ("g")]
		protected global::Com.Umeng.Message.Proguard.AV G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Lcom/umeng/message/proguard/aV;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, g_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AV> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Lcom/umeng/message/proguard/aV;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, g_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/channel/spdy/SpdyChannel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyChannel); }
		}

		protected SpdyChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/constructor[@name='SpdyChannel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SpdyChannel () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SpdyChannel)) {
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

		static IntPtr id_hasCallError;
		public bool HasCallError {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='hasCallError' and count(parameter)=0]"
			[Register ("hasCallError", "()Z", "GetHasCallErrorHandler")]
			get {
				if (id_hasCallError == IntPtr.Zero)
					id_hasCallError = JNIEnv.GetMethodID (class_ref, "hasCallError", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_hasCallError);
			}
		}

		static IntPtr id_asyncDisconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='asyncDisconnect' and count(parameter)=0]"
		[Register ("asyncDisconnect", "()V", "")]
		public void AsyncDisconnect ()
		{
			if (id_asyncDisconnect == IntPtr.Zero)
				id_asyncDisconnect = JNIEnv.GetMethodID (class_ref, "asyncDisconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_asyncDisconnect);
		}

		static IntPtr id_callError_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='callError' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("callError", "(Z)V", "")]
		public void CallError (bool p0)
		{
			if (id_callError_Z == IntPtr.Zero)
				id_callError_Z = JNIEnv.GetMethodID (class_ref, "callError", "(Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_callError_Z, new JValue (p0));
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='connect' and count(parameter)=8 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='long'] and parameter[6][@type='org.android.agoo.net.channel.IPushHandler'] and parameter[7][@type='com.umeng.message.proguard.aT'] and parameter[8][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/Object;Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;JLorg/android/agoo/net/channel/IPushHandler;Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V", "")]
		public void Connect (global::Java.Lang.Object p0, global::Android.Content.Context p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3, long p4, global::Org.Android.Agoo.Net.Channel.IPushHandler p5, global::Com.Umeng.Message.Proguard.AT p6, string p7)
		{
			if (id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ == IntPtr.Zero)
				id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/Object;Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;JLorg/android/agoo/net/channel/IPushHandler;Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			JNIEnv.CallVoidMethod  (Handle, id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (native_p7));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p7);
		}

		static IntPtr id_hasPushSteam_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='hasPushSteam' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasPushSteam", "(Ljava/lang/String;)Z", "")]
		public bool HasPushSteam (string p0)
		{
			if (id_hasPushSteam_Ljava_lang_String_ == IntPtr.Zero)
				id_hasPushSteam_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasPushSteam", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_hasPushSteam_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_ping;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()J", "")]
		public long Ping ()
		{
			if (id_ping == IntPtr.Zero)
				id_ping = JNIEnv.GetMethodID (class_ref, "ping", "()J");
			return JNIEnv.CallLongMethod  (Handle, id_ping);
		}

		static IntPtr id_readyChannelState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='readyChannelState' and count(parameter)=0]"
		[Register ("readyChannelState", "()Lorg/android/agoo/net/channel/ChannelState;", "")]
		public global::Org.Android.Agoo.Net.Channel.ChannelState ReadyChannelState ()
		{
			if (id_readyChannelState == IntPtr.Zero)
				id_readyChannelState = JNIEnv.GetMethodID (class_ref, "readyChannelState", "()Lorg/android/agoo/net/channel/ChannelState;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelState> (JNIEnv.CallObjectMethod  (Handle, id_readyChannelState), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='send' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='org.android.agoo.net.channel.IPullHandler'] and parameter[4][@type='com.umeng.message.proguard.aV']]"
		[Register ("send", "(Ljava/lang/String;[BLorg/android/agoo/net/channel/IPullHandler;Lcom/umeng/message/proguard/aV;)I", "")]
		public int Send (string p0, byte[] p1, global::Org.Android.Agoo.Net.Channel.IPullHandler p2, global::Com.Umeng.Message.Proguard.AV p3)
		{
			if (id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ == IntPtr.Zero)
				id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;[BLorg/android/agoo/net/channel/IPullHandler;Lcom/umeng/message/proguard/aV;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_shutdown);
		}

		static IntPtr id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='spdyDataChunkRecvCB' and count(parameter)=6 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.Object']]"
		[Register ("spdyDataChunkRecvCB", "(Lorg/android/spdy/SpdySession;ZJ[BILjava/lang/Object;)V", "")]
		public void SpdyDataChunkRecvCB (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, byte[] p3, int p4, global::Java.Lang.Object p5)
		{
			if (id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ == IntPtr.Zero)
				id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyDataChunkRecvCB", "(Lorg/android/spdy/SpdySession;ZJ[BILjava/lang/Object;)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod  (Handle, id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (p5));
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='spdyDataRecvCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object']]"
		[Register ("spdyDataRecvCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V", "")]
		public void SpdyDataRecvCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, global::Java.Lang.Object p4)
		{
			if (id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ == IntPtr.Zero)
				id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyDataRecvCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='spdyDataSendCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object']]"
		[Register ("spdyDataSendCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V", "")]
		public void SpdyDataSendCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, global::Java.Lang.Object p4)
		{
			if (id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ == IntPtr.Zero)
				id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyDataSendCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='spdyOnStreamResponse' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.lang.Object']]"
		[Register ("spdyOnStreamResponse", "(Lorg/android/spdy/SpdySession;JLjava/util/Map;Ljava/lang/Object;)V", "")]
		public void SpdyOnStreamResponse (global::Org.Android.Spdy.SpdySession p0, long p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2, global::Java.Lang.Object p3)
		{
			if (id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ == IntPtr.Zero)
				id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyOnStreamResponse", "(Lorg/android/spdy/SpdySession;JLjava/util/Map;Ljava/lang/Object;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod  (Handle, id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='spdyRequestRecvCallback' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdyRequestRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V", "")]
		public void SpdyRequestRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2)
		{
			if (id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == IntPtr.Zero)
				id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyRequestRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_;
#pragma warning disable 0169
		static Delegate GetSpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_Handler ()
		{
			if (cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ == null)
				cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int, IntPtr, IntPtr>) n_SpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_);
			return cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_;
		}

		static void n_SpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Android.Agoo.Net.Channel.Spdy.SpdyChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.Spdy.SpdyChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseData p4 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseData> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SpdyStreamCloseCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='spdyStreamCloseCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='org.android.spdy.SuperviseData']]"
		[Register ("spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JILjava/lang/Object;Lorg/android/spdy/SuperviseData;)V", "GetSpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_Handler")]
		public virtual void SpdyStreamCloseCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2, global::Java.Lang.Object p3, global::Org.Android.Spdy.SuperviseData p4)
		{
			if (id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ == IntPtr.Zero)
				id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ = JNIEnv.GetMethodID (class_ref, "spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JILjava/lang/Object;Lorg/android/spdy/SuperviseData;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JILjava/lang/Object;Lorg/android/spdy/SuperviseData;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_syncDisconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel.spdy']/class[@name='SpdyChannel']/method[@name='syncDisconnect' and count(parameter)=0]"
		[Register ("syncDisconnect", "()V", "")]
		public void SyncDisconnect ()
		{
			if (id_syncDisconnect == IntPtr.Zero)
				id_syncDisconnect = JNIEnv.GetMethodID (class_ref, "syncDisconnect", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_syncDisconnect);
		}

	}
}
