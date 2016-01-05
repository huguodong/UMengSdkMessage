using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public StringUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (StringUtils)) {
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

		static IntPtr id_convertObjectToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/method[@name='convertObjectToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static string ConvertObjectToString (global::Java.Lang.Object p0)
		{
			if (id_convertObjectToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertObjectToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertObjectToString_Ljava_lang_Object_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_hashCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hashCode", "(Ljava/lang/String;)I", "")]
		public static int HashCode (string p0)
		{
			if (id_hashCode_Ljava_lang_String_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_isEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static bool IsEmpty (string p0)
		{
			if (id_isEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
