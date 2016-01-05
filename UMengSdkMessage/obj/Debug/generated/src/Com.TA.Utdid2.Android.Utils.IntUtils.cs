using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='IntUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/IntUtils", DoNotGenerateAcw=true)]
	public partial class IntUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/IntUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IntUtils); }
		}

		protected IntUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='IntUtils']/constructor[@name='IntUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public IntUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IntUtils)) {
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

		static IntPtr id_getBytes_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='IntUtils']/method[@name='getBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getBytes", "([BI)[B", "")]
		public static byte[] GetBytes (byte[] p0, int p1)
		{
			if (id_getBytes_arrayBI == IntPtr.Zero)
				id_getBytes_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "getBytes", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytes_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_getBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='IntUtils']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBytes", "(I)[B", "")]
		public static byte[] GetBytes (int p0)
		{
			if (id_getBytes_I == IntPtr.Zero)
				id_getBytes_I = JNIEnv.GetStaticMethodID (class_ref, "getBytes", "(I)[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytes_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}
}
