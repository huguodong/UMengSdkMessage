using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aD", DoNotGenerateAcw=true)]
	public sealed partial class AD : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aD", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AD); }
		}

		internal AD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/constructor[@name='aD' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AD () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AD)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "")]
		public static void A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aT_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.proguard.aT']]"
		[Register ("a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aT;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Com.Umeng.Message.Proguard.AT p1)
		{
			if (id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aT_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aT_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aT;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aT_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aU_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.proguard.aU']]"
		[Register ("a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aU;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Com.Umeng.Message.Proguard.AU p1)
		{
			if (id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aU_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aU_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aU;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aU_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aV_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.message.proguard.aV']]"
		[Register ("a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aV;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Com.Umeng.Message.Proguard.AV p1)
		{
			if (id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aV_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aV_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/umeng/message/proguard/aV;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Lcom_umeng_message_proguard_aV_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, int p1, string p2)
		{
			if (id_a_Landroid_content_Context_ILjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_ILjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String...']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/Object;[Ljava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Java.Lang.Object p1, params  string[] p2)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/Object;[Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;JJ)V", "")]
		public static void A (global::Android.Content.Context p0, string p1, long p2, long p3)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_JJ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_JJ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_JJ, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/Throwable;)V", "")]
		public static void A (global::Android.Content.Context p0, global::Java.Lang.Throwable p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("a", "(Landroid/content/Context;J)V", "")]
		public static void A (global::Android.Content.Context p0, long p1)
		{
			if (id_a_Landroid_content_Context_J == IntPtr.Zero)
				id_a_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;J)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_J, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_a_Landroid_content_Context_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;JLjava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, long p1, string p2)
		{
			if (id_a_Landroid_content_Context_JLjava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_JLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;JLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_JLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_a_Landroid_content_Context_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;JLjava/lang/String;Ljava/lang/String;)V", "")]
		public static void A (global::Android.Content.Context p0, long p1, string p2, string p3)
		{
			if (id_a_Landroid_content_Context_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;JLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_JLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_a_Landroid_content_Context_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("a", "(Landroid/content/Context;JJ)V", "")]
		public static void A (global::Android.Content.Context p0, long p1, long p2)
		{
			if (id_a_Landroid_content_Context_JJ == IntPtr.Zero)
				id_a_Landroid_content_Context_JJ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;JJ)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_JJ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_a_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("a", "(Ljava/lang/Throwable;)V", "")]
		public static void A (global::Java.Lang.Throwable p0)
		{
			if (id_a_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_a_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Throwable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Ljava_lang_Throwable_, new JValue (p0));
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)V", "")]
		public static void B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_b_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void B (global::Android.Content.Context p0, string p1)
		{
			if (id_b_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='b' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void B (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_b_Landroid_content_Context_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='b' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("b", "(Landroid/content/Context;Ljava/lang/String;JJ)V", "")]
		public static void B (global::Android.Content.Context p0, string p1, long p2, long p3)
		{
			if (id_b_Landroid_content_Context_Ljava_lang_String_JJ == IntPtr.Zero)
				id_b_Landroid_content_Context_Ljava_lang_String_JJ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_Ljava_lang_String_JJ, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_c_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("c", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string C (global::Android.Content.Context p0)
		{
			if (id_c_Landroid_content_Context_ == IntPtr.Zero)
				id_c_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_c_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("c", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void C (global::Android.Content.Context p0, string p1)
		{
			if (id_c_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='c' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("c", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void C (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_d_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("d", "(Landroid/content/Context;)V", "")]
		public static void D (global::Android.Content.Context p0)
		{
			if (id_d_Landroid_content_Context_ == IntPtr.Zero)
				id_d_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_d_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='d' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void D (global::Android.Content.Context p0, string p1)
		{
			if (id_d_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='d' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("d", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void D (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_e_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='e' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("e", "(Landroid/content/Context;)V", "")]
		public static void E (global::Android.Content.Context p0)
		{
			if (id_e_Landroid_content_Context_ == IntPtr.Zero)
				id_e_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_e_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='e' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void E (global::Android.Content.Context p0, string p1)
		{
			if (id_e_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='e' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("e", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void E (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_f_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='f' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("f", "(Landroid/content/Context;)V", "")]
		public static void F (global::Android.Content.Context p0)
		{
			if (id_f_Landroid_content_Context_ == IntPtr.Zero)
				id_f_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_f_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_f_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='f' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("f", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void F (global::Android.Content.Context p0, string p1)
		{
			if (id_f_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_f_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "f", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_f_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_g_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='g' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("g", "(Landroid/content/Context;)V", "")]
		public static void G (global::Android.Content.Context p0)
		{
			if (id_g_Landroid_content_Context_ == IntPtr.Zero)
				id_g_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_g_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_g_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='g' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("g", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void G (global::Android.Content.Context p0, string p1)
		{
			if (id_g_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_g_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "g", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_g_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_h_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='h' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("h", "(Landroid/content/Context;)V", "")]
		public static void H (global::Android.Content.Context p0)
		{
			if (id_h_Landroid_content_Context_ == IntPtr.Zero)
				id_h_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_h_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_h_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='h' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("h", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void H (global::Android.Content.Context p0, string p1)
		{
			if (id_h_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_h_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "h", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_h_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_i_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='i' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("i", "(Landroid/content/Context;)V", "")]
		public static void I (global::Android.Content.Context p0)
		{
			if (id_i_Landroid_content_Context_ == IntPtr.Zero)
				id_i_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_i_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='i' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void I (global::Android.Content.Context p0, string p1)
		{
			if (id_i_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_j_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='j' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("j", "(Landroid/content/Context;)V", "")]
		public static void J (global::Android.Content.Context p0)
		{
			if (id_j_Landroid_content_Context_ == IntPtr.Zero)
				id_j_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_j_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_j_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='j' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("j", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void J (global::Android.Content.Context p0, string p1)
		{
			if (id_j_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_j_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "j", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_j_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_k_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='k' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("k", "(Landroid/content/Context;)V", "")]
		public static void K (global::Android.Content.Context p0)
		{
			if (id_k_Landroid_content_Context_ == IntPtr.Zero)
				id_k_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "k", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_k_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_k_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='k' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("k", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static void K (global::Android.Content.Context p0, string p1)
		{
			if (id_k_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_k_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "k", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_k_Landroid_content_Context_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_l_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='l' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("l", "(Landroid/content/Context;)V", "")]
		public static void L (global::Android.Content.Context p0)
		{
			if (id_l_Landroid_content_Context_ == IntPtr.Zero)
				id_l_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "l", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_l_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_m_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='m' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("m", "(Landroid/content/Context;)V", "")]
		public static void M (global::Android.Content.Context p0)
		{
			if (id_m_Landroid_content_Context_ == IntPtr.Zero)
				id_m_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "m", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_m_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_n_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='n' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("n", "(Landroid/content/Context;)V", "")]
		public static void N (global::Android.Content.Context p0)
		{
			if (id_n_Landroid_content_Context_ == IntPtr.Zero)
				id_n_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "n", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_n_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_o_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='o' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("o", "(Landroid/content/Context;)V", "")]
		public static void O (global::Android.Content.Context p0)
		{
			if (id_o_Landroid_content_Context_ == IntPtr.Zero)
				id_o_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "o", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_o_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_p_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aD']/method[@name='p' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("p", "(Landroid/content/Context;)V", "")]
		public static void P (global::Android.Content.Context p0)
		{
			if (id_p_Landroid_content_Context_ == IntPtr.Zero)
				id_p_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "p", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_p_Landroid_content_Context_, new JValue (p0));
		}

	}
}
