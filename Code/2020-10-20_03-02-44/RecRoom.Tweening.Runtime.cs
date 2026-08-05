using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Tweening
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class Easing
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum Functions
		{
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			Linear,
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			QuadraticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			QuadraticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			QuadraticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			CubicEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			CubicEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			CubicEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			QuarticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			QuarticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			QuarticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			QuinticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			QuinticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			QuinticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			SineEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			SineEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			SineEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			CircularEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			CircularEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			CircularEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			ExponentialEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			ExponentialEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			ExponentialEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			ElasticEaseIn,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			ElasticEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			ElasticEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			BackEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			BackEaseOut,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			BackEaseInOut,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			BounceEaseIn,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			BounceEaseOut,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			BounceEaseInOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public static class Quadratic
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1C51DB0", Offset = "0x1C511B0", VA = "0x181C51DB0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x30AF550", Offset = "0x30AE950", VA = "0x1830AF550")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x30AF500", Offset = "0x30AE900", VA = "0x1830AF500")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Cubic
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x30ADFF0", Offset = "0x30AD3F0", VA = "0x1830ADFF0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x30AE000", Offset = "0x30AD400", VA = "0x1830AE000")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x30ADFA0", Offset = "0x30AD3A0", VA = "0x1830ADFA0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class Quartic
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x30AF5D0", Offset = "0x30AE9D0", VA = "0x1830AF5D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x30AF5E0", Offset = "0x30AE9E0", VA = "0x1830AF5E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x30AF570", Offset = "0x30AE970", VA = "0x1830AF570")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Quintic
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x30AF670", Offset = "0x30AEA70", VA = "0x1830AF670")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x30AF690", Offset = "0x30AEA90", VA = "0x1830AF690")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x30AF610", Offset = "0x30AEA10", VA = "0x1830AF610")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x30AF740", Offset = "0x30AEB40", VA = "0x1830AF740")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x30AF7C0", Offset = "0x30AEBC0", VA = "0x1830AF7C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x30AF6C0", Offset = "0x30AEAC0", VA = "0x1830AF6C0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x30AF3A0", Offset = "0x30AE7A0", VA = "0x1830AF3A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x30AF450", Offset = "0x30AE850", VA = "0x1830AF450")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x30AF250", Offset = "0x30AE650", VA = "0x1830AF250")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Circular
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x30ADEA0", Offset = "0x30AD2A0", VA = "0x1830ADEA0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x30ADF20", Offset = "0x30AD320", VA = "0x1830ADF20")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x30ADDD0", Offset = "0x30AD1D0", VA = "0x1830ADDD0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class Elastic
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x30AF000", Offset = "0x30AE400", VA = "0x1830AF000")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30AF120", Offset = "0x30AE520", VA = "0x1830AF120")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x30AEED0", Offset = "0x30AE2D0", VA = "0x1830AEED0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class Back
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static float s;

			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static float s2;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x30AD9F0", Offset = "0x30ACDF0", VA = "0x1830AD9F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x30ADA70", Offset = "0x30ACE70", VA = "0x1830ADA70")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x30AD8F0", Offset = "0x30ACCF0", VA = "0x1830AD8F0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x30ADC60", Offset = "0x30AD060", VA = "0x1830ADC60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x30ADD30", Offset = "0x30AD130", VA = "0x1830ADD30")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x30ADB40", Offset = "0x30ACF40", VA = "0x1830ADB40")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x30AE020", Offset = "0x30AD420", VA = "0x1830AE020")]
		public static float Ease(float t, Functions function)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3A8210", Offset = "0x3A7610", VA = "0x1803A8210")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ITweenInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ITweenInstance SetOnComplete(Action callback);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IPromise AsPromise();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Kill();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class TweenInstanceVector3 : TweenInstance<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x30AF9F0", Offset = "0x30AEDF0", VA = "0x1830AF9F0")]
		public TweenInstanceVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x30AF830", Offset = "0x30AEC30", VA = "0x1830AF830", Slot = "7")]
		internal override Vector3 GetTargetValue()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x30AF930", Offset = "0x30AED30", VA = "0x1830AF930", Slot = "8")]
		internal override Vector3 Interpolate(Vector3 start, Vector3 end, float time)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class Tween
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class <ExecuteTween>d__17<TValue> : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public TweenInstance<TValue> tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TValue <endValue>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TValue <startValue>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private float <elapsed>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x3A81B0", Offset = "0x3A75B0", VA = "0x1803A81B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x3A81B0", Offset = "0x3A75B0", VA = "0x1803A81B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xF311E0", Offset = "0xF305E0", VA = "0x180F311E0")]
			[DebuggerHidden]
			public <ExecuteTween>d__17(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3A8210", Offset = "0x3A7610", VA = "0x1803A8210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x176EB10", Offset = "0x176DF10", VA = "0x18176EB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x176F1D0", Offset = "0x176E5D0", VA = "0x18176F1D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly HashSet<ITweenInstance> ActiveTweens;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly Dictionary<UnityEngine.Object, HashSet<ITweenInstance>> ActiveTweensByTarget;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x30B0220", Offset = "0x30AF620", VA = "0x1830B0220")]
		public static ITweenInstance TweenLocalScale(Transform target, Vector3 targetScale, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x30B0030", Offset = "0x30AF430", VA = "0x1830B0030")]
		public static ITweenInstance TweenLocalScale(this Behaviour behaviour, Vector3 targetScale, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x30AFCB0", Offset = "0x30AF0B0", VA = "0x1830AFCB0")]
		public static ITweenInstance TweenLocalPosition(Transform target, Vector3 targetPosition, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x30AFE40", Offset = "0x30AF240", VA = "0x1830AFE40")]
		public static ITweenInstance TweenLocalPosition(this Behaviour behaviour, Vector3 targetPosition, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x30AFA90", Offset = "0x30AEE90", VA = "0x1830AFA90")]
		public static void KillAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1C9BC90", Offset = "0x1C9B090", VA = "0x181C9BC90")]
		private static ITweenInstance Run<TValue>(Behaviour context, TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB81BD0", Offset = "0xB80FD0", VA = "0x180B81BD0")]
		[IteratorStateMachine(typeof(<ExecuteTween>d__17<>))]
		private static IEnumerator<ISchedule> ExecuteTween<TValue>(TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1132D10", Offset = "0x1132110", VA = "0x181132D10")]
		private static void AddTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1133070", Offset = "0x1132470", VA = "0x181133070")]
		private static void RemoveTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x30AFC60", Offset = "0x30AF060", VA = "0x1830AFC60")]
		private static void OnSceneLoaded(Scene _, LoadSceneMode __)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal abstract class TweenInstance<TValue> : ITweenInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[CompilerGenerated]
		private Action Updated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[CompilerGenerated]
		private Action Completed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal readonly Func<TValue> Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		internal readonly Action<TValue> Setter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly float Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		protected readonly TValue TargetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected bool IsRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<Action> onCompleteCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal UnityEngine.Object Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal ISchedulerPromise Promise;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal Easing.Functions EaseFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6DD840", Offset = "0x6DCC40", VA = "0x1806DD840")]
			[CompilerGenerated]
			get
			{
				return default(Easing.Functions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9EC580", Offset = "0x9EB980", VA = "0x1809EC580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x176EA50", Offset = "0x176DE50", VA = "0x18176EA50")]
		protected TweenInstance(Func<TValue> getter, Action<TValue> setter, TValue targetValue, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x176E8C0", Offset = "0x176DCC0", VA = "0x18176E8C0", Slot = "4")]
		public ITweenInstance SetOnComplete(Action callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x176E3E0", Offset = "0x176D7E0", VA = "0x18176E3E0", Slot = "6")]
		public void Kill()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3BB390", Offset = "0x3BA790", VA = "0x1803BB390", Slot = "5")]
		public IPromise AsPromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		internal abstract TValue GetTargetValue();

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "8")]
		internal abstract TValue Interpolate(TValue start, TValue end, float time);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xF179C0", Offset = "0xF16DC0", VA = "0x180F179C0")]
		internal void OnUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x176E480", Offset = "0x176D880", VA = "0x18176E480")]
		internal void OnCompleted()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
