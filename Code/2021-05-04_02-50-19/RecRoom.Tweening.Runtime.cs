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
			[Cpp2IlInjected.Address(RVA = "0x22912A0", Offset = "0x22904A0", VA = "0x1822912A0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x351BC50", Offset = "0x351AE50", VA = "0x18351BC50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x351BC00", Offset = "0x351AE00", VA = "0x18351BC00")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Cubic
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x351A6F0", Offset = "0x35198F0", VA = "0x18351A6F0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x351A700", Offset = "0x3519900", VA = "0x18351A700")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x351A6A0", Offset = "0x35198A0", VA = "0x18351A6A0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class Quartic
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x351BCD0", Offset = "0x351AED0", VA = "0x18351BCD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x351BCE0", Offset = "0x351AEE0", VA = "0x18351BCE0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x351BC70", Offset = "0x351AE70", VA = "0x18351BC70")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Quintic
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x351BD70", Offset = "0x351AF70", VA = "0x18351BD70")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x351BD90", Offset = "0x351AF90", VA = "0x18351BD90")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x351BD10", Offset = "0x351AF10", VA = "0x18351BD10")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class Sine
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x351BE40", Offset = "0x351B040", VA = "0x18351BE40")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x351BEC0", Offset = "0x351B0C0", VA = "0x18351BEC0")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x351BDC0", Offset = "0x351AFC0", VA = "0x18351BDC0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Exponential
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x351BAA0", Offset = "0x351ACA0", VA = "0x18351BAA0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x351BB50", Offset = "0x351AD50", VA = "0x18351BB50")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x351B950", Offset = "0x351AB50", VA = "0x18351B950")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Circular
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x351A480", Offset = "0x3519680", VA = "0x18351A480")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x351A500", Offset = "0x3519700", VA = "0x18351A500")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x351A3B0", Offset = "0x35195B0", VA = "0x18351A3B0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class Elastic
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x351B700", Offset = "0x351A900", VA = "0x18351B700")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x351B820", Offset = "0x351AA20", VA = "0x18351B820")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x351B5D0", Offset = "0x351A7D0", VA = "0x18351B5D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3519FD0", Offset = "0x35191D0", VA = "0x183519FD0")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x351A050", Offset = "0x3519250", VA = "0x18351A050")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3519ED0", Offset = "0x35190D0", VA = "0x183519ED0")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class Bounce
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x351A240", Offset = "0x3519440", VA = "0x18351A240")]
			public static float In(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x351A310", Offset = "0x3519510", VA = "0x18351A310")]
			public static float Out(float t)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x351A120", Offset = "0x3519320", VA = "0x18351A120")]
			public static float InOut(float t)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x351A720", Offset = "0x3519920", VA = "0x18351A720")]
		public static float Ease(float t, Functions function)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3DF820", Offset = "0x3DEA20", VA = "0x1803DF820")]
		public static float Linear(float t)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ITweenBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ITweenBase SetOnComplete(Action callback, bool invokeOnCancel = false);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ITweenBase SetOnCancel(Action callback);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IPromise AsPromise();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool Advance(float dt);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Cancel();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ITweenInstance : ITweenBase
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ITweenSequence : ITweenBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ITweenSequence AddTween(ITweenBase tween);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ITweenSequence AddTween(Func<ITweenBase> tweenFactory);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ITweenSequence AddTweens(IEnumerable<ITweenBase> tweens);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ITweenSequence AddTweens(params ITweenBase[] tweens);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ITweenSequence AddDelay(float seconds);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class CompletedTween : TweenInstance
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x351A580", Offset = "0x3519780", VA = "0x18351A580")]
		public CompletedTween()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x43FD50", Offset = "0x43EF50", VA = "0x18043FD50", Slot = "9")]
		public override bool Advance(float dt)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class TweenInstanceColor : TweenInstance<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x351C700", Offset = "0x351B900", VA = "0x18351C700")]
		public TweenInstanceColor(Func<Color> getter, Action<Color> setter, Color target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6C0", Offset = "0xA6D8C0", VA = "0x180A6E6C0", Slot = "10")]
		protected override Color GetTargetValue()
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x351C6B0", Offset = "0x351B8B0", VA = "0x18351C6B0", Slot = "11")]
		protected override Color Interpolate(Color start, Color end, float time)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class TweenInstanceFloat : TweenInstance<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x351C880", Offset = "0x351BA80", VA = "0x18351C880")]
		public TweenInstanceFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x351C7A0", Offset = "0x351B9A0", VA = "0x18351C7A0", Slot = "10")]
		protected override float GetTargetValue()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x351C800", Offset = "0x351BA00", VA = "0x18351C800", Slot = "11")]
		protected override float Interpolate(float start, float end, float time)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TweenInstanceQuaternion : TweenInstance<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x351CA60", Offset = "0x351BC60", VA = "0x18351CA60")]
		public TweenInstanceQuaternion(Func<Quaternion> getter, Action<Quaternion> setter, Quaternion target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x351C8F0", Offset = "0x351BAF0", VA = "0x18351C8F0", Slot = "10")]
		protected override Quaternion GetTargetValue()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x351C9C0", Offset = "0x351BBC0", VA = "0x18351C9C0", Slot = "11")]
		protected override Quaternion Interpolate(Quaternion start, Quaternion end, float time)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class TweenInstanceVector3 : TweenInstance<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x351CCC0", Offset = "0x351BEC0", VA = "0x18351CCC0")]
		public TweenInstanceVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x351CB00", Offset = "0x351BD00", VA = "0x18351CB00", Slot = "10")]
		protected override Vector3 GetTargetValue()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x351CC00", Offset = "0x351BE00", VA = "0x18351CC00", Slot = "11")]
		protected override Vector3 Interpolate(Vector3 start, Vector3 end, float time)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class Tween
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct QueuedTween
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public TweenBase Tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Action RunTweenFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <RunQueuedTweens>d__26 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x3E7BB0", Offset = "0x3E6DB0", VA = "0x1803E7BB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x3E7BB0", Offset = "0x3E6DB0", VA = "0x1803E7BB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x41AA10", Offset = "0x419C10", VA = "0x18041AA10")]
			[DebuggerHidden]
			public <RunQueuedTweens>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3DF820", Offset = "0x3DEA20", VA = "0x1803DF820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x351F750", Offset = "0x351E950", VA = "0x18351F750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x351F980", Offset = "0x351EB80", VA = "0x18351F980", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <ExecuteTween>d__28 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public ITweenBase tween;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x3E7BB0", Offset = "0x3E6DB0", VA = "0x1803E7BB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x3E7BB0", Offset = "0x3E6DB0", VA = "0x1803E7BB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x41AA10", Offset = "0x419C10", VA = "0x18041AA10")]
			[DebuggerHidden]
			public <ExecuteTween>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DF820", Offset = "0x3DEA20", VA = "0x1803DF820", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x351F580", Offset = "0x351E780", VA = "0x18351F580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x351F700", Offset = "0x351E900", VA = "0x18351F700", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly List<QueuedTween> QueuedTweens;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly HashSet<TweenBase> ActiveTweens;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Dictionary<UnityEngine.Object, HashSet<TweenBase>> ActiveTweensByTarget;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static ISchedulerPromise runQueuedTweensPromise;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ITweenBase CompletedTween
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x351F520", Offset = "0x351E720", VA = "0x18351F520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x351EAA0", Offset = "0x351DCA0", VA = "0x18351EAA0")]
		public static ITweenInstance TweenFloat(Func<float> getter, Action<float> setter, float target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x351F230", Offset = "0x351E430", VA = "0x18351F230")]
		public static ITweenInstance TweenVector3(Func<Vector3> getter, Action<Vector3> setter, Vector3 target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x351E9A0", Offset = "0x351DBA0", VA = "0x18351E9A0")]
		public static ITweenInstance TweenColor(Func<Color> getter, Action<Color> setter, Color target, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x351F0A0", Offset = "0x351E2A0", VA = "0x18351F0A0")]
		public static ITweenInstance TweenLocalScale(Transform target, Vector3 targetScale, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x351EF10", Offset = "0x351E110", VA = "0x18351EF10")]
		public static ITweenInstance TweenLocalRotation(Transform target, Quaternion targetRotation, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x351EB90", Offset = "0x351DD90", VA = "0x18351EB90")]
		public static ITweenInstance TweenLocalPosition(Transform target, Vector3 targetPosition, float duration, Easing.Functions easeFunction, [Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x351ED20", Offset = "0x351DF20", VA = "0x18351ED20")]
		public static ITweenInstance TweenLocalPosition(this Behaviour behaviour, Vector3 targetPosition, float duration, Easing.Functions easeFunction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x351E800", Offset = "0x351DA00", VA = "0x18351E800")]
		public static ITweenSequence Sequence([Optional] Behaviour context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x351DC50", Offset = "0x351CE50", VA = "0x18351DC50")]
		public static void CancelAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x351E050", Offset = "0x351D250", VA = "0x18351E050")]
		private static void Queue(Behaviour context, TweenBase tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x351E420", Offset = "0x351D620", VA = "0x18351E420")]
		[IteratorStateMachine(typeof(<RunQueuedTweens>d__26))]
		private static IEnumerator<ISchedule> RunQueuedTweens()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x351E470", Offset = "0x351D670", VA = "0x18351E470")]
		private static void Run(Behaviour context, TweenBase sequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x351DE00", Offset = "0x351D000", VA = "0x18351DE00")]
		[IteratorStateMachine(typeof(<ExecuteTween>d__28))]
		private static IEnumerator<ISchedule> ExecuteTween(ITweenBase tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x351DAA0", Offset = "0x351CCA0", VA = "0x18351DAA0")]
		private static void AddTween(TweenBase tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x351E2E0", Offset = "0x351D4E0", VA = "0x18351E2E0")]
		private static void RemoveTween(TweenBase tween)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x351DE60", Offset = "0x351D060", VA = "0x18351DE60")]
		private static void OnSceneLoaded(Scene _, LoadSceneMode __)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal abstract class TweenBase : ITweenBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[CompilerGenerated]
		private Action Updated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[CompilerGenerated]
		private Action Completed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[CompilerGenerated]
		private Action Canceled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly List<Action> OnUpdatedCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected readonly List<Action> OnCompleteCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected readonly List<Action> OnCancelCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected CancelablePromise Promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		internal UnityEngine.Object Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		internal bool InSequence;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal bool IsCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x351C4E0", Offset = "0x351B6E0", VA = "0x18351C4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x351C4F0", Offset = "0x351B6F0", VA = "0x18351C4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x431420", Offset = "0x430620", VA = "0x180431420", Slot = "6")]
		public IPromise AsPromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x351C380", Offset = "0x351B580", VA = "0x18351C380", Slot = "4")]
		public ITweenBase SetOnComplete(Action callback, bool invokeOnCancel = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x351C2F0", Offset = "0x351B4F0", VA = "0x18351C2F0", Slot = "5")]
		public ITweenBase SetOnCancel(Action callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool Advance(float dt);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x351BF30", Offset = "0x351B130", VA = "0x18351BF30", Slot = "8")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x351C1E0", Offset = "0x351B3E0", VA = "0x18351C1E0")]
		protected void OnUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x351C0B0", Offset = "0x351B2B0", VA = "0x18351C0B0")]
		protected void OnCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x351C430", Offset = "0x351B630", VA = "0x18351C430")]
		protected TweenBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal abstract class TweenInstance : TweenBase, ITweenInstance, ITweenBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		protected bool IsRelative;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		protected readonly float Duration;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected Easing.Functions EaseFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3E90C0", Offset = "0x3E82C0", VA = "0x1803E90C0")]
			[CompilerGenerated]
			get
			{
				return default(Easing.Functions);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x351CDA0", Offset = "0x351BFA0", VA = "0x18351CDA0")]
		protected TweenInstance(float duration, Easing.Functions easeFunction)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal abstract class TweenInstance<TValue> : TweenInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected readonly Func<TValue> Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly Action<TValue> Setter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected readonly TValue TargetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private float elapsed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TValue startValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TValue endValue;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A055D0", Offset = "0x2A047D0", VA = "0x182A055D0")]
		protected TweenInstance(Func<TValue> getter, Action<TValue> setter, TValue targetValue, float duration, Easing.Functions easeFunction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract TValue GetTargetValue();

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract TValue Interpolate(TValue start, TValue end, float time);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A05300", Offset = "0x2A04500", VA = "0x182A05300", Slot = "9")]
		public override bool Advance(float dt)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class TweenSequence : TweenBase, ITweenSequence, ITweenBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum StepTypes
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Tween,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Delay,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Callback
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private struct TweenEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private ITweenBase tween;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private readonly Func<ITweenBase> factory;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x351C620", Offset = "0x351B820", VA = "0x18351C620")]
			public TweenEntry(ITweenBase tween)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x40D610", Offset = "0x40C810", VA = "0x18040D610")]
			public TweenEntry(Func<ITweenBase> factory)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x351C500", Offset = "0x351B700", VA = "0x18351C500")]
			public ITweenBase GetTween()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private struct Step
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public StepTypes StepType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public IEnumerable<TweenEntry> Tweens;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Action Callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float DelaySeconds;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<Step> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int currentStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float delayTimer;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x351D960", Offset = "0x351CB60", VA = "0x18351D960")]
		public TweenSequence()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x351CF60", Offset = "0x351C160", VA = "0x18351CF60", Slot = "10")]
		public ITweenSequence AddTween(ITweenBase tween)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x351D130", Offset = "0x351C330", VA = "0x18351D130", Slot = "11")]
		public ITweenSequence AddTween(Func<ITweenBase> tweenFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x351D310", Offset = "0x351C510", VA = "0x18351D310", Slot = "12")]
		public ITweenSequence AddTweens(IEnumerable<ITweenBase> tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x351D1C0", Offset = "0x351C3C0", VA = "0x18351D1C0", Slot = "13")]
		public ITweenSequence AddTweens(params ITweenBase[] tweens)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x351CEC0", Offset = "0x351C0C0", VA = "0x18351CEC0", Slot = "14")]
		public ITweenSequence AddDelay(float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x351D4B0", Offset = "0x351C6B0", VA = "0x18351D4B0", Slot = "9")]
		public override bool Advance(float dt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x351D8A0", Offset = "0x351CAA0", VA = "0x18351D8A0")]
		private void PrepareNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x351D430", Offset = "0x351C630", VA = "0x18351D430")]
		private ITweenSequence AddTweens(TweenEntry[] tweens)
		{
			return null;
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
