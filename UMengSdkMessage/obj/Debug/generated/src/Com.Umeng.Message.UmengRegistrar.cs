using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']"
	[global::Android.Runtime.Register ("com/umeng/message/UmengRegistrar", DoNotGenerateAcw=true)]
	public partial class UmengRegistrar : global::Org.Android.Agoo.Client.BaseRegistrar {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/UmengRegistrar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengRegistrar); }
		}

		protected UmengRegistrar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']/constructor[@name='UmengRegistrar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UmengRegistrar () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UmengRegistrar)) {
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

		static IntPtr id_checkManifest_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']/method[@name='checkManifest' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkManifest", "(Landroid/content/Context;)V", "")]
		public static void CheckManifest (global::Android.Content.Context p0)
		{
			if (id_checkManifest_Landroid_content_Context_ == IntPtr.Zero)
				id_checkManifest_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkManifest", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkManifest_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_checkRegisteredToUmeng_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']/method[@name='checkRegisteredToUmeng' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkRegisteredToUmeng", "(Landroid/content/Context;)V", "")]
		public static void CheckRegisteredToUmeng (global::Android.Content.Context p0)
		{
			if (id_checkRegisteredToUmeng_Landroid_content_Context_ == IntPtr.Zero)
				id_checkRegisteredToUmeng_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "checkRegisteredToUmeng", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_checkRegisteredToUmeng_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_isRegisteredToUmeng_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']/method[@name='isRegisteredToUmeng' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isRegisteredToUmeng", "(Landroid/content/Context;)Z", "")]
		public static bool IsRegisteredToUmeng (global::Android.Content.Context p0)
		{
			if (id_isRegisteredToUmeng_Landroid_content_Context_ == IntPtr.Zero)
				id_isRegisteredToUmeng_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isRegisteredToUmeng", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isRegisteredToUmeng_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']/method[@name='register' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("register", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void Register (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_registerToUmeng_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message']/class[@name='UmengRegistrar']/method[@name='registerToUmeng' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("registerToUmeng", "(Landroid/content/Context;)V", "")]
		public static void RegisterToUmeng (global::Android.Content.Context p0)
		{
			if (id_registerToUmeng_Landroid_content_Context_ == IntPtr.Zero)
				id_registerToUmeng_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "registerToUmeng", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_registerToUmeng_Landroid_content_Context_, new JValue (p0));
		}

	}
}
