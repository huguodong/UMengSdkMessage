using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aE']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aE", DoNotGenerateAcw=true)]
	public sealed partial class AE : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AE); }
		}

		internal AE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aE']/constructor[@name='aE' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AE () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AE)) {
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

		static IntPtr id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aG_Ljava_lang_String_Lorg_android_du_CpuType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aE']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.proguard.aG'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.android.du.CpuType']]"
		[Register ("a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aG;Ljava/lang/String;Lorg/android/du/CpuType;)Z", "")]
		public static bool A (global::Android.Content.Context p0, global::Com.Umeng.Message.Proguard.AG p1, string p2, global::Org.Android.DU.CpuType p3)
		{
			if (id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aG_Ljava_lang_String_Lorg_android_du_CpuType_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aG_Ljava_lang_String_Lorg_android_du_CpuType_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aG;Ljava/lang/String;Lorg/android/du/CpuType;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aG_Ljava_lang_String_Lorg_android_du_CpuType_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_Lorg_android_du_CpuType_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aE']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.android.du.CpuType'] and parameter[4][@type='android.content.Context']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Lorg/android/du/CpuType;Landroid/content/Context;)Ljava/lang/Boolean;", "")]
		public static global::Java.Lang.Boolean A (string p0, string p1, global::Org.Android.DU.CpuType p2, global::Android.Content.Context p3)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_Lorg_android_du_CpuType_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_Lorg_android_du_CpuType_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;Lorg/android/du/CpuType;Landroid/content/Context;)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Ljava_lang_String_Lorg_android_du_CpuType_Landroid_content_Context_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
