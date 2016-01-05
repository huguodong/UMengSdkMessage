using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']"
	[global::Android.Runtime.Register ("org/android/agoo/client/MtopProxyRequest", DoNotGenerateAcw=true)]
	public sealed partial class MtopProxyRequest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/MtopProxyRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopProxyRequest); }
		}

		internal MtopProxyRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/constructor[@name='MtopProxyRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MtopProxyRequest () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MtopProxyRequest)) {
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

		static IntPtr id_getApi;
		static IntPtr id_setApi_Ljava_lang_String_;
		public string Api {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getApi' and count(parameter)=0]"
			[Register ("getApi", "()Ljava/lang/String;", "GetGetApiHandler")]
			get {
				if (id_getApi == IntPtr.Zero)
					id_getApi = JNIEnv.GetMethodID (class_ref, "getApi", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getApi), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setApi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApi", "(Ljava/lang/String;)V", "GetSetApi_Ljava_lang_String_Handler")]
			set {
				if (id_setApi_Ljava_lang_String_ == IntPtr.Zero)
					id_setApi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApi", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setApi_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getAppKey;
		static IntPtr id_setAppKey_Ljava_lang_String_;
		public string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppKey", "(Ljava/lang/String;)V", "GetSetAppKey_Ljava_lang_String_Handler")]
			set {
				if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setAppKey_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getAppSecret;
		static IntPtr id_setAppSecret_Ljava_lang_String_;
		public string AppSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getAppSecret' and count(parameter)=0]"
			[Register ("getAppSecret", "()Ljava/lang/String;", "GetGetAppSecretHandler")]
			get {
				if (id_getAppSecret == IntPtr.Zero)
					id_getAppSecret = JNIEnv.GetMethodID (class_ref, "getAppSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAppSecret), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setAppSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppSecret", "(Ljava/lang/String;)V", "GetSetAppSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setAppSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setAppSecret_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getEcode;
		static IntPtr id_setEcode_Ljava_lang_String_;
		public string Ecode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getEcode' and count(parameter)=0]"
			[Register ("getEcode", "()Ljava/lang/String;", "GetGetEcodeHandler")]
			get {
				if (id_getEcode == IntPtr.Zero)
					id_getEcode = JNIEnv.GetMethodID (class_ref, "getEcode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getEcode), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setEcode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEcode", "(Ljava/lang/String;)V", "GetSetEcode_Ljava_lang_String_Handler")]
			set {
				if (id_setEcode_Ljava_lang_String_ == IntPtr.Zero)
					id_setEcode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEcode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setEcode_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_isHasSigin;
		static IntPtr id_setHasSigin_Z;
		public bool HasSigin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='isHasSigin' and count(parameter)=0]"
			[Register ("isHasSigin", "()Z", "GetIsHasSiginHandler")]
			get {
				if (id_isHasSigin == IntPtr.Zero)
					id_isHasSigin = JNIEnv.GetMethodID (class_ref, "isHasSigin", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_isHasSigin);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setHasSigin' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHasSigin", "(Z)V", "GetSetHasSigin_ZHandler")]
			set {
				if (id_setHasSigin_Z == IntPtr.Zero)
					id_setHasSigin_Z = JNIEnv.GetMethodID (class_ref, "setHasSigin", "(Z)V");
				JNIEnv.CallVoidMethod  (Handle, id_setHasSigin_Z, new JValue (value));
			}
		}

		static IntPtr id_getParams;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/Map;", "GetGetParamsHandler")]
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSId;
		static IntPtr id_setSId_Ljava_lang_String_;
		public string SId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getSId' and count(parameter)=0]"
			[Register ("getSId", "()Ljava/lang/String;", "GetGetSIdHandler")]
			get {
				if (id_getSId == IntPtr.Zero)
					id_getSId = JNIEnv.GetMethodID (class_ref, "getSId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setSId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSId", "(Ljava/lang/String;)V", "GetSetSId_Ljava_lang_String_Handler")]
			set {
				if (id_setSId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setSId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getSysParams;
		public global::System.Collections.Generic.IDictionary<string, string> SysParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getSysParams' and count(parameter)=0]"
			[Register ("getSysParams", "()Ljava/util/Map;", "GetGetSysParamsHandler")]
			get {
				if (id_getSysParams == IntPtr.Zero)
					id_getSysParams = JNIEnv.GetMethodID (class_ref, "getSysParams", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSysParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getTime;
		static IntPtr id_setTime_J;
		public long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()J", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()J");
				return JNIEnv.CallLongMethod  (Handle, id_getTime);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTime", "(J)V", "GetSetTime_JHandler")]
			set {
				if (id_setTime_J == IntPtr.Zero)
					id_setTime_J = JNIEnv.GetMethodID (class_ref, "setTime", "(J)V");
				JNIEnv.CallVoidMethod  (Handle, id_setTime_J, new JValue (value));
			}
		}

		static IntPtr id_getTtId;
		static IntPtr id_setTtId_Ljava_lang_String_;
		public string TtId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getTtId' and count(parameter)=0]"
			[Register ("getTtId", "()Ljava/lang/String;", "GetGetTtIdHandler")]
			get {
				if (id_getTtId == IntPtr.Zero)
					id_getTtId = JNIEnv.GetMethodID (class_ref, "getTtId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTtId), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setTtId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTtId", "(Ljava/lang/String;)V", "GetSetTtId_Ljava_lang_String_Handler")]
			set {
				if (id_setTtId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTtId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTtId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallVoidMethod  (Handle, id_setTtId_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getV;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='getV' and count(parameter)=0]"
		[Register ("getV", "()Ljava/lang/String;", "")]
		public string GetV ()
		{
			if (id_getV == IntPtr.Zero)
				id_getV = JNIEnv.GetMethodID (class_ref, "getV", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getV), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_putParams_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='putParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("putParams", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public void PutParams (string p0, global::Java.Lang.Object p1)
		{
			if (id_putParams_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_putParams_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putParams", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_putParams_Ljava_lang_String_Ljava_lang_Object_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_putSysParams_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='putSysParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putSysParams", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public void PutSysParams (string p0, string p1)
		{
			if (id_putSysParams_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putSysParams_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putSysParams", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallVoidMethod  (Handle, id_putSysParams_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setV_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='MtopProxyRequest']/method[@name='setV' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setV", "(Ljava/lang/String;)V", "")]
		public void SetV (string p0)
		{
			if (id_setV_Ljava_lang_String_ == IntPtr.Zero)
				id_setV_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setV", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod  (Handle, id_setV_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
