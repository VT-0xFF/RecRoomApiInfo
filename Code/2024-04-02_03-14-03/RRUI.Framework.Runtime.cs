using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using MVVMDatabinding;
using MVVMDatabinding.Theming;
using RRUI.Framework.Visuals;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RRUI.Framework.Visuals
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	internal class AnimationEffect : PlayableEffect, IAnimationMixableEffect, IPlayableEffect, IEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("The animation clip for this effect.")]
		private AnimationClip clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("Playback speed of the playable.")]
		private float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Tooltip("Should the playable be played back as a one-shot triggered effect, or should the playback time be directly driven by the state's value?")]
		private PlaybackType playbackMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		[Tooltip("How should this state's animation be blended and weighted? Constant: Always weighted 1.0, Transition: Transitions to 1 when state becomes active, MatchStateValue: Always weighted by the state's value.")]
		private IAnimationMixableEffect.WeightType weightMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[Tooltip("How long should it take to transition to a weight of 1.0 when the state becomes active?")]
		private float transitionDuration;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override float Speed
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x884EF0", Offset = "0x883AF0", VA = "0x180884EF0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC685A0", Offset = "0xC671A0", VA = "0x180C685A0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7CEBF0", Offset = "0x7CD7F0", VA = "0x1807CEBF0", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x94F520", Offset = "0x94E120", VA = "0x18094F520", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B13660", Offset = "0x6B12260", VA = "0x186B13660")]
		public AnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B136C0", Offset = "0x6B122C0", VA = "0x186B136C0")]
		public AnimationEffect(AnimationClip clip, PlaybackType playbackMode, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B135A0", Offset = "0x6B121A0", VA = "0x186B135A0", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal class GraphicFadeEffect : TintEffect<Graphic>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		internal class GraphicFadeBehaviour : TintBehaviour<Graphic>
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6B14150", Offset = "0x6B12D50", VA = "0x186B14150", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6B14280", Offset = "0x6B12E80", VA = "0x186B14280", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6B14320", Offset = "0x6B12F20", VA = "0x186B14320")]
			public GraphicFadeBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B14360", Offset = "0x6B12F60", VA = "0x186B14360", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B14440", Offset = "0x6B13040", VA = "0x186B14440")]
		public GraphicFadeEffect()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal class GraphicTintEffect : TintEffect<Graphic>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal class GraphicTintBehaviour : TintBehaviour<Graphic>
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6B14480", Offset = "0x6B13080", VA = "0x186B14480", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6B14510", Offset = "0x6B13110", VA = "0x186B14510", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6B145B0", Offset = "0x6B131B0", VA = "0x186B145B0")]
			public GraphicTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B145F0", Offset = "0x6B131F0", VA = "0x186B145F0", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B146D0", Offset = "0x6B132D0", VA = "0x186B146D0")]
		public GraphicTintEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IAnimationMixableEffect : IPlayableEffect, IEffect
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum WeightType
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Constant,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Transition,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			MatchStateValue
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IEffect
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Setup(PlayableGraph graph, GameObject owner);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Evaluate(float parameter);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IPlayableEffect : IEffect
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		Playable Playable
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class PlayableAssetEffect : PlayableEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("The ScriptableObject containing the effect.")]
		private StateVisualAsset playableAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("Playback speed of the playable.")]
		private float speed;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override float Speed
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x884EF0", Offset = "0x883AF0", VA = "0x180884EF0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1900490", Offset = "0x18FF090", VA = "0x181900490", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B14940", Offset = "0x6B13540", VA = "0x186B14940")]
		public PlayableAssetEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B148B0", Offset = "0x6B134B0", VA = "0x186B148B0")]
		public PlayableAssetEffect(StateVisualAsset playableAsset, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B14850", Offset = "0x6B13450", VA = "0x186B14850", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal abstract class PlayableEffect : IPlayableEffect, IEffect
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		internal enum PlaybackType
		{
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			OneShot,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			PlaybackTimeMatchesValue
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Playable Playable
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84C930", VA = "0x18084DD30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected abstract float Speed
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected abstract PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void Setup(PlayableGraph graph, GameObject owner);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6B149A0", Offset = "0x6B135A0", VA = "0x186B149A0", Slot = "10")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		protected PlayableEffect()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal class SetTargetsActiveEffect : IEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		[Tooltip("If true, the specified objects will be set inactive when the state is on, and vice versa.")]
		private bool invert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[Tooltip("The list of gameobjects to be toggled.")]
		private List<GameObject> targets;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6B154D0", Offset = "0x6B140D0", VA = "0x186B154D0")]
		public SetTargetsActiveEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B15520", Offset = "0x6B14120", VA = "0x186B15520")]
		public SetTargetsActiveEffect(List<GameObject> targets, bool invert = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B15360", Offset = "0x6B13F60", VA = "0x186B15360", Slot = "5")]
		public bool Evaluate(float parameter)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class SpriteSwapEffect : IEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[Tooltip("Threshold value to activate this effect. When the state value is above this number, the effect will activate.")]
		private float activationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("The Image to switch sprites for.")]
		private Image target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Tooltip("The texture to set when the state is active.")]
		private Sprite activeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Tooltip("The texture to set when the state is inactive.")]
		private Sprite inactiveSprite;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B15690", Offset = "0x6B14290", VA = "0x186B15690")]
		public SpriteSwapEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B155A0", Offset = "0x6B141A0", VA = "0x186B155A0", Slot = "5")]
		public bool Evaluate(float parameter)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class SpriteTintEffect : TintEffect<SpriteRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		internal class SpriteTintBehaviour : TintBehaviour<SpriteRenderer>
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B156F0", Offset = "0x6B142F0", VA = "0x186B156F0", Slot = "22")]
			protected override void ApplyColor(Color color, SpriteRenderer sprite)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B15770", Offset = "0x6B14370", VA = "0x186B15770", Slot = "23")]
			protected override bool GetColor(SpriteRenderer sprite, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6B15810", Offset = "0x6B14410", VA = "0x186B15810")]
			public SpriteTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B15850", Offset = "0x6B14450", VA = "0x186B15850", Slot = "13")]
		protected override TintBehaviour<SpriteRenderer> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B15930", Offset = "0x6B14530", VA = "0x186B15930")]
		public SpriteTintEffect()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class TintEffect<T> : PlayableEffect, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal abstract class TintBehaviour<U> : PlayableBehaviour
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private List<U> tintables;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private Color[] startColors;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private Color[] cachedColors;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public List<U> Tintables
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x43E1330", Offset = "0x43DFF30", VA = "0x1843E1330")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Color TintColor
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x9153C0", Offset = "0x913FC0", VA = "0x1809153C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BlendType BlendMode
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7B6CC0", Offset = "0x7B58C0", VA = "0x1807B6CC0")]
				[CompilerGenerated]
				get
				{
					return default(BlendType);
				}
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7B6570", Offset = "0x7B5170", VA = "0x1807B6570")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x43E12A0", Offset = "0x43DFEA0", VA = "0x1843E12A0")]
			public TintBehaviour()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "22")]
			protected abstract void ApplyColor(Color color, U tintable);

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "23")]
			protected abstract bool GetColor(U tintable, [Out] Color color);

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x43E0AE0", Offset = "0x43DF6E0", VA = "0x1843E0AE0", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x43E0920", Offset = "0x43DF520", VA = "0x1843E0920", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x43E0C10", Offset = "0x43DF810", VA = "0x1843E0C10", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x43E0D70", Offset = "0x43DF970", VA = "0x1843E0D70", Slot = "20")]
			public override void ProcessFrame(Playable playable, FrameData info, object playerData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal enum BlendType
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Override,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			Additive,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Multiply
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[Tooltip("The duration of the transition from un-tinted to tinted.")]
		private float transitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeReference]
		[Tooltip("The objects to tint. All of them must share the same tint color; use separate TintEffects for different colors.")]
		private List<T> tintables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("Tint color.")]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("Should the playable be played back as a one-shot triggered effect, or should the playback time be directly driven by the state's value?")]
		private PlaybackType playbackMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("How should this tint color be blended onto the existing Graphic color (including the effects of other GraphicTintEffects?)")]
		private BlendType blendMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TintBehaviour<T> behaviourInstance;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override float Speed
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85D160", Offset = "0x85BD60", VA = "0x18085D160", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x945510", Offset = "0x944110", VA = "0x180945510", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected BlendType BlendMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B63E0", Offset = "0x8B4FE0", VA = "0x1808B63E0")]
			get
			{
				return default(BlendType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x43E1820", Offset = "0x43E0420", VA = "0x1843E1820")]
		public TintEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43E1890", Offset = "0x43E0490", VA = "0x1843E1890")]
		public TintEffect(PlaybackType playbackMode, float transitionDuration, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43E1700", Offset = "0x43E0300", VA = "0x1843E1700", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43E14C0", Offset = "0x43E00C0", VA = "0x1843E14C0", Slot = "10")]
		public override bool Evaluate(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract TintBehaviour<T> CreatePlayableAndBehaviour(PlayableGraph graph);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43E1660", Offset = "0x43E0260", VA = "0x1843E1660", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x43E15C0", Offset = "0x43E01C0", VA = "0x1843E15C0", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class TwoWayAnimationEffect : PlayableEffect, IAnimationMixableEffect, IPlayableEffect, IEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[HideInInspector]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[Tooltip("The animation clip for the forward direction.")]
		private AnimationClip forwardClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Tooltip("The animation clip for the reverse direction.")]
		private AnimationClip reverseClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[Tooltip("Playback speed of the overall blended animation.")]
		private float speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		[Tooltip("How should this state's animation be blended and weighted? Constant: Always weighted 1.0, Transition: Transitions to 1 when state becomes active, MatchStateValue: Always weighted by the state's value.")]
		private IAnimationMixableEffect.WeightType weightMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[Tooltip("How long should it take to transition to a weight of 1.0 when the state becomes active?")]
		private float transitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private Playable forwardPlayable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private Playable reversePlayable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private float lastValue;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected override float Speed
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8B6F20", Offset = "0x8B5B20", VA = "0x1808B6F20", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7CEC00", Offset = "0x7CD800", VA = "0x1807CEC00", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xC6E690", Offset = "0xC6D290", VA = "0x180C6E690", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B17B50", Offset = "0x6B16750", VA = "0x186B17B50")]
		public TwoWayAnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B17BB0", Offset = "0x6B167B0", VA = "0x186B17BB0")]
		public TwoWayAnimationEffect(AnimationClip forwardClip, AnimationClip reverseClip, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B178A0", Offset = "0x6B164A0", VA = "0x186B178A0", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B17750", Offset = "0x6B16350", VA = "0x186B17750", Slot = "10")]
		public override bool Evaluate(float stateValue)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IStateVisualizerDriver
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void StateValueSetEventHandler(int stateId, float stateValue);

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool KeepVisualizerAwake
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event StateValueSetEventHandler StateValueSet;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetVisualStates(VisualStates states);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MockStateVisualizerDriver : MonoBehaviour, IStateVisualizerDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private bool animationsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private VisualStates visualStates;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool KeepVisualizerAwake
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7B9F80", Offset = "0x7B8B80", VA = "0x1807B9F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public VisualStates VisualStates
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IStateVisualizerDriver.StateValueSetEventHandler StateValueSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B14710", Offset = "0x6B13310", VA = "0x186B14710", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B147B0", Offset = "0x6B133B0", VA = "0x186B147B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x66BF7D0", Offset = "0x66BE3D0", VA = "0x1866BF7D0")]
		public void PushStateChange(int id, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10", Slot = "7")]
		public void SetVisualStates(VisualStates states)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB75F30", Offset = "0xB74B30", VA = "0x180B75F30")]
		public MockStateVisualizerDriver()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct SerializableDictionaryEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			[SerializeField]
			private TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			[SerializeField]
			private TValue value;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public TKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
				get
				{
					return (TKey)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public TValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x9022F0", Offset = "0x900EF0", VA = "0x1809022F0")]
				get
				{
					return (TValue)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xC4B980", Offset = "0xC4A580", VA = "0x180C4B980")]
			public SerializableDictionaryEntry(TKey key, TValue value)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<SerializableDictionaryEntry> entries;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x42E3800", Offset = "0x42E2400", VA = "0x1842E3800", Slot = "46")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x42E34C0", Offset = "0x42E20C0", VA = "0x1842E34C0", Slot = "47")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x42E3C00", Offset = "0x42E2800", VA = "0x1842E3C00")]
		public SerializableDictionary()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu(fileName = "MRTKHandsAggregatorConfig.asset", menuName = "MRTK/State Visualizer/Animation PlayableAsset")]
	internal class StateVisualAnimationAsset : StateVisualAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[Tooltip("The animation clip to wrap in a Playable.")]
		private AnimationClip clip;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6B15A10", Offset = "0x6B14610", VA = "0x186B15A10", Slot = "4")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC5E430", Offset = "0xC5D030", VA = "0x180C5E430")]
		public StateVisualAnimationAsset()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal abstract class StateVisualAsset : PlayableAsset
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[Tooltip("Should the playable be played back as a one-shot triggered effect, or should the playback time be directly driven by the state's value?")]
		private PlayableEffect.PlaybackType playbackMode;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public PlayableEffect.PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
			get
			{
				return default(PlayableEffect.PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC5E430", Offset = "0xC5D030", VA = "0x180C5E430")]
		protected StateVisualAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("MRTK/UX/State Visualizer")]
	[RequireComponent(typeof(Animator))]
	public class StateVisualizer : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class State
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[SerializeReference]
			[Tooltip("The list of effects to apply.")]
			private List<IEffect> effects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			[SerializeField]
			private bool isVariable;

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			public List<IEffect> Effects
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public float Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x93A5F0", Offset = "0x9391F0", VA = "0x18093A5F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x93A690", Offset = "0x939290", VA = "0x18093A690")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float PreviousValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x9F49F0", Offset = "0x9F35F0", VA = "0x1809F49F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9F5010", Offset = "0x9F3C10", VA = "0x1809F5010")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public bool IsVariable
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x7B9F80", Offset = "0x7B8B80", VA = "0x1807B9F80")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7B9E30", Offset = "0x7B8A30", VA = "0x1807B9E30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6B17290", Offset = "0x6B15E90", VA = "0x186B17290")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const float keepAliveTime = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const int defaultWakeupEventCount = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private VisualStates visualStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		internal SerializableDictionary<int, State> stateContainers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private MonoBehaviour serializedDriver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private IStateVisualizerDriver driver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[Tooltip("The Animator to be used as the output for the Playable graph.")]
		private Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private PlayableGraph playableGraph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private AnimationLayerMixerPlayable animationMixerPlayable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private float sleepTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<UnityAction> unsubscribeActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<IEffect, int> mixableIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool stateValueHasChanged;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly ProfilerMarker StateVisualizerEvaluateEffectsMarker;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public VisualStates VisualStates
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public SerializableDictionary<int, State> StateContainers
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7B9F30", Offset = "0x7B8B30", VA = "0x1807B9F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B16180", Offset = "0x6B14D80", VA = "0x186B16180")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B162D0", Offset = "0x6B14ED0", VA = "0x186B162D0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B16F30", Offset = "0x6B15B30", VA = "0x186B16F30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B160B0", Offset = "0x6B14CB0", VA = "0x186B160B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B15AE0", Offset = "0x6B146E0", VA = "0x186B15AE0")]
		public void AddEffect(int stateId, IEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B16210", Offset = "0x6B14E10", VA = "0x186B16210")]
		public bool RemoveEffect(int stateId, IEffect effect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B16AE0", Offset = "0x6B156E0", VA = "0x186B16AE0")]
		private void UpdateStateValue(int stateId, float newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B15CC0", Offset = "0x6B148C0", VA = "0x186B15CC0")]
		private bool EvaluateEffects()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B16BB0", Offset = "0x6B157B0", VA = "0x186B16BB0")]
		private bool UpdateWeight(IAnimationMixableEffect mixableEffect, State state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B17160", Offset = "0x6B15D60", VA = "0x186B17160")]
		public StateVisualizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CreateAssetMenu(menuName = "RRUI/StateVisualizer/VisualStates", fileName = "VisualStates")]
	public class VisualStates : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private List<int> stateIDs;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6B17C60", Offset = "0x6B16860", VA = "0x186B17C60")]
		public bool HasState(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89ACE0", Offset = "0x8998E0", VA = "0x18089ACE0")]
		public VisualStates()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class ThemedColorSwapEffect : ThemedEffect<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		internal class ColorSwapBeahvior : PlayableBehaviour
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private List<Graphic> targets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private Color[] startColors;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private Color[] cachedColors;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public List<Graphic> Targets
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color TargetColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x9153C0", Offset = "0x913FC0", VA = "0x1809153C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6B140C0", Offset = "0x6B12CC0", VA = "0x186B140C0")]
			public ColorSwapBeahvior()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6B13760", Offset = "0x6B12360", VA = "0x186B13760")]
			public void ApplyColor(Color color, Graphic target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6B137F0", Offset = "0x6B123F0", VA = "0x186B137F0")]
			public bool GetColor(Graphic target, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6B13890", Offset = "0x6B12490", VA = "0x186B13890", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6B13A70", Offset = "0x6B12670", VA = "0x186B13A70", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6B13BB0", Offset = "0x6B127B0", VA = "0x186B13BB0", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6B13D40", Offset = "0x6B12940", VA = "0x186B13D40", Slot = "20")]
			public override void ProcessFrame(Playable playable, FrameData info, object playerData)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		[HideInInspector]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private float transitionDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private List<Graphic> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private ColorSwapBeahvior behaviorInstance;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Playable Playable
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xEC9970", Offset = "0xEC8570", VA = "0x180EC9970")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x372AAC0", Offset = "0x37296C0", VA = "0x18372AAC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B17490", Offset = "0x6B16090", VA = "0x186B17490", Slot = "6")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B17320", Offset = "0x6B15F20", VA = "0x186B17320", Slot = "8")]
		protected override bool SetValue(Color value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6B17610", Offset = "0x6B16210", VA = "0x186B17610")]
		public ThemedColorSwapEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public abstract class ThemedEffect<T> : IEffect
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private ThemeDataResolver activeThemeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		protected bool setInactive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[ConditionalVisibility("setInactive", ConditionResultType.ShowIfEquals)]
		[SerializeField]
		private ThemeDataResolver inactiveThemeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		protected T inactiveValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		protected T activeValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool lastActiveState;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x43DED20", Offset = "0x43DD920", VA = "0x1843DED20", Slot = "6")]
		public virtual void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x43DE8B0", Offset = "0x43DD4B0", VA = "0x1843DE8B0", Slot = "7")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool SetValue(T value, float parameter);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x43DE990", Offset = "0x43DD590", VA = "0x1843DE990")]
		private void OnActiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x43DEAE0", Offset = "0x43DD6E0", VA = "0x1843DEAE0")]
		private void OnInactiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		protected ThemedEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ThemedMaterialSwapEffect : ThemedEffect<Material>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Graphic target;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6B17680", Offset = "0x6B16280", VA = "0x186B17680", Slot = "8")]
		protected override bool SetValue(Material value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B17710", Offset = "0x6B16310", VA = "0x186B17710")]
		public ThemedMaterialSwapEffect()
		{
		}
	}
}
namespace RRUI.Framework.Views
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class RRUIButton : Button, IStateVisualizerDriver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private bool KHJPNDHNMPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool LBHMOIKJDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool OEKJOLHMIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x113")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool GBKGAFODBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool FOFLIHDCCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool CMFHNMNNILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x116")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool HBJIGJLHIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x117")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool JCMMELKNCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool DPOLAPFBJNH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KKLDKCKGMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB2B670", Offset = "0xB2A270", VA = "0x180B2B670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool APAMNAIJNKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6B15200", Offset = "0x6B13E00", VA = "0x186B15200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HNNEIPCNIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6B15250", Offset = "0x6B13E50", VA = "0x186B15250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool LOKBJLPBBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6B15270", Offset = "0x6B13E70", VA = "0x186B15270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool NDBBOPCAAFI
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6B15290", Offset = "0x6B13E90", VA = "0x186B15290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UnityEvent KPGGKEGAEPB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9A7660", Offset = "0x9A6260", VA = "0x1809A7660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA1EDA0", Offset = "0xA1D9A0", VA = "0x180A1EDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OEIGIOLBNBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6B15220", Offset = "0x6B13E20", VA = "0x186B15220", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IStateVisualizerDriver.StateValueSetEventHandler LHEGDLPGCLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6B15150", Offset = "0x6B13D50", VA = "0x186B15150", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6B152B0", Offset = "0x6B13EB0", VA = "0x186B152B0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6B14D70", Offset = "0x6B13970", VA = "0x186B14D70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6B14D20", Offset = "0x6B13920", VA = "0x186B14D20", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6B14E30", Offset = "0x6B13A30", VA = "0x186B14E30", Slot = "34")]
		public override void OnPointerEnter(PointerEventData JOAOCJCBGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6B14E90", Offset = "0x6B13A90", VA = "0x186B14E90", Slot = "35")]
		public override void OnPointerExit(PointerEventData JOAOCJCBGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6B14DD0", Offset = "0x6B139D0", VA = "0x186B14DD0", Slot = "32")]
		public override void OnPointerDown(PointerEventData JOAOCJCBGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B14EF0", Offset = "0x6B13AF0", VA = "0x186B14EF0", Slot = "33")]
		public override void OnPointerUp(PointerEventData JOAOCJCBGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6B14F40", Offset = "0x6B13B40", VA = "0x186B14F40", Slot = "36")]
		public override void OnSelect(BaseEventData JOAOCJCBGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6B14CC0", Offset = "0x6B138C0", VA = "0x186B14CC0", Slot = "37")]
		public override void OnDeselect(BaseEventData JOAOCJCBGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B14C50", Offset = "0x6B13850", VA = "0x186B14C50", Slot = "26")]
		protected override void DoStateTransition(SelectionState KAADEKGDAHK, bool FKDFENEEBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B14FA0", Offset = "0x6B13BA0", VA = "0x186B14FA0", Slot = "46")]
		public void SetVisualStates(VisualStates PLGFOBHGJLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6B150D0", Offset = "0x6B13CD0", VA = "0x186B150D0")]
		public RRUIButton()
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
