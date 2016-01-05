using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Message.Proguard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']"
	[global::Android.Runtime.Register ("com/umeng/message/proguard/aH", DoNotGenerateAcw=true)]
	public abstract partial class AH : global::Java.Lang.Object, global::Java.Util.Concurrent.Locks.ILock {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/message/proguard/aH", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AH); }
		}

		protected AH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/constructor[@name='aH' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AH () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AH)) {
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		protected abstract void A ();

		static Delegate cb_a_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetA_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_a_JLjava_util_concurrent_TimeUnit_ == null)
				cb_a_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_A_JLjava_util_concurrent_TimeUnit_);
			return cb_a_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_A_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='a' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("a", "(JLjava/util/concurrent/TimeUnit;)Z", "GetA_JLjava_util_concurrent_TimeUnit_Handler")]
		protected abstract bool A (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		protected abstract void B ();

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_C);
			return cb_c;
		}

		static bool n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "GetCHandler")]
		protected abstract bool C ();

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static void n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.D ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "GetDHandler")]
		protected abstract void D ();

		static Delegate cb_lock;
#pragma warning disable 0169
		static Delegate GetLockHandler ()
		{
			if (cb_lock == null)
				cb_lock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Lock);
			return cb_lock;
		}

		static void n_Lock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Lock ();
		}
#pragma warning restore 0169

		static IntPtr id_lock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='lock' and count(parameter)=0]"
		[Register ("lock", "()V", "GetLockHandler")]
		public virtual void Lock ()
		{
			if (id_lock == IntPtr.Zero)
				id_lock = JNIEnv.GetMethodID (class_ref, "lock", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_lock);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lock", "()V"));
		}

		static Delegate cb_lockInterruptibly;
#pragma warning disable 0169
		static Delegate GetLockInterruptiblyHandler ()
		{
			if (cb_lockInterruptibly == null)
				cb_lockInterruptibly = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LockInterruptibly);
			return cb_lockInterruptibly;
		}

		static void n_LockInterruptibly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LockInterruptibly ();
		}
#pragma warning restore 0169

		static IntPtr id_lockInterruptibly;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='lockInterruptibly' and count(parameter)=0]"
		[Register ("lockInterruptibly", "()V", "GetLockInterruptiblyHandler")]
		public virtual void LockInterruptibly ()
		{
			if (id_lockInterruptibly == IntPtr.Zero)
				id_lockInterruptibly = JNIEnv.GetMethodID (class_ref, "lockInterruptibly", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_lockInterruptibly);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lockInterruptibly", "()V"));
		}

		static Delegate cb_newCondition;
#pragma warning disable 0169
		static Delegate GetNewConditionHandler ()
		{
			if (cb_newCondition == null)
				cb_newCondition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewCondition);
			return cb_newCondition;
		}

		static IntPtr n_NewCondition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewCondition ());
		}
#pragma warning restore 0169

		static IntPtr id_newCondition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='newCondition' and count(parameter)=0]"
		[Register ("newCondition", "()Ljava/util/concurrent/locks/Condition;", "GetNewConditionHandler")]
		public virtual global::Java.Util.Concurrent.Locks.ICondition NewCondition ()
		{
			if (id_newCondition == IntPtr.Zero)
				id_newCondition = JNIEnv.GetMethodID (class_ref, "newCondition", "()Ljava/util/concurrent/locks/Condition;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Locks.ICondition> (JNIEnv.CallObjectMethod  (Handle, id_newCondition), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Locks.ICondition> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newCondition", "()Ljava/util/concurrent/locks/Condition;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_tryLock;
#pragma warning disable 0169
		static Delegate GetTryLockHandler ()
		{
			if (cb_tryLock == null)
				cb_tryLock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_TryLock);
			return cb_tryLock;
		}

		static bool n_TryLock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TryLock ();
		}
#pragma warning restore 0169

		static IntPtr id_tryLock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='tryLock' and count(parameter)=0]"
		[Register ("tryLock", "()Z", "GetTryLockHandler")]
		public virtual bool TryLock ()
		{
			if (id_tryLock == IntPtr.Zero)
				id_tryLock = JNIEnv.GetMethodID (class_ref, "tryLock", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_tryLock);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryLock", "()Z"));
		}

		static Delegate cb_tryLock_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetTryLock_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_tryLock_JLjava_util_concurrent_TimeUnit_ == null)
				cb_tryLock_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_TryLock_JLjava_util_concurrent_TimeUnit_);
			return cb_tryLock_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_TryLock_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TryLock (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_tryLock_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='tryLock' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("tryLock", "(JLjava/util/concurrent/TimeUnit;)Z", "GetTryLock_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual bool TryLock (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_tryLock_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_tryLock_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_tryLock_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryLock", "(JLjava/util/concurrent/TimeUnit;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Message.Proguard.AH __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Message.Proguard.AH> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		static IntPtr id_unlock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		public virtual void Unlock ()
		{
			if (id_unlock == IntPtr.Zero)
				id_unlock = JNIEnv.GetMethodID (class_ref, "unlock", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unlock);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unlock", "()V"));
		}

	}

	[global::Android.Runtime.Register ("com/umeng/message/proguard/aH", DoNotGenerateAcw=true)]
	internal partial class AHInvoker : AH {

		public AHInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AHInvoker); }
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		protected override void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_a);
		}

		static IntPtr id_a_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='a' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("a", "(JLjava/util/concurrent/TimeUnit;)Z", "GetA_JLjava_util_concurrent_TimeUnit_Handler")]
		protected override bool A (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_a_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_a_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "a", "(JLjava/util/concurrent/TimeUnit;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_a_JLjava_util_concurrent_TimeUnit_, new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		protected override void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_b);
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "GetCHandler")]
		protected override bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Z");
			return JNIEnv.CallBooleanMethod  (Handle, id_c);
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.message.proguard']/class[@name='aH']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "GetDHandler")]
		protected override void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_d);
		}

	}

}
