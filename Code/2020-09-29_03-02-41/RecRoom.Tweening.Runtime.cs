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
			[Cpp2IlInjected.Address(RVA = "0x1C2E390", Offset = "0x1C2D790", VA = "0x181C2E390")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3049C10", Offset = "0x3049010", VA = "0x183049C10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3049BC0", Offset = "0x3048FC0", VA = "0x183049BC0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Cubic
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x30486B0", Offset = "0x3047AB0", VA = "0x1830486B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x30486C0", Offset = "0x3047AC0", VA = "0x1830486C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3048660", Offset = "0x3047A60", VA = "0x183048660")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class Quartic
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x3049C90", Offset = "0x3049090", VA = "0x183049C90")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x3049CA0", Offset = "0x30490A0", VA = "0x183049CA0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3049C30", Offset = "0x3049030", VA = "0x183049C30")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Quintic
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x3049D30", Offset = "0x3049130", VA = "0x183049D30")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3049D50", Offset = "0x3049150", VA = "0x183049D50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x3049CD0", Offset = "0x30490D0", VA = "0x183049CD0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3049E00", Offset = "0x3049200", VA = "0x183049E00")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3049E80", Offset = "0x3049280", VA = "0x183049E80")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3049D80", Offset = "0x3049180", VA = "0x183049D80")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3049A60", Offset = "0x3048E60", VA = "0x183049A60")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3049B10", Offset = "0x3048F10", VA = "0x183049B10")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3049910", Offset = "0x3048D10", VA = "0x183049910")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Circular
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3048560", Offset = "0x3047960", VA = "0x183048560")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x30485E0", Offset = "0x30479E0", VA = "0x1830485E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3048490", Offset = "0x3047890", VA = "0x183048490")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class Elastic
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x30496C0", Offset = "0x3048AC0", VA = "0x1830496C0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x30497E0", Offset = "0x3048BE0", VA = "0x1830497E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3049590", Offset = "0x3048990", VA = "0x183049590")]
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
			[Cpp2IlInjected.Address(RVA = "0x30480B0", Offset = "0x30474B0", VA = "0x1830480B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3048130", Offset = "0x3047530", VA = "0x183048130")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3047FB0", Offset = "0x30473B0", VA = "0x183047FB0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3048320", Offset = "0x3047720", VA = "0x183048320")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x30483F0", Offset = "0x30477F0", VA = "0x1830483F0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3048200", Offset = "0x3047600", VA = "0x183048200")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x30486E0", Offset = "0x3047AE0", VA = "0x1830486E0")]
		public static float Ease(float t, Functions function)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A2560", VA = "0x1803A3160")]
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
		[Cpp2IlInjected.Address(RVA = "0x304A0B0", Offset = "0x30494B0", VA = "0x18304A0B0")]
		public TweenInstanceVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3049EF0", Offset = "0x30492F0", VA = "0x183049EF0", Slot = "7")]
		internal override Vector3 GetTargetValue()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3049FF0", Offset = "0x30493F0", VA = "0x183049FF0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3A3100", Offset = "0x3A2500", VA = "0x1803A3100", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3A3100", Offset = "0x3A2500", VA = "0x1803A3100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xFCA430", Offset = "0xFC9830", VA = "0x180FCA430")]
			[DebuggerHidden]
			public <ExecuteTween>d__17(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x3A3160", Offset = "0x3A2560", VA = "0x1803A3160", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x173BD80", Offset = "0x173B180", VA = "0x18173BD80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x173C440", Offset = "0x173B840", VA = "0x18173C440", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x304A8E0", Offset = "0x3049CE0", VA = "0x18304A8E0")]
		public static ITweenInstance TweenLocalScale(Transform target, Vector3 targetScale, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x304A6F0", Offset = "0x3049AF0", VA = "0x18304A6F0")]
		public static ITweenInstance TweenLocalScale(this Behaviour behaviour, Vector3 targetScale, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x304A370", Offset = "0x3049770", VA = "0x18304A370")]
		public static ITweenInstance TweenLocalPosition(Transform target, Vector3 targetPosition, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x304A500", Offset = "0x3049900", VA = "0x18304A500")]
		public static ITweenInstance TweenLocalPosition(this Behaviour behaviour, Vector3 targetPosition, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x304A150", Offset = "0x3049550", VA = "0x18304A150")]
		public static void KillAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1D1DBD0", Offset = "0x1D1CFD0", VA = "0x181D1DBD0")]
		private static ITweenInstance Run<TValue>(Behaviour context, TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB12CD0", Offset = "0xB120D0", VA = "0x180B12CD0")]
		[IteratorStateMachine(typeof(<ExecuteTween>d__17<>))]
		private static IEnumerator<ISchedule> ExecuteTween<TValue>(TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1098E20", Offset = "0x1098220", VA = "0x181098E20")]
		private static void AddTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1099180", Offset = "0x1098580", VA = "0x181099180")]
		private static void RemoveTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x304A320", Offset = "0x3049720", VA = "0x18304A320")]
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
			[Cpp2IlInjected.Address(RVA = "0x6ACD70", Offset = "0x6AC170", VA = "0x1806ACD70")]
			[CompilerGenerated]
			get
			{
				return default(Easing.Functions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x989D30", Offset = "0x989130", VA = "0x180989D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x173BCC0", Offset = "0x173B0C0", VA = "0x18173BCC0")]
		protected TweenInstance(Func<TValue> getter, Action<TValue> setter, TValue targetValue, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x173BB30", Offset = "0x173AF30", VA = "0x18173BB30", Slot = "4")]
		public ITweenInstance SetOnComplete(Action callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x173B650", Offset = "0x173AA50", VA = "0x18173B650", Slot = "6")]
		public void Kill()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B6560", Offset = "0x3B5960", VA = "0x1803B6560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xF7DFB0", Offset = "0xF7D3B0", VA = "0x180F7DFB0")]
		internal void OnUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x173B6F0", Offset = "0x173AAF0", VA = "0x18173B6F0")]
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
