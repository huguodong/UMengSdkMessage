using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Mtop {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopRequestHelper']"
	[global::Android.Runtime.Register ("org/android/agoo/net/mtop/MtopRequestHelper", DoNotGenerateAcw=true)]
	public partial class MtopRequestHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopRequestHelper']/field[@name='a']"
		[Register ("a")]
		public const string A = (string) "&";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/mtop/MtopRequestHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtopRequestHelper); }
		}

		protected MtopRequestHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopRequestHelper']/constructor[@name='MtopRequestHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MtopRequestHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MtopRequestHelper)) {
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

		static IntPtr id_checkAppKeyAndAppSecret_Lorg_android_agoo_net_mtop_MtopRequest_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopRequestHelper']/method[@name='checkAppKeyAndAppSecret' and count(parameter)=3 and parameter[1][@type='org.android.agoo.net.mtop.MtopRequest'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkAppKeyAndAppSecret", "(Lorg/android/agoo/net/mtop/MtopRequest;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void CheckAppKeyAndAppSecret (global::Org.Android.Agoo.Net.Mtop.MtopRequest p0, string p1, string p2)
		{
			if (id_checkAppKeyAndAppSecret_Lorg_android_agoo_net_mtop_MtopRequest_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_checkAppKeyAndAppSecret_Lorg_android_agoo_net_mtop_MtopRequest_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkAppKeyAndAppSecret", "(Lorg/android/agoo/net/mtop/MtopRequest;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkAppKeyAndAppSecret_Lorg_android_agoo_net_mtop_MtopRequest_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_getUrlWithRequestParams_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.mtop']/class[@name='MtopRequestHelper']/method[@name='getUrlWithRequestParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.android.agoo.net.mtop.MtopRequest']]"
		[Register ("getUrlWithRequestParams", "(Landroid/content/Context;Lorg/android/agoo/net/mtop/MtopRequest;)Lorg/android/agoo/net/async/RequestParams;", "")]
		public static global::Org.Android.Agoo.Net.Async.RequestParams GetUrlWithRequestParams (global::Android.Content.Context p0, global::Org.Android.Agoo.Net.Mtop.MtopRequest p1)
		{
			if (id_getUrlWithRequestParams_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_ == IntPtr.Zero)
				id_getUrlWithRequestParams_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_ = JNIEnv.GetStaticMethodID (class_ref, "getUrlWithRequestParams", "(Landroid/content/Context;Lorg/android/agoo/net/mtop/MtopRequest;)Lorg/android/agoo/net/async/RequestParams;");
			global::Org.Android.Agoo.Net.Async.RequestParams __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Net.Async.RequestParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUrlWithRequestParams_Landroid_content_Context_Lorg_android_agoo_net_mtop_MtopRequest_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
