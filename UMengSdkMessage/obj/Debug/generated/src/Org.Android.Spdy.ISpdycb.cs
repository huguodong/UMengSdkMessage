using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']"
	[Register ("org/android/spdy/Spdycb", "", "Org.Android.Spdy.ISpdycbInvoker")]
	public partial interface ISpdycb : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']/method[@name='spdyDataChunkRecvCB' and count(parameter)=6 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.Object']]"
		[Register ("spdyDataChunkRecvCB", "(Lorg/android/spdy/SpdySession;ZJ[BILjava/lang/Object;)V", "GetSpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_Handler:Org.Android.Spdy.ISpdycbInvoker, UMengSdkMessage")]
		void SpdyDataChunkRecvCB (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, byte[] p3, int p4, global::Java.Lang.Object p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']/method[@name='spdyDataRecvCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object']]"
		[Register ("spdyDataRecvCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V", "GetSpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_Handler:Org.Android.Spdy.ISpdycbInvoker, UMengSdkMessage")]
		void SpdyDataRecvCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, global::Java.Lang.Object p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']/method[@name='spdyDataSendCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.Object']]"
		[Register ("spdyDataSendCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V", "GetSpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_Handler:Org.Android.Spdy.ISpdycbInvoker, UMengSdkMessage")]
		void SpdyDataSendCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, global::Java.Lang.Object p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']/method[@name='spdyOnStreamResponse' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='java.lang.Object']]"
		[Register ("spdyOnStreamResponse", "(Lorg/android/spdy/SpdySession;JLjava/util/Map;Ljava/lang/Object;)V", "GetSpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_Handler:Org.Android.Spdy.ISpdycbInvoker, UMengSdkMessage")]
		void SpdyOnStreamResponse (global::Org.Android.Spdy.SpdySession p0, long p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2, global::Java.Lang.Object p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']/method[@name='spdyRequestRecvCallback' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdyRequestRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V", "GetSpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler:Org.Android.Spdy.ISpdycbInvoker, UMengSdkMessage")]
		void SpdyRequestRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Spdycb']/method[@name='spdyStreamCloseCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='org.android.spdy.SuperviseData']]"
		[Register ("spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JILjava/lang/Object;Lorg/android/spdy/SuperviseData;)V", "GetSpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_Handler:Org.Android.Spdy.ISpdycbInvoker, UMengSdkMessage")]
		void SpdyStreamCloseCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2, global::Java.Lang.Object p3, global::Org.Android.Spdy.SuperviseData p4);

	}

	[global::Android.Runtime.Register ("org/android/spdy/Spdycb", DoNotGenerateAcw=true)]
	internal class ISpdycbInvoker : global::Java.Lang.Object, ISpdycb {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/Spdycb");
		IntPtr class_ref;

		public static ISpdycb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISpdycb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.Spdycb"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISpdycbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISpdycbInvoker); }
		}

		static Delegate cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_Handler ()
		{
			if (cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ == null)
				cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, long, IntPtr, int, IntPtr>) n_SpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_);
			return cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_;
		}

		static void n_SpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, long p2, IntPtr native_p3, int p4, IntPtr native_p5)
		{
			global::Org.Android.Spdy.ISpdycb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Lang.Object p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SpdyDataChunkRecvCB (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_;
		public void SpdyDataChunkRecvCB (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, byte[] p3, int p4, global::Java.Lang.Object p5)
		{
			if (id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ == IntPtr.Zero)
				id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyDataChunkRecvCB", "(Lorg/android/spdy/SpdySession;ZJ[BILjava/lang/Object;)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (p5));
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_Handler ()
		{
			if (cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ == null)
				cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, long, int, IntPtr>) n_SpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_);
			return cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
		}

		static void n_SpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, long p2, int p3, IntPtr native_p4)
		{
			global::Org.Android.Spdy.ISpdycb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SpdyDataRecvCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
		public void SpdyDataRecvCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, global::Java.Lang.Object p4)
		{
			if (id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ == IntPtr.Zero)
				id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyDataRecvCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_Handler ()
		{
			if (cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ == null)
				cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, long, int, IntPtr>) n_SpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_);
			return cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
		}

		static void n_SpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, long p2, int p3, IntPtr native_p4)
		{
			global::Org.Android.Spdy.ISpdycb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SpdyDataSendCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_;
		public void SpdyDataSendCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, global::Java.Lang.Object p4)
		{
			if (id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ == IntPtr.Zero)
				id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyDataSendCallback", "(Lorg/android/spdy/SpdySession;ZJILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_Handler ()
		{
			if (cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ == null)
				cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_SpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_);
			return cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_;
		}

		static void n_SpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Android.Spdy.ISpdycb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SpdyOnStreamResponse (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_;
		public void SpdyOnStreamResponse (global::Org.Android.Spdy.SpdySession p0, long p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2, global::Java.Lang.Object p3)
		{
			if (id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ == IntPtr.Zero)
				id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyOnStreamResponse", "(Lorg/android/spdy/SpdySession;JLjava/util/Map;Ljava/lang/Object;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod (Handle, id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_Ljava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler ()
		{
			if (cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == null)
				cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_);
			return cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		}

		static void n_SpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.ISpdycb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdyRequestRecvCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		public void SpdyRequestRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2)
		{
			if (id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == IntPtr.Zero)
				id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyRequestRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_;
#pragma warning disable 0169
		static Delegate GetSpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_Handler ()
		{
			if (cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ == null)
				cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int, IntPtr, IntPtr>) n_SpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_);
			return cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_;
		}

		static void n_SpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Android.Spdy.ISpdycb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.ISpdycb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseData p4 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseData> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SpdyStreamCloseCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_;
		public void SpdyStreamCloseCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2, global::Java.Lang.Object p3, global::Org.Android.Spdy.SuperviseData p4)
		{
			if (id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ == IntPtr.Zero)
				id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_ = JNIEnv.GetMethodID (class_ref, "spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JILjava/lang/Object;Lorg/android/spdy/SuperviseData;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JILjava_lang_Object_Lorg_android_spdy_SuperviseData_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}

}
