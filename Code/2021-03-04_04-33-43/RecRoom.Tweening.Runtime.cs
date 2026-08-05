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
			[Cpp2IlInjected.Address(RVA = "0x1D81170", Offset = "0x1D7F770", VA = "0x181D81170")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3300830", Offset = "0x32FEE30", VA = "0x183300830")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x33007E0", Offset = "0x32FEDE0", VA = "0x1833007E0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Cubic
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x32FF2D0", Offset = "0x32FD8D0", VA = "0x1832FF2D0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x32FF2E0", Offset = "0x32FD8E0", VA = "0x1832FF2E0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x32FF280", Offset = "0x32FD880", VA = "0x1832FF280")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class Quartic
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x33008B0", Offset = "0x32FEEB0", VA = "0x1833008B0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x33008C0", Offset = "0x32FEEC0", VA = "0x1833008C0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x3300850", Offset = "0x32FEE50", VA = "0x183300850")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Quintic
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x3300950", Offset = "0x32FEF50", VA = "0x183300950")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x3300970", Offset = "0x32FEF70", VA = "0x183300970")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x33008F0", Offset = "0x32FEEF0", VA = "0x1833008F0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3300A20", Offset = "0x32FF020", VA = "0x183300A20")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3300AA0", Offset = "0x32FF0A0", VA = "0x183300AA0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x33009A0", Offset = "0x32FEFA0", VA = "0x1833009A0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3300680", Offset = "0x32FEC80", VA = "0x183300680")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3300730", Offset = "0x32FED30", VA = "0x183300730")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3300530", Offset = "0x32FEB30", VA = "0x183300530")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Circular
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x32FF180", Offset = "0x32FD780", VA = "0x1832FF180")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x32FF200", Offset = "0x32FD800", VA = "0x1832FF200")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x32FF0B0", Offset = "0x32FD6B0", VA = "0x1832FF0B0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class Elastic
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x33002E0", Offset = "0x32FE8E0", VA = "0x1833002E0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3300400", Offset = "0x32FEA00", VA = "0x183300400")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x33001B0", Offset = "0x32FE7B0", VA = "0x1833001B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32FECD0", Offset = "0x32FD2D0", VA = "0x1832FECD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x32FED50", Offset = "0x32FD350", VA = "0x1832FED50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x32FEBD0", Offset = "0x32FD1D0", VA = "0x1832FEBD0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x32FEF40", Offset = "0x32FD540", VA = "0x1832FEF40")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x32FF010", Offset = "0x32FD610", VA = "0x1832FF010")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x32FEE20", Offset = "0x32FD420", VA = "0x1832FEE20")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x32FF300", Offset = "0x32FD900", VA = "0x1832FF300")]
		public static float Ease(float t, Functions function)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3DAED0", Offset = "0x3D94D0", VA = "0x1803DAED0")]
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
		ICancelablePromise AsPromise();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Kill();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class TweenInstanceFloat : TweenInstance<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3300BF0", Offset = "0x32FF1F0", VA = "0x183300BF0")]
		public TweenInstanceFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3300B10", Offset = "0x32FF110", VA = "0x183300B10", Slot = "7")]
		internal override float GetTargetValue()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3300B70", Offset = "0x32FF170", VA = "0x183300B70", Slot = "8")]
		internal override float Interpolate(float start, float end, float time)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class TweenInstanceVector3 : TweenInstance<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3300E20", Offset = "0x32FF420", VA = "0x183300E20")]
		public TweenInstanceVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3300C60", Offset = "0x32FF260", VA = "0x183300C60", Slot = "7")]
		internal override Vector3 GetTargetValue()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3300D60", Offset = "0x32FF360", VA = "0x183300D60", Slot = "8")]
		internal override Vector3 Interpolate(Vector3 start, Vector3 end, float time)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class Tween
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
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
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x3CE670", Offset = "0x3CCC70", VA = "0x1803CE670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x3CE670", Offset = "0x3CCC70", VA = "0x1803CE670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF4AC60", Offset = "0xF49260", VA = "0x180F4AC60")]
			[DebuggerHidden]
			public <ExecuteTween>d__17(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3DAED0", Offset = "0x3D94D0", VA = "0x1803DAED0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1924880", Offset = "0x1922E80", VA = "0x181924880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1924F40", Offset = "0x1923540", VA = "0x181924F40", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x33010E0", Offset = "0x32FF6E0", VA = "0x1833010E0")]
		public static ITweenInstance TweenFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3301740", Offset = "0x32FFD40", VA = "0x183301740")]
		public static ITweenInstance TweenLocalScale(Transform target, Vector3 targetScale, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3301550", Offset = "0x32FFB50", VA = "0x183301550")]
		public static ITweenInstance TweenLocalScale(this Behaviour behaviour, Vector3 targetScale, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x33011D0", Offset = "0x32FF7D0", VA = "0x1833011D0")]
		public static ITweenInstance TweenLocalPosition(Transform target, Vector3 targetPosition, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3301360", Offset = "0x32FF960", VA = "0x183301360")]
		public static ITweenInstance TweenLocalPosition(this Behaviour behaviour, Vector3 targetPosition, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3300EC0", Offset = "0x32FF4C0", VA = "0x183300EC0")]
		public static void KillAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1852ED0", Offset = "0x18514D0", VA = "0x181852ED0")]
		private static ITweenInstance Run<TValue>(Behaviour context, TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB7E1D0", Offset = "0xB7C7D0", VA = "0x180B7E1D0")]
		[IteratorStateMachine(typeof(<ExecuteTween>d__17<>))]
		private static IEnumerator<ISchedule> ExecuteTween<TValue>(TweenInstance<TValue> tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x109C240", Offset = "0x109A840", VA = "0x18109C240")]
		private static void AddTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x109C750", Offset = "0x109AD50", VA = "0x18109C750")]
		private static void RemoveTween<TValue>(TweenInstance<TValue> tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3301090", Offset = "0x32FF690", VA = "0x183301090")]
		private static void OnSceneLoaded(Scene _, LoadSceneMode __)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x76F0F0", Offset = "0x76D6F0", VA = "0x18076F0F0")]
			[CompilerGenerated]
			get
			{
				return default(Easing.Functions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9E86E0", Offset = "0x9E6CE0", VA = "0x1809E86E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x19244B0", Offset = "0x1922AB0", VA = "0x1819244B0")]
		protected TweenInstance(Func<TValue> getter, Action<TValue> setter, TValue targetValue, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1924200", Offset = "0x1922800", VA = "0x181924200", Slot = "4")]
		public ITweenInstance SetOnComplete(Action callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1923AB0", Offset = "0x19220B0", VA = "0x181923AB0", Slot = "6")]
		public void Kill()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3700", VA = "0x1803F5100", Slot = "5")]
		public ICancelablePromise AsPromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		internal abstract TValue GetTargetValue();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		internal abstract TValue Interpolate(TValue start, TValue end, float time);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF70E90", Offset = "0xF6F490", VA = "0x180F70E90")]
		internal void OnUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1923BA0", Offset = "0x19221A0", VA = "0x181923BA0")]
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
