using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Spdy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']"
	[Register ("org/android/spdy/Intenalcb", "", "Org.Android.Spdy.IIntenalcbInvoker")]
	public partial interface IIntenalcb : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyCustomControlFrameRecvCallback' and count(parameter)=7 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='byte[]']]"
		[Register ("spdyCustomControlFrameRecvCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;IIII[B)V", "GetSpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayBHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyCustomControlFrameRecvCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3, int p4, int p5, byte[] p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyDataChunkRecvCB' and count(parameter)=6 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("spdyDataChunkRecvCB", "(Lorg/android/spdy/SpdySession;ZJ[BII)V", "GetSpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBIIHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyDataChunkRecvCB (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, byte[] p3, int p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyDataRecvCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("spdyDataRecvCallback", "(Lorg/android/spdy/SpdySession;ZJII)V", "GetSpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJIIHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyDataRecvCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyDataSendCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='boolean'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("spdyDataSendCallback", "(Lorg/android/spdy/SpdySession;ZJII)V", "GetSpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJIIHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyDataSendCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, int p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyOnStreamResponse' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='int']]"
		[Register ("spdyOnStreamResponse", "(Lorg/android/spdy/SpdySession;JLjava/util/Map;I)V", "GetSpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_IHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyOnStreamResponse (global::Org.Android.Spdy.SpdySession p0, long p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyPingRecvCallback' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdyPingRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V", "GetSpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyRequestRecvCallback' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("spdyRequestRecvCallback", "(Lorg/android/spdy/SpdySession;JI)V", "GetSpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JIHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyRequestRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdySessionCloseCallback' and count(parameter)=4 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.android.spdy.SuperviseConnectInfo'] and parameter[4][@type='int']]"
		[Register ("spdySessionCloseCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;Lorg/android/spdy/SuperviseConnectInfo;I)V", "GetSpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_IHandler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdySessionCloseCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.SuperviseConnectInfo p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdySessionConnectCB' and count(parameter)=2 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='org.android.spdy.SuperviseConnectInfo']]"
		[Register ("spdySessionConnectCB", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SuperviseConnectInfo;)V", "GetSpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_Handler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdySessionConnectCB (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SuperviseConnectInfo p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdySessionFailedError' and count(parameter)=3 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("spdySessionFailedError", "(Lorg/android/spdy/SpdySession;ILjava/lang/Object;)V", "GetSpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_Handler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdySessionFailedError (global::Org.Android.Spdy.SpdySession p0, int p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.spdy']/interface[@name='Intenalcb']/method[@name='spdyStreamCloseCallback' and count(parameter)=5 and parameter[1][@type='org.android.spdy.SpdySession'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.android.spdy.SuperviseData']]"
		[Register ("spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JIILorg/android/spdy/SuperviseData;)V", "GetSpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_Handler:Org.Android.Spdy.IIntenalcbInvoker, UMengSdkMessage")]
		void SpdyStreamCloseCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2, int p3, global::Org.Android.Spdy.SuperviseData p4);

	}

	[global::Android.Runtime.Register ("org/android/spdy/Intenalcb", DoNotGenerateAcw=true)]
	internal class IIntenalcbInvoker : global::Java.Lang.Object, IIntenalcb {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/spdy/Intenalcb");
		IntPtr class_ref;

		public static IIntenalcb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntenalcb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.spdy.Intenalcb"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntenalcbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IIntenalcbInvoker); }
		}

		static Delegate cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
#pragma warning disable 0169
		static Delegate GetSpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayBHandler ()
		{
			if (cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB == null)
				cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_SpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB);
			return cb_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
		}

		static void n_SpdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p6 = (byte[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SpdyCustomControlFrameRecvCallback (p0, p1, p2, p3, p4, p5, p6);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
		}
#pragma warning restore 0169

		IntPtr id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB;
		public void SpdyCustomControlFrameRecvCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, int p2, int p3, int p4, int p5, byte[] p6)
		{
			if (id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB == IntPtr.Zero)
				id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB = JNIEnv.GetMethodID (class_ref, "spdyCustomControlFrameRecvCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;IIII[B)V");
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JNIEnv.CallVoidMethod (Handle, id_spdyCustomControlFrameRecvCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_IIIIarrayB, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (native_p6));
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII;
#pragma warning disable 0169
		static Delegate GetSpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBIIHandler ()
		{
			if (cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII == null)
				cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, long, IntPtr, int, int>) n_SpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII);
			return cb_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII;
		}

		static void n_SpdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, long p2, IntPtr native_p3, int p4, int p5)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SpdyDataChunkRecvCB (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII;
		public void SpdyDataChunkRecvCB (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, byte[] p3, int p4, int p5)
		{
			if (id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII == IntPtr.Zero)
				id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII = JNIEnv.GetMethodID (class_ref, "spdyDataChunkRecvCB", "(Lorg/android/spdy/SpdySession;ZJ[BII)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_spdyDataChunkRecvCB_Lorg_android_spdy_SpdySession_ZJarrayBII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4), new JValue (p5));
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII;
#pragma warning disable 0169
		static Delegate GetSpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJIIHandler ()
		{
			if (cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII == null)
				cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, long, int, int>) n_SpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII);
			return cb_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII;
		}

		static void n_SpdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, long p2, int p3, int p4)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SpdyDataRecvCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII;
		public void SpdyDataRecvCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, int p4)
		{
			if (id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII == IntPtr.Zero)
				id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII = JNIEnv.GetMethodID (class_ref, "spdyDataRecvCallback", "(Lorg/android/spdy/SpdySession;ZJII)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyDataRecvCallback_Lorg_android_spdy_SpdySession_ZJII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII;
#pragma warning disable 0169
		static Delegate GetSpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJIIHandler ()
		{
			if (cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII == null)
				cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, long, int, int>) n_SpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII);
			return cb_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII;
		}

		static void n_SpdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, long p2, int p3, int p4)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SpdyDataSendCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII;
		public void SpdyDataSendCallback (global::Org.Android.Spdy.SpdySession p0, bool p1, long p2, int p3, int p4)
		{
			if (id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII == IntPtr.Zero)
				id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII = JNIEnv.GetMethodID (class_ref, "spdyDataSendCallback", "(Lorg/android/spdy/SpdySession;ZJII)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyDataSendCallback_Lorg_android_spdy_SpdySession_ZJII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static Delegate cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I;
#pragma warning disable 0169
		static Delegate GetSpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_IHandler ()
		{
			if (cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I == null)
				cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, int>) n_SpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I);
			return cb_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I;
		}

		static void n_SpdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, int p3)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdyOnStreamResponse (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I;
		public void SpdyOnStreamResponse (global::Org.Android.Spdy.SpdySession p0, long p1, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p2, int p3)
		{
			if (id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I == IntPtr.Zero)
				id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I = JNIEnv.GetMethodID (class_ref, "spdyOnStreamResponse", "(Lorg/android/spdy/SpdySession;JLjava/util/Map;I)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p2);
			JNIEnv.CallVoidMethod (Handle, id_spdyOnStreamResponse_Lorg_android_spdy_SpdySession_JLjava_util_Map_I, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_Handler ()
		{
			if (cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == null)
				cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_);
			return cb_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		}

		static void n_SpdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdyPingRecvCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_;
		public void SpdyPingRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, global::Java.Lang.Object p2)
		{
			if (id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ == IntPtr.Zero)
				id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdyPingRecvCallback", "(Lorg/android/spdy/SpdySession;JLjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyPingRecvCallback_Lorg_android_spdy_SpdySession_JLjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI;
#pragma warning disable 0169
		static Delegate GetSpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JIHandler ()
		{
			if (cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI == null)
				cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int>) n_SpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI);
			return cb_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI;
		}

		static void n_SpdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SpdyRequestRecvCallback (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI;
		public void SpdyRequestRecvCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2)
		{
			if (id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI == IntPtr.Zero)
				id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI = JNIEnv.GetMethodID (class_ref, "spdyRequestRecvCallback", "(Lorg/android/spdy/SpdySession;JI)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyRequestRecvCallback_Lorg_android_spdy_SpdySession_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
#pragma warning disable 0169
		static Delegate GetSpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_IHandler ()
		{
			if (cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I == null)
				cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I);
			return cb_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
		}

		static void n_SpdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseConnectInfo p2 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseConnectInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionCloseCallback (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I;
		public void SpdySessionCloseCallback (global::Org.Android.Spdy.SpdySession p0, global::Java.Lang.Object p1, global::Org.Android.Spdy.SuperviseConnectInfo p2, int p3)
		{
			if (id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I == IntPtr.Zero)
				id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I = JNIEnv.GetMethodID (class_ref, "spdySessionCloseCallback", "(Lorg/android/spdy/SpdySession;Ljava/lang/Object;Lorg/android/spdy/SuperviseConnectInfo;I)V");
			JNIEnv.CallVoidMethod (Handle, id_spdySessionCloseCallback_Lorg_android_spdy_SpdySession_Ljava_lang_Object_Lorg_android_spdy_SuperviseConnectInfo_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
#pragma warning disable 0169
		static Delegate GetSpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_Handler ()
		{
			if (cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ == null)
				cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_);
			return cb_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
		}

		static void n_SpdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseConnectInfo p1 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseConnectInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionConnectCB (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_;
		public void SpdySessionConnectCB (global::Org.Android.Spdy.SpdySession p0, global::Org.Android.Spdy.SuperviseConnectInfo p1)
		{
			if (id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ == IntPtr.Zero)
				id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_ = JNIEnv.GetMethodID (class_ref, "spdySessionConnectCB", "(Lorg/android/spdy/SpdySession;Lorg/android/spdy/SuperviseConnectInfo;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdySessionConnectCB_Lorg_android_spdy_SpdySession_Lorg_android_spdy_SuperviseConnectInfo_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_Handler ()
		{
			if (cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ == null)
				cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_);
			return cb_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
		}

		static void n_SpdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SpdySessionFailedError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_;
		public void SpdySessionFailedError (global::Org.Android.Spdy.SpdySession p0, int p1, global::Java.Lang.Object p2)
		{
			if (id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ == IntPtr.Zero)
				id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "spdySessionFailedError", "(Lorg/android/spdy/SpdySession;ILjava/lang/Object;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdySessionFailedError_Lorg_android_spdy_SpdySession_ILjava_lang_Object_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_;
#pragma warning disable 0169
		static Delegate GetSpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_Handler ()
		{
			if (cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_ == null)
				cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int, int, IntPtr>) n_SpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_);
			return cb_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_;
		}

		static void n_SpdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, int p3, IntPtr native_p4)
		{
			global::Org.Android.Spdy.IIntenalcb __this = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.IIntenalcb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SpdySession p0 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SpdySession> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Android.Spdy.SuperviseData p4 = global::Java.Lang.Object.GetObject<global::Org.Android.Spdy.SuperviseData> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SpdyStreamCloseCallback (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_;
		public void SpdyStreamCloseCallback (global::Org.Android.Spdy.SpdySession p0, long p1, int p2, int p3, global::Org.Android.Spdy.SuperviseData p4)
		{
			if (id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_ == IntPtr.Zero)
				id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_ = JNIEnv.GetMethodID (class_ref, "spdyStreamCloseCallback", "(Lorg/android/spdy/SpdySession;JIILorg/android/spdy/SuperviseData;)V");
			JNIEnv.CallVoidMethod (Handle, id_spdyStreamCloseCallback_Lorg_android_spdy_SpdySession_JIILorg_android_spdy_SuperviseData_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

	}

}
