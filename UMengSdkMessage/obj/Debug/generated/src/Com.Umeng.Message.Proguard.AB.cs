using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aB", DoNotGenerateAcw=true)]
	public sealed partial class AB : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aB", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AB); }
		}

		internal AB (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']/constructor[@name='aB' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AB () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AB)) {
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

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Z", "")]
		public static bool A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Java.Lang.Class p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_content_Context_arrayLjava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class...']]"
		[Register ("a", "(Landroid/content/Context;[Ljava/lang/Class;)V", "")]
		public static void A (global::Android.Content.Context p0, params global:: Java.Lang.Class[] p1)
		{
			if (id_a_Landroid_content_Context_arrayLjava_lang_Class_ == IntPtr.Zero)
				id_a_Landroid_content_Context_arrayLjava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;[Ljava/lang/Class;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_arrayLjava_lang_Class_, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static bool A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_b_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aB']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public static void B (global::Android.Content.Context p0, global::Java.Lang.Class p1)
		{
			if (id_b_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
				id_b_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;Ljava/lang/Class;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_Ljava_lang_Class_, new JValue (p0), new JValue (p1));
		}

	}
}
