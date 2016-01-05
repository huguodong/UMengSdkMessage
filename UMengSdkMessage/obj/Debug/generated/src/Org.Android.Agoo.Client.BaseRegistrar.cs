using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']"
	[global::Android.Runtime.Register ("org/android/agoo/client/BaseRegistrar", DoNotGenerateAcw=true)]
	public partial class BaseRegistrar : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/BaseRegistrar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseRegistrar); }
		}

		protected BaseRegistrar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/constructor[@name='BaseRegistrar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BaseRegistrar () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseRegistrar)) {
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

		static IntPtr id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='baseRegister' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("baseRegister", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static void BaseRegister (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "baseRegister", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='baseRegister' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register ("baseRegister", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		protected static void BaseRegister (global::Android.Content.Context p0, string p1, string p2, string p3, bool p4)
		{
			if (id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "baseRegister", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_baseRegister_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_checkDevice_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='checkDevice' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkDevice", "(Landroid/content/Context;)V", "")]
		public static void CheckDevice (global::Android.Content.Context p0)
		{
			if (id_checkDevice_Landroid_content_Context_ == IntPtr.Zero)
				id_checkDevice_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkDevice", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkDevice_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_getMtopService_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='getMtopService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMtopService", "(Landroid/content/Context;)Lorg/android/agoo/IMtopService;", "")]
		protected static global::Org.Android.Agoo.IMtopService GetMtopService (global::Android.Content.Context p0)
		{
			if (id_getMtopService_Landroid_content_Context_ == IntPtr.Zero)
				id_getMtopService_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMtopService", "(Landroid/content/Context;)Lorg/android/agoo/IMtopService;");
			global::Org.Android.Agoo.IMtopService __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IMtopService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMtopService_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRegistrationId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='getRegistrationId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegistrationId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetRegistrationId (global::Android.Content.Context p0)
		{
			if (id_getRegistrationId_Landroid_content_Context_ == IntPtr.Zero)
				id_getRegistrationId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRegistrationId", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRegistrationId_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_isRegistered_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='isRegistered' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isRegistered", "(Landroid/content/Context;)Z", "")]
		public static bool IsRegistered (global::Android.Content.Context p0)
		{
			if (id_isRegistered_Landroid_content_Context_ == IntPtr.Zero)
				id_isRegistered_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isRegistered", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isRegistered_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_pingMessage_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='pingMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("pingMessage", "(Landroid/content/Context;Z)V", "")]
		public static void PingMessage (global::Android.Content.Context p0, bool p1)
		{
			if (id_pingMessage_Landroid_content_Context_Z == IntPtr.Zero)
				id_pingMessage_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "pingMessage", "(Landroid/content/Context;Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_pingMessage_Landroid_content_Context_Z, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='sendAsynMtop' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest']]"
		[Register ("sendAsynMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V", "")]
		public static void SendAsynMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1)
		{
			if (id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == IntPtr.Zero)
				id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNIEnv.GetStaticMethodID (class_ref, "sendAsynMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='sendAsynMtop' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest'] and parameter[3][@type='org.android.agoo.client.MtopProxyResponseHandler']]"
		[Register ("sendAsynMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;Lorg/android/agoo/client/MtopProxyResponseHandler;)V", "")]
		public static void SendAsynMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1, global::Org.Android.Agoo.Client.IMtopProxyResponseHandler p2)
		{
			if (id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ == IntPtr.Zero)
				id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_ = JNIEnv.GetStaticMethodID (class_ref, "sendAsynMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;Lorg/android/agoo/client/MtopProxyResponseHandler;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAsynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_Lorg_android_agoo_client_MtopProxyResponseHandler_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_sendSynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='sendSynMtop' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.MtopProxyRequest']]"
		[Register ("sendSynMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V", "")]
		public static void SendSynMtop (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.MtopProxyRequest p1)
		{
			if (id_sendSynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ == IntPtr.Zero)
				id_sendSynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_ = JNIEnv.GetStaticMethodID (class_ref, "sendSynMtop", "(Landroid/content/Context;Lorg/android/agoo/client/MtopProxyRequest;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendSynMtop_Landroid_content_Context_Lorg_android_agoo_client_MtopProxyRequest_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_set_Landroid_content_Context_ZZZJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='set' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='long'] and parameter[6][@type='boolean']]"
		[Register ("set", "(Landroid/content/Context;ZZZJZ)V", "")]
		protected static void Set (global::Android.Content.Context p0, bool p1, bool p2, bool p3, long p4, bool p5)
		{
			if (id_set_Landroid_content_Context_ZZZJZ == IntPtr.Zero)
				id_set_Landroid_content_Context_ZZZJZ = JNIEnv.GetStaticMethodID (class_ref, "set", "(Landroid/content/Context;ZZZJZ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_set_Landroid_content_Context_ZZZJZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

		static IntPtr id_setAgooGroup_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='setAgooGroup' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAgooGroup", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		protected static void SetAgooGroup (global::Android.Content.Context p0, string p1)
		{
			if (id_setAgooGroup_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setAgooGroup_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAgooGroup", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setAgooGroup_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_setAgooMode_Landroid_content_Context_Lorg_android_agoo_client_Mode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='setAgooMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.Mode']]"
		[Register ("setAgooMode", "(Landroid/content/Context;Lorg/android/agoo/client/Mode;)V", "")]
		public static void SetAgooMode (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.Mode p1)
		{
			if (id_setAgooMode_Landroid_content_Context_Lorg_android_agoo_client_Mode_ == IntPtr.Zero)
				id_setAgooMode_Landroid_content_Context_Lorg_android_agoo_client_Mode_ = JNIEnv.GetStaticMethodID (class_ref, "setAgooMode", "(Landroid/content/Context;Lorg/android/agoo/client/Mode;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setAgooMode_Landroid_content_Context_Lorg_android_agoo_client_Mode_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setAutoUpdate_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='setAutoUpdate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setAutoUpdate", "(Landroid/content/Context;Z)V", "")]
		public static void SetAutoUpdate (global::Android.Content.Context p0, bool p1)
		{
			if (id_setAutoUpdate_Landroid_content_Context_Z == IntPtr.Zero)
				id_setAutoUpdate_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "setAutoUpdate", "(Landroid/content/Context;Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setAutoUpdate_Landroid_content_Context_Z, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setDebug_Landroid_content_Context_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='setDebug' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("setDebug", "(Landroid/content/Context;ZZ)V", "")]
		public static void SetDebug (global::Android.Content.Context p0, bool p1, bool p2)
		{
			if (id_setDebug_Landroid_content_Context_ZZ == IntPtr.Zero)
				id_setDebug_Landroid_content_Context_ZZ = JNIEnv.GetStaticMethodID (class_ref, "setDebug", "(Landroid/content/Context;ZZ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebug_Landroid_content_Context_ZZ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_setServiceProtect_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='setServiceProtect' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setServiceProtect", "(Landroid/content/Context;Z)V", "")]
		public static void SetServiceProtect (global::Android.Content.Context p0, bool p1)
		{
			if (id_setServiceProtect_Landroid_content_Context_Z == IntPtr.Zero)
				id_setServiceProtect_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "setServiceProtect", "(Landroid/content/Context;Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setServiceProtect_Landroid_content_Context_Z, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_setUTVersion_Landroid_content_Context_Lorg_android_agoo_client_UT_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='setUTVersion' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.client.UT']]"
		[Register ("setUTVersion", "(Landroid/content/Context;Lorg/android/agoo/client/UT;)V", "")]
		protected static void SetUTVersion (global::Android.Content.Context p0, global::Org.Android.Agoo.Client.UT p1)
		{
			if (id_setUTVersion_Landroid_content_Context_Lorg_android_agoo_client_UT_ == IntPtr.Zero)
				id_setUTVersion_Landroid_content_Context_Lorg_android_agoo_client_UT_ = JNIEnv.GetStaticMethodID (class_ref, "setUTVersion", "(Landroid/content/Context;Lorg/android/agoo/client/UT;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setUTVersion_Landroid_content_Context_Lorg_android_agoo_client_UT_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_unregister_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='BaseRegistrar']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unregister", "(Landroid/content/Context;)V", "")]
		public static void Unregister (global::Android.Content.Context p0)
		{
			if (id_unregister_Landroid_content_Context_ == IntPtr.Zero)
				id_unregister_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "unregister", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_unregister_Landroid_content_Context_, new JValue (p0));
		}

	}
}
