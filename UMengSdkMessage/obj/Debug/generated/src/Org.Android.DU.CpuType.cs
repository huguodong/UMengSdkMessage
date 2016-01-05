using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.DU {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.du']/class[@name='CpuType']"
	[global::Android.Runtime.Register ("org/android/du/CpuType", DoNotGenerateAcw=true)]
	public sealed partial class CpuType : global::Java.Lang.Enum {


		static IntPtr armeabi_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.du']/class[@name='CpuType']/field[@name='armeabi']"
		[Register ("armeabi")]
		public static global::Org.Android.DU.CpuType Armeabi {
			get {
				if (armeabi_jfieldId == IntPtr.Zero)
					armeabi_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "armeabi", "Lorg/android/du/CpuType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, armeabi_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.DU.CpuType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (armeabi_jfieldId == IntPtr.Zero)
					armeabi_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "armeabi", "Lorg/android/du/CpuType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, armeabi_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mips_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.du']/class[@name='CpuType']/field[@name='mips']"
		[Register ("mips")]
		public static global::Org.Android.DU.CpuType Mips {
			get {
				if (mips_jfieldId == IntPtr.Zero)
					mips_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mips", "Lorg/android/du/CpuType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mips_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.DU.CpuType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mips_jfieldId == IntPtr.Zero)
					mips_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mips", "Lorg/android/du/CpuType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mips_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr x86_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.du']/class[@name='CpuType']/field[@name='x86']"
		[Register ("x86")]
		public static global::Org.Android.DU.CpuType X86 {
			get {
				if (x86_jfieldId == IntPtr.Zero)
					x86_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "x86", "Lorg/android/du/CpuType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, x86_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.DU.CpuType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (x86_jfieldId == IntPtr.Zero)
					x86_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "x86", "Lorg/android/du/CpuType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, x86_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/du/CpuType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CpuType); }
		}

		internal CpuType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='CpuType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/du/CpuType;", "")]
		public static global::Org.Android.DU.CpuType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/du/CpuType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.DU.CpuType __ret = global::Java.Lang.Object.GetObject<global::Org.Android.DU.CpuType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.du']/class[@name='CpuType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/du/CpuType;", "")]
		public static global::Org.Android.DU.CpuType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/du/CpuType;");
			return (global::Org.Android.DU.CpuType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.DU.CpuType));
		}

	}
}
