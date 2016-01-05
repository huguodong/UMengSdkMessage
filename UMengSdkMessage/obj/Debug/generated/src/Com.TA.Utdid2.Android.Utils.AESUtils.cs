using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/AESUtils", DoNotGenerateAcw=true)]
	public partial class AESUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AESUtils";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/AESUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AESUtils); }
		}

		protected AESUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/constructor[@name='AESUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AESUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AESUtils)) {
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

		static IntPtr id_decrypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Decrypt (string p0, string p1)
		{
			if (id_decrypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_encrypt_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Encrypt (string p0, string p1)
		{
			if (id_encrypt_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_fromHex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/method[@name='fromHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromHex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string FromHex (string p0)
		{
			if (id_fromHex_Ljava_lang_String_ == IntPtr.Zero)
				id_fromHex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromHex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromHex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_toByte_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/method[@name='toByte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toByte", "(Ljava/lang/String;)[B", "")]
		public static byte[] ToByte (string p0)
		{
			if (id_toByte_Ljava_lang_String_ == IntPtr.Zero)
				id_toByte_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toByte", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toByte_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_toHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/method[@name='toHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toHex", "([B)Ljava/lang/String;", "")]
		public static string ToHex (byte[] p0)
		{
			if (id_toHex_arrayB == IntPtr.Zero)
				id_toHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toHex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='AESUtils']/method[@name='toHex' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toHex", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string ToHex (string p0)
		{
			if (id_toHex_Ljava_lang_String_ == IntPtr.Zero)
				id_toHex_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toHex", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHex_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
