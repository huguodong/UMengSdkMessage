using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']"
	[global::Android.Runtime.Register ("org/android/spdy/SpdyAgent", DoNotGenerateAcw=true)]
	public sealed partial class SpdyAgent : global::Java.Lang.Object {


		static IntPtr enableDebug_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/field[@name='enableDebug']"
		[Register ("enableDebug")]
		public static bool EnableDebug {
			get {
				if (enableDebug_jfieldId == IntPtr.Zero)
					enableDebug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableDebug", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, enableDebug_jfieldId);
			}
			set {
				if (enableDebug_jfieldId == IntPtr.Zero)
					enableDebug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableDebug", "Z");
				JNIEnv.SetStaticField (class_ref, enableDebug_jfieldId, value);
			}
		}

		static IntPtr enableTimeGaurd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/field[@name='enableTimeGaurd']"
		[Register ("enableTimeGaurd")]
		public static bool EnableTimeGaurd {
			get {
				if (enableTimeGaurd_jfieldId == IntPtr.Zero)
					enableTimeGaurd_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableTimeGaurd", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, enableTimeGaurd_jfieldId);
			}
			set {
				if (enableTimeGaurd_jfieldId == IntPtr.Zero)
					enableTimeGaurd_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enableTimeGaurd", "Z");
				JNIEnv.SetStaticField (class_ref, enableTimeGaurd_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/spdy/SpdyAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpdyAgent); }
		}

		internal SpdyAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_closeSession_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='closeSession' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("closeSession", "(Ljava/lang/String;)I", "")]
		public int CloseSession (string p0)
		{
			if (id_closeSession_Ljava_lang_String_ == IntPtr.Zero)
				id_closeSession_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "closeSession", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_closeSession_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_configLogFile_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='configLogFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("configLogFile", "(Ljava/lang/String;II)I", "")]
		public int ConfigLogFile (string p0, int p1, int p2)
		{
			if (id_configLogFile_Ljava_lang_String_II == IntPtr.Zero)
				id_configLogFile_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "configLogFile", "(Ljava/lang/String;II)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_configLogFile_Ljava_lang_String_II, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_configLogFile_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='configLogFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("configLogFile", "(Ljava/lang/String;III)I", "")]
		public int ConfigLogFile (string p0, int p1, int p2, int p3)
		{
			if (id_configLogFile_Ljava_lang_String_III == IntPtr.Zero)
				id_configLogFile_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "configLogFile", "(Ljava/lang/String;III)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_configLogFile_Ljava_lang_String_III, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='createSession' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.android.spdy.SessionCb']]"
		[Register ("createSession", "(Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;)Lorg/android/spdy/SpdySession;", "")]
		public global::Org.Android.Spdy.SpdySession CreateSession (string p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.ISessionCb p2)
		{
			if (id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_ == IntPtr.Zero)
				id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_ = JNIEnv.GetMethodID (class_ref, "createSession", "(Ljava/lang/String;Ljava/lang/Object;Lorg/android/spdy/SessionCb;)Lorg/android/spdy/SpdySession;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod  (Handle, id_createSession_Ljava_lang_String_Ljava_lang_Object_Lorg_android_spdy_SessionCb_, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.spdy.SpdyVersion'] and parameter[3][@type='org.android.spdy.SpdySessionKind']]"
		[Register ("getInstance", "(Landroid/content/Context;Lorg/android/spdy/SpdyVersion;Lorg/android/spdy/SpdySessionKind;)Lorg/android/spdy/SpdyAgent;", "")]
		public static global::Org.Android.Spdy.SpdyAgent GetInstance (global::Android.Content.Context p0, global::Org.Android.Spdy.SpdyVersion p1, global::Org.Android.Spdy.SpdySessionKind p2)
		{
			if (id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;Lorg/android/spdy/SpdyVersion;Lorg/android/spdy/SpdySessionKind;)Lorg/android/spdy/SpdyAgent;");
			global::Org.Android.Spdy.SpdyAgent __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdyAgent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_Lorg_android_spdy_SpdyVersion_Lorg_android_spdy_SpdySessionKind_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getSession_Lorg_android_spdy_SpdyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='getSession' and count(parameter)=1 and parameter[1][@type='org.android.spdy.SpdyRequest']]"
		[Register ("getSession", "(Lorg/android/spdy/SpdyRequest;)Lorg/android/spdy/SpdySession;", "")]
		public global::Org.Android.Spdy.SpdySession GetSession (global::Org.Android.Spdy.SpdyRequest p0)
		{
			if (id_getSession_Lorg_android_spdy_SpdyRequest_ == IntPtr.Zero)
				id_getSession_Lorg_android_spdy_SpdyRequest_ = JNIEnv.GetMethodID (class_ref, "getSession", "(Lorg/android/spdy/SpdyRequest;)Lorg/android/spdy/SpdySession;");
			global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod  (Handle, id_getSession_Lorg_android_spdy_SpdyRequest_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_inspect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='inspect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("inspect", "(Ljava/lang/String;)V", "")]
		public static void Inspect (string p0)
		{
			if (id_inspect_Ljava_lang_String_ == IntPtr.Zero)
				id_inspect_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "inspect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_inspect_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_logFileClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='logFileClose' and count(parameter)=0]"
		[Register ("logFileClose", "()V", "")]
		public void LogFileClose ()
		{
			if (id_logFileClose == IntPtr.Zero)
				id_logFileClose = JNIEnv.GetMethodID (class_ref, "logFileClose", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_logFileClose);
		}

		static IntPtr id_logFileFlush;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='logFileFlush' and count(parameter)=0]"
		[Register ("logFileFlush", "()V", "")]
		public void LogFileFlush ()
		{
			if (id_logFileFlush == IntPtr.Zero)
				id_logFileFlush = JNIEnv.GetMethodID (class_ref, "logFileFlush", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_logFileFlush);
		}

		static IntPtr id_setConnectTimeOut_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setConnectTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConnectTimeOut", "(I)I", "")]
		public int SetConnectTimeOut (int p0)
		{
			if (id_setConnectTimeOut_I == IntPtr.Zero)
				id_setConnectTimeOut_I = JNIEnv.GetMethodID (class_ref, "setConnectTimeOut", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_setConnectTimeOut_I, new JValue (p0));
		}

		static IntPtr id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setProxyUsernamePassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setProxyUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void SetProxyUsernamePassword (string p0, string p1)
		{
			if (id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProxyUsernamePassword", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_setProxyUsernamePassword_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setSessionKind_Lorg_android_spdy_SpdySessionKind_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='setSessionKind' and count(parameter)=1 and parameter[1][@type='org.android.spdy.SpdySessionKind']]"
		[Register ("setSessionKind", "(Lorg/android/spdy/SpdySessionKind;)I", "")]
		public int SetSessionKind (global::Org.Android.Spdy.SpdySessionKind p0)
		{
			if (id_setSessionKind_Lorg_android_spdy_SpdySessionKind_ == IntPtr.Zero)
				id_setSessionKind_Lorg_android_spdy_SpdySessionKind_ = JNIEnv.GetMethodID (class_ref, "setSessionKind", "(Lorg/android/spdy/SpdySessionKind;)I");
			int __ret = JNIEnv.CallIntMethod  (Handle, id_setSessionKind_Lorg_android_spdy_SpdySessionKind_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Ljava_lang_Object_Lorg_android_spdy_Spdycb_Lorg_android_spdy_SessionCb_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/class[@name='SpdyAgent']/method[@name='submitRequest' and count(parameter)=7 and parameter[1][@type='org.android.spdy.SpdyRequest'] and parameter[2][@type='org.android.spdy.SpdyDataProvider'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='org.android.spdy.Spdycb'] and parameter[6][@type='org.android.spdy.SessionCb'] and parameter[7][@type='int']]"
		[Register ("submitRequest", "(Lorg/android/spdy/SpdyRequest;Lorg/android/spdy/SpdyDataProvider;Ljava/lang/Object;Ljava/lang/Object;Lorg/android/spdy/Spdycb;Lorg/android/spdy/SessionCb;I)Lorg/android/spdy/SpdySession;", "")]
		public global::Org.Android.Spdy.SpdySession SubmitRequest (global::Org.Android.Spdy.SpdyRequest p0, global::Org.Android.Spdy.SpdyDataProvider p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Org.Android.Spdy.ISpdycb p4, global::Org.Android.Spdy.ISessionCb p5, int p6)
		{
			if (id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Ljava_lang_Object_Lorg_android_spdy_Spdycb_Lorg_android_spdy_SessionCb_I == IntPtr.Zero)
				id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Ljava_lang_Object_Lorg_android_spdy_Spdycb_Lorg_android_spdy_SessionCb_I = JNIEnv.GetMethodID (class_ref, "submitRequest", "(Lorg/android/spdy/SpdyRequest;Lorg/android/spdy/SpdyDataProvider;Ljava/lang/Object;Ljava/lang/Object;Lorg/android/spdy/Spdycb;Lorg/android/spdy/SessionCb;I)Lorg/android/spdy/SpdySession;");
			global::Org.Android.Spdy.SpdySession __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (JNIEnv.CallObjectMethod  (Handle, id_submitRequest_Lorg_android_spdy_SpdyRequest_Lorg_android_spdy_SpdyDataProvider_Ljava_lang_Object_Ljava_lang_Object_Lorg_android_spdy_Spdycb_Lorg_android_spdy_SessionCb_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
