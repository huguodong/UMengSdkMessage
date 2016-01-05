using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='CRLF']"
		[Register ("CRLF")]
		public const int Crlf = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public const int Default = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='NO_CLOSE']"
		[Register ("NO_CLOSE")]
		public const int NoClose = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='NO_PADDING']"
		[Register ("NO_PADDING")]
		public const int NoPadding = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='NO_WRAP']"
		[Register ("NO_WRAP")]
		public const int NoWrap = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='URL_SAFE']"
		[Register ("URL_SAFE")]
		public const int UrlSafe = (int) 8;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decode", "([BI)[B", "")]
		public static byte[] Decode (byte[] p0, int p1)
		{
			if (id_decode_arrayBI == IntPtr.Zero)
				id_decode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='decode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decode", "([BIII)[B", "")]
		public static byte[] Decode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_decode_arrayBIII == IntPtr.Zero)
				id_decode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_decode_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("decode", "(Ljava/lang/String;I)[B", "")]
		public static byte[] Decode (string p0, int p1)
		{
			if (id_decode_Ljava_lang_String_I == IntPtr.Zero)
				id_decode_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;I)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encode", "([BI)[B", "")]
		public static byte[] Encode (byte[] p0, int p1)
		{
			if (id_encode_arrayBI == IntPtr.Zero)
				id_encode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "([BIII)[B", "")]
		public static byte[] Encode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encode_arrayBIII == IntPtr.Zero)
				id_encode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeToString_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encodeToString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encodeToString", "([BI)Ljava/lang/String;", "")]
		public static string EncodeToString (byte[] p0, int p1)
		{
			if (id_encodeToString_arrayBI == IntPtr.Zero)
				id_encodeToString_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_encodeToString_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encodeToString' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeToString", "([BIII)Ljava/lang/String;", "")]
		public static string EncodeToString (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encodeToString_arrayBIII == IntPtr.Zero)
				id_encodeToString_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BIII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBIII, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}
}
