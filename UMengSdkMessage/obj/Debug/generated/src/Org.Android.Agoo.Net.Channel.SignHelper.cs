using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Net.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='SignHelper']"
	[global::Android.Runtime.Register ("org/android/agoo/net/channel/SignHelper", DoNotGenerateAcw=true)]
	public partial class SignHelper : global::Java.Lang.Object {


		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='SignHelper']/field[@name='e']"
		[Register ("e")]
		public static global::Android.Net.Uri E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, e_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, e_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/net/channel/SignHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignHelper); }
		}

		protected SignHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='SignHelper']/constructor[@name='SignHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SignHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SignHelper)) {
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

		static IntPtr id_generatorClient_Landroid_content_Context_ISJJII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='SignHelper']/method[@name='generatorClient' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='short'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("generatorClient", "(Landroid/content/Context;ISJJII)Ljava/lang/String;", "")]
		public static string GeneratorClient (global::Android.Content.Context p0, int p1, short p2, long p3, long p4, int p5, int p6)
		{
			if (id_generatorClient_Landroid_content_Context_ISJJII == IntPtr.Zero)
				id_generatorClient_Landroid_content_Context_ISJJII = JNIEnv.GetStaticMethodID (class_ref, "generatorClient", "(Landroid/content/Context;ISJJII)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generatorClient_Landroid_content_Context_ISJJII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_generatorSign_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.net.channel']/class[@name='SignHelper']/method[@name='generatorSign' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("generatorSign", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string GeneratorSign (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2, string p3, string p4)
		{
			if (id_generatorSign_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generatorSign_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "generatorSign", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generatorSign_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

	}
}
