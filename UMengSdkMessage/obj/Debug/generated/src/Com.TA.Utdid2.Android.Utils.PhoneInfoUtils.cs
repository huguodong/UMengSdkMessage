using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='PhoneInfoUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/PhoneInfoUtils", DoNotGenerateAcw=true)]
	public partial class PhoneInfoUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/PhoneInfoUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhoneInfoUtils); }
		}

		protected PhoneInfoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='PhoneInfoUtils']/constructor[@name='PhoneInfoUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PhoneInfoUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PhoneInfoUtils)) {
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

		static IntPtr id_getUniqueID;
		public static string UniqueID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='PhoneInfoUtils']/method[@name='getUniqueID' and count(parameter)=0]"
			[Register ("getUniqueID", "()Ljava/lang/String;", "GetGetUniqueIDHandler")]
			get {
				if (id_getUniqueID == IntPtr.Zero)
					id_getUniqueID = JNIEnv.GetStaticMethodID (class_ref, "getUniqueID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUniqueID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getImei_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='PhoneInfoUtils']/method[@name='getImei' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getImei", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetImei (global::Android.Content.Context p0)
		{
			if (id_getImei_Landroid_content_Context_ == IntPtr.Zero)
				id_getImei_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getImei", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImei_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getImsi_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='PhoneInfoUtils']/method[@name='getImsi' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getImsi", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static string GetImsi (global::Android.Content.Context p0)
		{
			if (id_getImsi_Landroid_content_Context_ == IntPtr.Zero)
				id_getImsi_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getImsi", "(Landroid/content/Context;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImsi_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
