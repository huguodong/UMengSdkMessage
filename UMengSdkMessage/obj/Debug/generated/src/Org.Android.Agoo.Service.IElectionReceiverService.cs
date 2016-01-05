using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Android.Agoo.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']"
	[global::Android.Runtime.Register ("org/android/agoo/service/ElectionReceiverService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ElectionReceiverServiceStub : global::Android.OS.Binder, global::Org.Android.Agoo.Service.IElectionReceiverService {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/android/agoo/service/ElectionReceiverService$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ElectionReceiverServiceStub); }
		}

		protected ElectionReceiverServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']/constructor[@name='ElectionReceiverService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ElectionReceiverServiceStub () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ElectionReceiverServiceStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Service.ElectionReceiverServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.ElectionReceiverServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lorg/android/agoo/service/ElectionReceiverService;", "")]
		public static global::Org.Android.Agoo.Service.IElectionReceiverService AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lorg/android/agoo/service/ElectionReceiverService;");
			global::Org.Android.Agoo.Service.IElectionReceiverService __ret = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IElectionReceiverService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Org.Android.Agoo.Service.ElectionReceiverServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.ElectionReceiverServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			return __ret;
		}

		static Delegate cb_sendElectionResult_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSendElectionResult_Landroid_content_Intent_Handler ()
		{
			if (cb_sendElectionResult_Landroid_content_Intent_ == null)
				cb_sendElectionResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendElectionResult_Landroid_content_Intent_);
			return cb_sendElectionResult_Landroid_content_Intent_;
		}

		static bool n_SendElectionResult_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Service.ElectionReceiverServiceStub __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.ElectionReceiverServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendElectionResult (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']/method[@name='sendElectionResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendElectionResult", "(Landroid/content/Intent;)Z", "GetSendElectionResult_Landroid_content_Intent_Handler")]
		public abstract bool SendElectionResult (global::Android.Content.Intent p0);

	}

	[global::Android.Runtime.Register ("org/android/agoo/service/ElectionReceiverService$Stub", DoNotGenerateAcw=true)]
	internal partial class ElectionReceiverServiceStubInvoker : ElectionReceiverServiceStub {

		public ElectionReceiverServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ElectionReceiverServiceStubInvoker); }
		}

		static IntPtr id_sendElectionResult_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/class[@name='ElectionReceiverService.Stub']/method[@name='sendElectionResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendElectionResult", "(Landroid/content/Intent;)Z", "GetSendElectionResult_Landroid_content_Intent_Handler")]
		public override bool SendElectionResult (global::Android.Content.Intent p0)
		{
			if (id_sendElectionResult_Landroid_content_Intent_ == IntPtr.Zero)
				id_sendElectionResult_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "sendElectionResult", "(Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_sendElectionResult_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='ElectionReceiverService']"
	[Register ("org/android/agoo/service/ElectionReceiverService", "", "Org.Android.Agoo.Service.IElectionReceiverServiceInvoker")]
	public partial interface IElectionReceiverService : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.android.agoo.service']/interface[@name='ElectionReceiverService']/method[@name='sendElectionResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendElectionResult", "(Landroid/content/Intent;)Z", "GetSendElectionResult_Landroid_content_Intent_Handler:Org.Android.Agoo.Service.IElectionReceiverServiceInvoker, UMengSdkMessage")]
		bool SendElectionResult (global::Android.Content.Intent p0);

	}

	[global::Android.Runtime.Register ("org/android/agoo/service/ElectionReceiverService", DoNotGenerateAcw=true)]
	internal class IElectionReceiverServiceInvoker : global::Java.Lang.Object, IElectionReceiverService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/android/agoo/service/ElectionReceiverService");
		IntPtr class_ref;

		public static IElectionReceiverService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IElectionReceiverService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.android.agoo.service.ElectionReceiverService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IElectionReceiverServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IElectionReceiverServiceInvoker); }
		}

		static Delegate cb_sendElectionResult_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSendElectionResult_Landroid_content_Intent_Handler ()
		{
			if (cb_sendElectionResult_Landroid_content_Intent_ == null)
				cb_sendElectionResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendElectionResult_Landroid_content_Intent_);
			return cb_sendElectionResult_Landroid_content_Intent_;
		}

		static bool n_SendElectionResult_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Android.Agoo.Service.IElectionReceiverService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IElectionReceiverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendElectionResult (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendElectionResult_Landroid_content_Intent_;
		public bool SendElectionResult (global::Android.Content.Intent p0)
		{
			if (id_sendElectionResult_Landroid_content_Intent_ == IntPtr.Zero)
				id_sendElectionResult_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "sendElectionResult", "(Landroid/content/Intent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_sendElectionResult_Landroid_content_Intent_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Android.Agoo.Service.IElectionReceiverService __this = global::Java.Lang.Object.GetObject<global::Org.Android.Agoo.Service.IElectionReceiverService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
