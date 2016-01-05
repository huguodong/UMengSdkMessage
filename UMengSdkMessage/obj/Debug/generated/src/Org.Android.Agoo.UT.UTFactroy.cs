using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.UT {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.ut']/class[@name='UTFactroy']"
	[global::Android.Runtime.Register ("org/android/agoo/ut/UTFactroy", DoNotGenerateAcw=true)]
	public partial class UTFactroy : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/ut/UTFactroy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTFactroy); }
		}

		protected UTFactroy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static global::Org.Android.Agoo.UT.UTFactroy Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut']/class[@name='UTFactroy']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/android/agoo/ut/UTFactroy;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/android/agoo/ut/UTFactroy;");
				return global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.UT.UTFactroy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_commitEvent_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut']/class[@name='UTFactroy']/method[@name='commitEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String...']]"
		[Register ("commitEvent", "(Landroid/content/Context;Ljava/lang/Object;[Ljava/lang/String;)V", "")]
		public void CommitEvent (global::Android.Content.Context p0, global::Java.Lang.Object p1, params  string[] p2)
		{
			if (id_commitEvent_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_ == IntPtr.Zero)
				id_commitEvent_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "commitEvent", "(Landroid/content/Context;Ljava/lang/Object;[Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JNIEnv.CallVoidMethod  (Handle, id_commitEvent_Landroid_content_Context_Ljava_lang_Object_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getLogger_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.ut']/class[@name='UTFactroy']/method[@name='getLogger' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLogger", "(Landroid/content/Context;)Lorg/android/agoo/ut/UT;", "")]
		public global::Org.Android.Agoo.UT.IUT GetLogger (global::Android.Content.Context p0)
		{
			if (id_getLogger_Landroid_content_Context_ == IntPtr.Zero)
				id_getLogger_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getLogger", "(Landroid/content/Context;)Lorg/android/agoo/ut/UT;");
			global::Org.Android.Agoo.UT.IUT __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.UT.IUT> (JNIEnv.CallObjectMethod  (Handle, id_getLogger_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
