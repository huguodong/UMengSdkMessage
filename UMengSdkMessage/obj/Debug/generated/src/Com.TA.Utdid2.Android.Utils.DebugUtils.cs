using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='DebugUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/DebugUtils", DoNotGenerateAcw=true)]
	public partial class DebugUtils : global::Java.Lang.Object {


		static IntPtr DBG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='DebugUtils']/field[@name='DBG']"
		[Register ("DBG")]
		public static bool Dbg {
			get {
				if (DBG_jfieldId == IntPtr.Zero)
					DBG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DBG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DBG_jfieldId);
			}
			set {
				if (DBG_jfieldId == IntPtr.Zero)
					DBG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DBG", "Z");
				JNIEnv.SetStaticField (class_ref, DBG_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/DebugUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DebugUtils); }
		}

		protected DebugUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='DebugUtils']/constructor[@name='DebugUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DebugUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DebugUtils)) {
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

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='DebugUtils']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='DebugUtils']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "")]
		public static int GetInt (string p0, int p1)
		{
			if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInt_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
