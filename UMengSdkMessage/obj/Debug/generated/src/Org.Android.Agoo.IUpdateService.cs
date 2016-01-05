using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo']/interface[@name='IUpdateService']"
	[Register ("org/android/agoo/IUpdateService", "", "Org.Android.Agoo.IUpdateServiceInvoker")]
	public partial interface IUpdateService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo']/interface[@name='IUpdateService']/method[@name='checkUpdateJar' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkUpdateJar", "(ILjava/lang/String;)Z", "GetCheckUpdateJar_ILjava_lang_String_Handler:Org.Android.Agoo.IUpdateServiceInvoker, UMengSdkMessage")]
		bool CheckUpdateJar (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo']/interface[@name='IUpdateService']/method[@name='downloadUpdate' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("downloadUpdate", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetDownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler:Org.Android.Agoo.IUpdateServiceInvoker, UMengSdkMessage")]
		void DownloadUpdate (global::Android.Content.Context p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("org/android/agoo/IUpdateService", DoNotGenerateAcw=true)]
	internal class IUpdateServiceInvoker : global::Java.Lang.Object, IUpdateService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/IUpdateService");
		IntPtr class_ref;

		public static IUpdateService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUpdateService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.IUpdateService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUpdateServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IUpdateServiceInvoker); }
		}

		static Delegate cb_checkUpdateJar_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckUpdateJar_ILjava_lang_String_Handler ()
		{
			if (cb_checkUpdateJar_ILjava_lang_String_ == null)
				cb_checkUpdateJar_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_CheckUpdateJar_ILjava_lang_String_);
			return cb_checkUpdateJar_ILjava_lang_String_;
		}

		static bool n_CheckUpdateJar_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Android.Agoo.IUpdateService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IUpdateService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckUpdateJar (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_checkUpdateJar_ILjava_lang_String_;
		public bool CheckUpdateJar (int p0, string p1)
		{
			if (id_checkUpdateJar_ILjava_lang_String_ == IntPtr.Zero)
				id_checkUpdateJar_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkUpdateJar", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_checkUpdateJar_ILjava_lang_String_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DownloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Android.Agoo.IUpdateService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.IUpdateService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DownloadUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		public void DownloadUpdate (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "downloadUpdate", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JNIEnv.CallVoidMethod (Handle, id_downloadUpdate_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
