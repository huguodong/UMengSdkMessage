using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']"
	[global::Android.Runtime.Register ("org/android/agoo/client/UT", DoNotGenerateAcw=true)]
	public abstract partial class UT : global::Java.Lang.Enum {


		static IntPtr UCWEB_UT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/field[@name='UCWEB_UT']"
		[Register ("UCWEB_UT")]
		public static global::Org.Android.Agoo.Client.UT UcwebUt {
			get {
				if (UCWEB_UT_jfieldId == IntPtr.Zero)
					UCWEB_UT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UCWEB_UT", "Lorg/android/agoo/client/UT;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UCWEB_UT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.UT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UCWEB_UT_jfieldId == IntPtr.Zero)
					UCWEB_UT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UCWEB_UT", "Lorg/android/agoo/client/UT;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UCWEB_UT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr UMENG_UT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/field[@name='UMENG_UT']"
		[Register ("UMENG_UT")]
		public static global::Org.Android.Agoo.Client.UT UmengUt {
			get {
				if (UMENG_UT_jfieldId == IntPtr.Zero)
					UMENG_UT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UMENG_UT", "Lorg/android/agoo/client/UT;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UMENG_UT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.UT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UMENG_UT_jfieldId == IntPtr.Zero)
					UMENG_UT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UMENG_UT", "Lorg/android/agoo/client/UT;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UMENG_UT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr USERTRUCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/field[@name='USERTRUCE']"
		[Register ("USERTRUCE")]
		public static global::Org.Android.Agoo.Client.UT Usertruce {
			get {
				if (USERTRUCE_jfieldId == IntPtr.Zero)
					USERTRUCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USERTRUCE", "Lorg/android/agoo/client/UT;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USERTRUCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.UT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USERTRUCE_jfieldId == IntPtr.Zero)
					USERTRUCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USERTRUCE", "Lorg/android/agoo/client/UT;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, USERTRUCE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/client/UT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UT); }
		}

		protected UT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getUTClassName;
#pragma warning disable 0169
		static Delegate GetGetUTClassNameHandler ()
		{
			if (cb_getUTClassName == null)
				cb_getUTClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTClassName);
			return cb_getUTClassName;
		}

		static IntPtr n_GetUTClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Client.UT __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.UT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UTClassName);
		}
#pragma warning restore 0169

		public abstract string UTClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/method[@name='getUTClassName' and count(parameter)=0]"
			[Register ("getUTClassName", "()Ljava/lang/String;", "GetGetUTClassNameHandler")] get;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/android/agoo/client/UT;", "")]
		public static global::Org.Android.Agoo.Client.UT ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/android/agoo/client/UT;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Android.Agoo.Client.UT __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Client.UT> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/android/agoo/client/UT;", "")]
		public static global::Org.Android.Agoo.Client.UT[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/android/agoo/client/UT;");
			return (global::Org.Android.Agoo.Client.UT[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Android.Agoo.Client.UT));
		}

	}

	[global::Android.Runtime.Register ("org/android/agoo/client/UT", DoNotGenerateAcw=true)]
	internal partial class UTInvoker : UT {

		public UTInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTInvoker); }
		}

		static IntPtr id_getUTClassName;
		public override string UTClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.client']/class[@name='UT']/method[@name='getUTClassName' and count(parameter)=0]"
			[Register ("getUTClassName", "()Ljava/lang/String;", "GetGetUTClassNameHandler")]
			get {
				if (id_getUTClassName == IntPtr.Zero)
					id_getUTClassName = JNIEnv.GetMethodID (class_ref, "getUTClassName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUTClassName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
