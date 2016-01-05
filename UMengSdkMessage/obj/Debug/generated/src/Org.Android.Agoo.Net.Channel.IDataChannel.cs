using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']"
	[Register ("org/android/agoo/net/channel/IDataChannel", "", "Org.Android.Agoo.Net.Channel.IDataChannelInvoker")]
	public partial interface IDataChannel : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='asyncDisconnect' and count(parameter)=0]"
		[Register ("asyncDisconnect", "()V", "GetAsyncDisconnectHandler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		void AsyncDisconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='connect' and count(parameter)=8 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='long'] and parameter[6][@type='org.android.agoo.net.channel.IPushHandler'] and parameter[7][@type='com.umeng.message.proguard.aT'] and parameter[8][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/Object;Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;JLorg/android/agoo/net/channel/IPushHandler;Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V", "GetConnect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_Handler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		void Connect (global::Java.Lang.Object p0, global::Android.Content.Context p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3, long p4, global::Org.Android.Agoo.Net.Channel.IPushHandler p5, global::Com.Umeng.Message.Proguard.AT p6, string p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()J", "GetPingHandler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		long Ping ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='readyChannelState' and count(parameter)=0]"
		[Register ("readyChannelState", "()Lorg/android/agoo/net/channel/ChannelState;", "GetReadyChannelStateHandler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		global::Org.Android.Agoo.Net.Channel.ChannelState ReadyChannelState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='send' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='org.android.agoo.net.channel.IPullHandler'] and parameter[4][@type='com.umeng.message.proguard.aV']]"
		[Register ("send", "(Ljava/lang/String;[BLorg/android/agoo/net/channel/IPullHandler;Lcom/umeng/message/proguard/aV;)I", "GetSend_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_Handler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		int Send (string p0, byte[] p1, global::Org.Android.Agoo.Net.Channel.IPullHandler p2, global::Com.Umeng.Message.Proguard.AV p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		void Shutdown ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IDataChannel']/method[@name='syncDisconnect' and count(parameter)=0]"
		[Register ("syncDisconnect", "()V", "GetSyncDisconnectHandler:Org.Android.Agoo.Net.Channel.IDataChannelInvoker, UMengSdkMessage")]
		void SyncDisconnect ();

	}

	[global::Android.Runtime.Register ("org/android/agoo/net/channel/IDataChannel", DoNotGenerateAcw=true)]
	internal class IDataChannelInvoker : global::Java.Lang.Object, IDataChannel {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/net/channel/IDataChannel");
		IntPtr class_ref;

		public static IDataChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.net.channel.IDataChannel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDataChannelInvoker); }
		}

		static Delegate cb_asyncDisconnect;
#pragma warning disable 0169
		static Delegate GetAsyncDisconnectHandler ()
		{
			if (cb_asyncDisconnect == null)
				cb_asyncDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AsyncDisconnect);
			return cb_asyncDisconnect;
		}

		static void n_AsyncDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AsyncDisconnect ();
		}
#pragma warning restore 0169

		IntPtr id_asyncDisconnect;
		public void AsyncDisconnect ()
		{
			if (id_asyncDisconnect == IntPtr.Zero)
				id_asyncDisconnect = JNIEnv.GetMethodID (class_ref, "asyncDisconnect", "()V");
			JNIEnv.CallVoidMethod (Handle, id_asyncDisconnect);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

		static Delegate cb_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_);
			return cb_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_;
		}

		static void n_Connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, long p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Net.Channel.IPushHandler p5 = (global::Org.Android.Agoo.Net.Channel.IPushHandler)global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.AT p6 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		IntPtr id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_;
		public void Connect (global::Java.Lang.Object p0, global::Android.Content.Context p1, string p2, global::System.Collections.Generic.IDictionary<string, string> p3, long p4, global::Org.Android.Agoo.Net.Channel.IPushHandler p5, global::Com.Umeng.Message.Proguard.AT p6, string p7)
		{
			if (id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ == IntPtr.Zero)
				id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/Object;Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;JLorg/android/agoo/net/channel/IPushHandler;Lcom/umeng/message/proguard/aT;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			JNIEnv.CallVoidMethod (Handle, id_connect_Ljava_lang_Object_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_JLorg_android_agoo_net_channel_IPushHandler_Lcom_umeng_message_proguard_aT_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (native_p7));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p7);
		}

		static Delegate cb_ping;
#pragma warning disable 0169
		static Delegate GetPingHandler ()
		{
			if (cb_ping == null)
				cb_ping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Ping);
			return cb_ping;
		}

		static long n_Ping (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ping ();
		}
#pragma warning restore 0169

		IntPtr id_ping;
		public long Ping ()
		{
			if (id_ping == IntPtr.Zero)
				id_ping = JNIEnv.GetMethodID (class_ref, "ping", "()J");
			return JNIEnv.CallLongMethod (Handle, id_ping);
		}

		static Delegate cb_readyChannelState;
#pragma warning disable 0169
		static Delegate GetReadyChannelStateHandler ()
		{
			if (cb_readyChannelState == null)
				cb_readyChannelState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadyChannelState);
			return cb_readyChannelState;
		}

		static IntPtr n_ReadyChannelState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadyChannelState ());
		}
#pragma warning restore 0169

		IntPtr id_readyChannelState;
		public global::Org.Android.Agoo.Net.Channel.ChannelState ReadyChannelState ()
		{
			if (id_readyChannelState == IntPtr.Zero)
				id_readyChannelState = JNIEnv.GetMethodID (class_ref, "readyChannelState", "()Lorg/android/agoo/net/channel/ChannelState;");
			return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelState> (JNIEnv.CallObjectMethod (Handle, id_readyChannelState), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_Handler ()
		{
			if (cb_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ == null)
				cb_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_);
			return cb_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_;
		}

		static int n_Send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Org.Android.Agoo.Net.Channel.IPullHandler p2 = (global::Org.Android.Agoo.Net.Channel.IPullHandler)global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPullHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.AV p3 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AV> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Send (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_;
		public int Send (string p0, byte[] p1, global::Org.Android.Agoo.Net.Channel.IPullHandler p2, global::Com.Umeng.Message.Proguard.AV p3)
		{
			if (id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ == IntPtr.Zero)
				id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;[BLorg/android/agoo/net/channel/IPullHandler;Lcom/umeng/message/proguard/aV;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			int __ret = JNIEnv.CallIntMethod (Handle, id_send_Ljava_lang_String_arrayBLorg_android_agoo_net_channel_IPullHandler_Lcom_umeng_message_proguard_aV_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		IntPtr id_shutdown;
		public void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod (Handle, id_shutdown);
		}

		static Delegate cb_syncDisconnect;
#pragma warning disable 0169
		static Delegate GetSyncDisconnectHandler ()
		{
			if (cb_syncDisconnect == null)
				cb_syncDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncDisconnect);
			return cb_syncDisconnect;
		}

		static void n_SyncDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Net.Channel.IDataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IDataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncDisconnect ();
		}
#pragma warning restore 0169

		IntPtr id_syncDisconnect;
		public void SyncDisconnect ()
		{
			if (id_syncDisconnect == IntPtr.Zero)
				id_syncDisconnect = JNIEnv.GetMethodID (class_ref, "syncDisconnect", "()V");
			JNIEnv.CallVoidMethod (Handle, id_syncDisconnect);
		}

	}

}
