using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']"
	[Register ("org/android/agoo/net/channel/IPushHandler", "", "Org.Android.Agoo.Net.Channel.IPushHandlerInvoker")]
	public partial interface IPushHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onCommand' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]']]"
		[Register ("onCommand", "(Ljava/lang/Object;JLjava/lang/String;[B)V", "GetOnCommand_Ljava_lang_Object_JLjava_lang_String_arrayBHandler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnCommand (global::Java.Lang.Object p0, long p1, string p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onConnected' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='com.umeng.message.proguard.aT']]"
		[Register ("onConnected", "(Ljava/lang/Object;JJLjava/util/Map;Lcom/umeng/message/proguard/aT;)V", "GetOnConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_Handler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnConnected (global::Java.Lang.Object p0, long p1, long p2, global::System.Collections.Generic.IDictionary<string, string> p3, global::Com.Umeng.Message.Proguard.AT p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onData' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='com.umeng.message.proguard.aV']]"
		[Register ("onData", "(Ljava/lang/Object;JLjava/lang/String;[BLcom/umeng/message/proguard/aV;)V", "GetOnData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_Handler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnData (global::Java.Lang.Object p0, long p1, string p2, byte[] p3, global::Com.Umeng.Message.Proguard.AV p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onDisconnected' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='com.umeng.message.proguard.aT']]"
		[Register ("onDisconnected", "(Ljava/lang/Object;JLcom/umeng/message/proguard/aT;)V", "GetOnDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_Handler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnDisconnected (global::Java.Lang.Object p0, long p1, global::Com.Umeng.Message.Proguard.AT p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onError' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='org.android.agoo.net.channel.ChannelError'] and parameter[4][@type='java.util.Map'] and parameter[5][@type='java.lang.Throwable'] and parameter[6][@type='com.umeng.message.proguard.aT']]"
		[Register ("onError", "(Ljava/lang/Object;JLorg/android/agoo/net/channel/ChannelError;Ljava/util/Map;Ljava/lang/Throwable;Lcom/umeng/message/proguard/aT;)V", "GetOnError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_Handler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnError (global::Java.Lang.Object p0, long p1, global::Org.Android.Agoo.Net.Channel.ChannelError p2, global::System.Collections.Generic.IDictionary<string, string> p3, global::Java.Lang.Throwable p4, global::Com.Umeng.Message.Proguard.AT p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onPing' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long']]"
		[Register ("onPing", "(Ljava/lang/Object;J)V", "GetOnPing_Ljava_lang_Object_JHandler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnPing (global::Java.Lang.Object p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/interface[@name='IPushHandler']/method[@name='onReportDNS' and count(parameter)=1 and parameter[1][@type='com.umeng.message.proguard.aU']]"
		[Register ("onReportDNS", "(Lcom/umeng/message/proguard/aU;)V", "GetOnReportDNS_Lcom_umeng_message_proguard_aU_Handler:Org.Android.Agoo.Net.Channel.IPushHandlerInvoker, UMengSdkMessage")]
		void OnReportDNS (global::Com.Umeng.Message.Proguard.AU p0);

	}

	[global::Android.Runtime.Register ("org/android/agoo/net/channel/IPushHandler", DoNotGenerateAcw=true)]
	internal class IPushHandlerInvoker : global::Java.Lang.Object, IPushHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/net/channel/IPushHandler");
		IntPtr class_ref;

		public static IPushHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.net.channel.IPushHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPushHandlerInvoker); }
		}

		static Delegate cb_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCommand_Ljava_lang_Object_JLjava_lang_String_arrayBHandler ()
		{
			if (cb_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB == null)
				cb_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnCommand_Ljava_lang_Object_JLjava_lang_String_arrayB);
			return cb_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB;
		}

		static void n_OnCommand_Ljava_lang_Object_JLjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCommand (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB;
		public void OnCommand (global::Java.Lang.Object p0, long p1, string p2, byte[] p3)
		{
			if (id_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB == IntPtr.Zero)
				id_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onCommand", "(Ljava/lang/Object;JLjava/lang/String;[B)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_onCommand_Ljava_lang_Object_JLjava_lang_String_arrayB, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_Handler ()
		{
			if (cb_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_ == null)
				cb_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, IntPtr, IntPtr>) n_OnConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_);
			return cb_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_;
		}

		static void n_OnConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.AT p4 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_;
		public void OnConnected (global::Java.Lang.Object p0, long p1, long p2, global::System.Collections.Generic.IDictionary<string, string> p3, global::Com.Umeng.Message.Proguard.AT p4)
		{
			if (id_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_ == IntPtr.Zero)
				id_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Ljava/lang/Object;JJLjava/util/Map;Lcom/umeng/message/proguard/aT;)V");
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			JNIEnv.CallVoidMethod (Handle, id_onConnected_Ljava_lang_Object_JJLjava_util_Map_Lcom_umeng_message_proguard_aT_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_;
#pragma warning disable 0169
		static Delegate GetOnData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_Handler ()
		{
			if (cb_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_ == null)
				cb_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_OnData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_);
			return cb_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_;
		}

		static void n_OnData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Umeng.Message.Proguard.AV p4 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AV> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnData (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_;
		public void OnData (global::Java.Lang.Object p0, long p1, string p2, byte[] p3, global::Com.Umeng.Message.Proguard.AV p4)
		{
			if (id_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_ == IntPtr.Zero)
				id_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_ = JNIEnv.GetMethodID (class_ref, "onData", "(Ljava/lang/Object;JLjava/lang/String;[BLcom/umeng/message/proguard/aV;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_onData_Ljava_lang_Object_JLjava_lang_String_arrayBLcom_umeng_message_proguard_aV_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_Handler ()
		{
			if (cb_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_ == null)
				cb_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_);
			return cb_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_;
		}

		static void n_OnDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.AT p2 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_;
		public void OnDisconnected (global::Java.Lang.Object p0, long p1, global::Com.Umeng.Message.Proguard.AT p2)
		{
			if (id_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_ == IntPtr.Zero)
				id_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_ = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Ljava/lang/Object;JLcom/umeng/message/proguard/aT;)V");
			JNIEnv.CallVoidMethod (Handle, id_onDisconnected_Ljava_lang_Object_JLcom_umeng_message_proguard_aT_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_Handler ()
		{
			if (cb_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_ == null)
				cb_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_);
			return cb_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_;
		}

		static void n_OnError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Agoo.Net.Channel.ChannelError p2 = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.ChannelError> (native_p2, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.AT p5 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AT> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_;
		public void OnError (global::Java.Lang.Object p0, long p1, global::Org.Android.Agoo.Net.Channel.ChannelError p2, global::System.Collections.Generic.IDictionary<string, string> p3, global::Java.Lang.Throwable p4, global::Com.Umeng.Message.Proguard.AT p5)
		{
			if (id_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_ == IntPtr.Zero)
				id_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Object;JLorg/android/agoo/net/channel/ChannelError;Ljava/util/Map;Ljava/lang/Throwable;Lcom/umeng/message/proguard/aT;)V");
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			JNIEnv.CallVoidMethod (Handle, id_onError_Ljava_lang_Object_JLorg_android_agoo_net_channel_ChannelError_Ljava_util_Map_Ljava_lang_Throwable_Lcom_umeng_message_proguard_aT_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_onPing_Ljava_lang_Object_J;
#pragma warning disable 0169
		static Delegate GetOnPing_Ljava_lang_Object_JHandler ()
		{
			if (cb_onPing_Ljava_lang_Object_J == null)
				cb_onPing_Ljava_lang_Object_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnPing_Ljava_lang_Object_J);
			return cb_onPing_Ljava_lang_Object_J;
		}

		static void n_OnPing_Ljava_lang_Object_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPing (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPing_Ljava_lang_Object_J;
		public void OnPing (global::Java.Lang.Object p0, long p1)
		{
			if (id_onPing_Ljava_lang_Object_J == IntPtr.Zero)
				id_onPing_Ljava_lang_Object_J = JNIEnv.GetMethodID (class_ref, "onPing", "(Ljava/lang/Object;J)V");
			JNIEnv.CallVoidMethod (Handle, id_onPing_Ljava_lang_Object_J, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onReportDNS_Lcom_umeng_message_proguard_aU_;
#pragma warning disable 0169
		static Delegate GetOnReportDNS_Lcom_umeng_message_proguard_aU_Handler ()
		{
			if (cb_onReportDNS_Lcom_umeng_message_proguard_aU_ == null)
				cb_onReportDNS_Lcom_umeng_message_proguard_aU_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReportDNS_Lcom_umeng_message_proguard_aU_);
			return cb_onReportDNS_Lcom_umeng_message_proguard_aU_;
		}

		static void n_OnReportDNS_Lcom_umeng_message_proguard_aU_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Net.Channel.IPushHandler __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Channel.IPushHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Message.Proguard.AU p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AU> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReportDNS (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReportDNS_Lcom_umeng_message_proguard_aU_;
		public void OnReportDNS (global::Com.Umeng.Message.Proguard.AU p0)
		{
			if (id_onReportDNS_Lcom_umeng_message_proguard_aU_ == IntPtr.Zero)
				id_onReportDNS_Lcom_umeng_message_proguard_aU_ = JNIEnv.GetMethodID (class_ref, "onReportDNS", "(Lcom/umeng/message/proguard/aU;)V");
			JNIEnv.CallVoidMethod (Handle, id_onReportDNS_Lcom_umeng_message_proguard_aU_, new JValue (p0));
		}

	}

}
