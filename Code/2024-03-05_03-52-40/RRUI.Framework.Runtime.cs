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
			[Cpp2IlInjected.Address(RVA = "0x870180", Offset = "0x86EF80", VA = "0x180870180", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC0A230", Offset = "0xC09030", VA = "0x180C0A230", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7D74E0", Offset = "0x7D62E0", VA = "0x1807D74E0", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x91AC40", Offset = "0x919A40", VA = "0x18091AC40", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A89FC0", Offset = "0x6A88DC0", VA = "0x186A89FC0")]
		public AnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A8A020", Offset = "0x6A88E20", VA = "0x186A8A020")]
		public AnimationEffect(AnimationClip clip, PlaybackType playbackMode, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A89F00", Offset = "0x6A88D00", VA = "0x186A89F00", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A8AAB0", Offset = "0x6A898B0", VA = "0x186A8AAB0", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8ABE0", Offset = "0x6A899E0", VA = "0x186A8ABE0", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8AC80", Offset = "0x6A89A80", VA = "0x186A8AC80")]
			public GraphicFadeBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A8ACC0", Offset = "0x6A89AC0", VA = "0x186A8ACC0", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A8ADA0", Offset = "0x6A89BA0", VA = "0x186A8ADA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A8ADE0", Offset = "0x6A89BE0", VA = "0x186A8ADE0", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6A8AE70", Offset = "0x6A89C70", VA = "0x186A8AE70", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6A8AF10", Offset = "0x6A89D10", VA = "0x186A8AF10")]
			public GraphicTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8AF50", Offset = "0x6A89D50", VA = "0x186A8AF50", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B030", Offset = "0x6A89E30", VA = "0x186A8B030")]
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
			[Cpp2IlInjected.Address(RVA = "0x870180", Offset = "0x86EF80", VA = "0x180870180", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18A9AD0", Offset = "0x18A88D0", VA = "0x1818A9AD0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B2A0", Offset = "0x6A8A0A0", VA = "0x186A8B2A0")]
		public PlayableAssetEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B210", Offset = "0x6A8A010", VA = "0x186A8B210")]
		public PlayableAssetEffect(StateVisualAsset playableAsset, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B1B0", Offset = "0x6A89FB0", VA = "0x186A8B1B0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x825DE0", Offset = "0x824BE0", VA = "0x180825DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8B300", Offset = "0x6A8A100", VA = "0x186A8B300", Slot = "10")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8BE30", Offset = "0x6A8AC30", VA = "0x186A8BE30")]
		public SetTargetsActiveEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BE80", Offset = "0x6A8AC80", VA = "0x186A8BE80")]
		public SetTargetsActiveEffect(List<GameObject> targets, bool invert = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BCC0", Offset = "0x6A8AAC0", VA = "0x186A8BCC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8BFF0", Offset = "0x6A8ADF0", VA = "0x186A8BFF0")]
		public SpriteSwapEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BF00", Offset = "0x6A8AD00", VA = "0x186A8BF00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A8C050", Offset = "0x6A8AE50", VA = "0x186A8C050", Slot = "22")]
			protected override void ApplyColor(Color color, SpriteRenderer sprite)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C0D0", Offset = "0x6A8AED0", VA = "0x186A8C0D0", Slot = "23")]
			protected override bool GetColor(SpriteRenderer sprite, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C170", Offset = "0x6A8AF70", VA = "0x186A8C170")]
			public SpriteTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C1B0", Offset = "0x6A8AFB0", VA = "0x186A8C1B0", Slot = "13")]
		protected override TintBehaviour<SpriteRenderer> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C290", Offset = "0x6A8B090", VA = "0x186A8C290")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x43C4F20", Offset = "0x43C3D20", VA = "0x1843C4F20")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Color TintColor
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x8EE7A0", Offset = "0x8ED5A0", VA = "0x1808EE7A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BlendType BlendMode
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7C24B0", Offset = "0x7C12B0", VA = "0x1807C24B0")]
				[CompilerGenerated]
				get
				{
					return default(BlendType);
				}
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7C24D0", Offset = "0x7C12D0", VA = "0x1807C24D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x43C4E90", Offset = "0x43C3C90", VA = "0x1843C4E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x43C46D0", Offset = "0x43C34D0", VA = "0x1843C46D0", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x43C4510", Offset = "0x43C3310", VA = "0x1843C4510", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x43C4800", Offset = "0x43C3600", VA = "0x1843C4800", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x43C4960", Offset = "0x43C3760", VA = "0x1843C4960", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x848A10", Offset = "0x847810", VA = "0x180848A10", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x92F2F0", Offset = "0x92E0F0", VA = "0x18092F2F0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected BlendType BlendMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x89CE00", Offset = "0x89BC00", VA = "0x18089CE00")]
			get
			{
				return default(BlendType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x43C5410", Offset = "0x43C4210", VA = "0x1843C5410")]
		public TintEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43C5480", Offset = "0x43C4280", VA = "0x1843C5480")]
		public TintEffect(PlaybackType playbackMode, float transitionDuration, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43C52F0", Offset = "0x43C40F0", VA = "0x1843C52F0", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43C50B0", Offset = "0x43C3EB0", VA = "0x1843C50B0", Slot = "10")]
		public override bool Evaluate(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract TintBehaviour<T> CreatePlayableAndBehaviour(PlayableGraph graph);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43C5250", Offset = "0x43C4050", VA = "0x1843C5250", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x43C51B0", Offset = "0x43C3FB0", VA = "0x1843C51B0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x89D930", Offset = "0x89C730", VA = "0x18089D930", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7D74F0", Offset = "0x7D62F0", VA = "0x1807D74F0", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xC0FCC0", Offset = "0xC0EAC0", VA = "0x180C0FCC0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E4B0", Offset = "0x6A8D2B0", VA = "0x186A8E4B0")]
		public TwoWayAnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E510", Offset = "0x6A8D310", VA = "0x186A8E510")]
		public TwoWayAnimationEffect(AnimationClip forwardClip, AnimationClip reverseClip, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E200", Offset = "0x6A8D000", VA = "0x186A8E200", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E0B0", Offset = "0x6A8CEB0", VA = "0x186A8E0B0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BE950", Offset = "0x7BD750", VA = "0x1807BE950", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public VisualStates VisualStates
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IStateVisualizerDriver.StateValueSetEventHandler StateValueSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6A8B070", Offset = "0x6A89E70", VA = "0x186A8B070", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6A8B110", Offset = "0x6A89F10", VA = "0x186A8B110", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x66316E0", Offset = "0x66304E0", VA = "0x1866316E0")]
		public void PushStateChange(int id, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F60", Offset = "0x7B7D60", VA = "0x1807B8F60", Slot = "7")]
		public void SetVisualStates(VisualStates states)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB5B8B0", Offset = "0xB5A6B0", VA = "0x180B5B8B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x8EAFA0", Offset = "0x8E9DA0", VA = "0x1808EAFA0")]
				get
				{
					return (TKey)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public TValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730")]
				get
				{
					return (TValue)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xBF9910", Offset = "0xBF8710", VA = "0x180BF9910")]
			public SerializableDictionaryEntry(TKey key, TValue value)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<SerializableDictionaryEntry> entries;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x42D2EE0", Offset = "0x42D1CE0", VA = "0x1842D2EE0", Slot = "46")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x42D2BA0", Offset = "0x42D19A0", VA = "0x1842D2BA0", Slot = "47")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x42D32E0", Offset = "0x42D20E0", VA = "0x1842D32E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8C370", Offset = "0x6A8B170", VA = "0x186A8C370", Slot = "4")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC3FB30", Offset = "0xC3E930", VA = "0x180C3FB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
			get
			{
				return default(PlayableEffect.PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC3FB30", Offset = "0xC3E930", VA = "0x180C3FB30")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public float Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x922D40", Offset = "0x921B40", VA = "0x180922D40")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x922DE0", Offset = "0x921BE0", VA = "0x180922DE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float PreviousValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x9BC5B0", Offset = "0x9BB3B0", VA = "0x1809BC5B0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9BCCB0", Offset = "0x9BBAB0", VA = "0x1809BCCB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public bool IsVariable
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x7BE950", Offset = "0x7BD750", VA = "0x1807BE950")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7BEA40", Offset = "0x7BD840", VA = "0x1807BEA40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8DBF0", Offset = "0x6A8C9F0", VA = "0x186A8DBF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public SerializableDictionary<int, State> StateContainers
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7BE970", Offset = "0x7BD770", VA = "0x1807BE970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CAE0", Offset = "0x6A8B8E0", VA = "0x186A8CAE0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CC30", Offset = "0x6A8BA30", VA = "0x186A8CC30", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D890", Offset = "0x6A8C690", VA = "0x186A8D890")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CA10", Offset = "0x6A8B810", VA = "0x186A8CA10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C440", Offset = "0x6A8B240", VA = "0x186A8C440")]
		public void AddEffect(int stateId, IEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6A8CB70", Offset = "0x6A8B970", VA = "0x186A8CB70")]
		public bool RemoveEffect(int stateId, IEffect effect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D440", Offset = "0x6A8C240", VA = "0x186A8D440")]
		private void UpdateStateValue(int stateId, float newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A8C620", Offset = "0x6A8B420", VA = "0x186A8C620")]
		private bool EvaluateEffects()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D510", Offset = "0x6A8C310", VA = "0x186A8D510")]
		private bool UpdateWeight(IAnimationMixableEffect mixableEffect, State state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DAC0", Offset = "0x6A8C8C0", VA = "0x186A8DAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8E5C0", Offset = "0x6A8D3C0", VA = "0x186A8E5C0")]
		public bool HasState(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8853D0", Offset = "0x8841D0", VA = "0x1808853D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color TargetColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x8EE7A0", Offset = "0x8ED5A0", VA = "0x1808EE7A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6A8AA20", Offset = "0x6A89820", VA = "0x186A8AA20")]
			public ColorSwapBeahvior()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A0C0", Offset = "0x6A88EC0", VA = "0x186A8A0C0")]
			public void ApplyColor(Color color, Graphic target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A150", Offset = "0x6A88F50", VA = "0x186A8A150")]
			public bool GetColor(Graphic target, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A1F0", Offset = "0x6A88FF0", VA = "0x186A8A1F0", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A3D0", Offset = "0x6A891D0", VA = "0x186A8A3D0", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A510", Offset = "0x6A89310", VA = "0x186A8A510", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6A8A6A0", Offset = "0x6A894A0", VA = "0x186A8A6A0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEA4760", Offset = "0xEA3560", VA = "0x180EA4760")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3ADF880", Offset = "0x3ADE680", VA = "0x183ADF880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DDF0", Offset = "0x6A8CBF0", VA = "0x186A8DDF0", Slot = "6")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DC80", Offset = "0x6A8CA80", VA = "0x186A8DC80", Slot = "8")]
		protected override bool SetValue(Color value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DF70", Offset = "0x6A8CD70", VA = "0x186A8DF70")]
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
		[Cpp2IlInjected.Address(RVA = "0x43C2910", Offset = "0x43C1710", VA = "0x1843C2910", Slot = "6")]
		public virtual void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x43C24A0", Offset = "0x43C12A0", VA = "0x1843C24A0", Slot = "7")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool SetValue(T value, float parameter);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x43C2580", Offset = "0x43C1380", VA = "0x1843C2580")]
		private void OnActiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x43C26D0", Offset = "0x43C14D0", VA = "0x1843C26D0")]
		private void OnInactiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A8DFE0", Offset = "0x6A8CDE0", VA = "0x186A8DFE0", Slot = "8")]
		protected override bool SetValue(Material value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E070", Offset = "0x6A8CE70", VA = "0x186A8E070")]
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
		private bool MNIACEPKGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool FLNMJHBDEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool MMFGOIJBFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x113")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool NKFCHNBJNKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool BILDMCJIGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool PAPFOGNFCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x116")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool JCABHPILJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x117")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool FIIOBJOIECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool CGCICNLLBNF;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DINCJKDOFJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAEF360", Offset = "0xAEE160", VA = "0x180AEF360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool INEFJDBCCEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BB60", Offset = "0x6A8A960", VA = "0x186A8BB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool JIDLECILEJB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BBB0", Offset = "0x6A8A9B0", VA = "0x186A8BBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IILJFIPGJDN
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BBD0", Offset = "0x6A8A9D0", VA = "0x186A8BBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool JLAHBKDIEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BBF0", Offset = "0x6A8A9F0", VA = "0x186A8BBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UnityEvent GLAHHDMJAJD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8D3D30", Offset = "0x8D2B30", VA = "0x1808D3D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA087C0", Offset = "0xA075C0", VA = "0x180A087C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool OOPNILJNKMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BB80", Offset = "0x6A8A980", VA = "0x186A8BB80", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IStateVisualizerDriver.StateValueSetEventHandler GELCCKOKHCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BAB0", Offset = "0x6A8A8B0", VA = "0x186A8BAB0", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6A8BC10", Offset = "0x6A8AA10", VA = "0x186A8BC10", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B6D0", Offset = "0x6A8A4D0", VA = "0x186A8B6D0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B680", Offset = "0x6A8A480", VA = "0x186A8B680", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B790", Offset = "0x6A8A590", VA = "0x186A8B790", Slot = "34")]
		public override void OnPointerEnter(PointerEventData PKOMIDKDHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B7F0", Offset = "0x6A8A5F0", VA = "0x186A8B7F0", Slot = "35")]
		public override void OnPointerExit(PointerEventData PKOMIDKDHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B730", Offset = "0x6A8A530", VA = "0x186A8B730", Slot = "32")]
		public override void OnPointerDown(PointerEventData PKOMIDKDHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B850", Offset = "0x6A8A650", VA = "0x186A8B850", Slot = "33")]
		public override void OnPointerUp(PointerEventData PKOMIDKDHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B8A0", Offset = "0x6A8A6A0", VA = "0x186A8B8A0", Slot = "36")]
		public override void OnSelect(BaseEventData PKOMIDKDHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B620", Offset = "0x6A8A420", VA = "0x186A8B620", Slot = "37")]
		public override void OnDeselect(BaseEventData PKOMIDKDHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B5B0", Offset = "0x6A8A3B0", VA = "0x186A8B5B0", Slot = "26")]
		protected override void DoStateTransition(SelectionState OHBBLINCHPH, bool ODNIIAMCLCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B900", Offset = "0x6A8A700", VA = "0x186A8B900", Slot = "46")]
		public void SetVisualStates(VisualStates BKBIALPDHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8BA30", Offset = "0x6A8A830", VA = "0x186A8BA30")]
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
