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
			[Cpp2IlInjected.Address(RVA = "0x898960", Offset = "0x897960", VA = "0x180898960", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC70A60", Offset = "0xC6FA60", VA = "0x180C70A60", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7DE5E0", Offset = "0x7DD5E0", VA = "0x1807DE5E0", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x93E020", Offset = "0x93D020", VA = "0x18093E020", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF430", Offset = "0x6CCE430", VA = "0x186CCF430")]
		public AnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF490", Offset = "0x6CCE490", VA = "0x186CCF490")]
		public AnimationEffect(AnimationClip clip, PlaybackType playbackMode, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF370", Offset = "0x6CCE370", VA = "0x186CCF370", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CCFF20", Offset = "0x6CCEF20", VA = "0x186CCFF20", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6CD0050", Offset = "0x6CCF050", VA = "0x186CD0050", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6CD00F0", Offset = "0x6CCF0F0", VA = "0x186CD00F0")]
			public GraphicFadeBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0130", Offset = "0x6CCF130", VA = "0x186CD0130", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0210", Offset = "0x6CCF210", VA = "0x186CD0210")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CD0250", Offset = "0x6CCF250", VA = "0x186CD0250", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6CD02E0", Offset = "0x6CCF2E0", VA = "0x186CD02E0", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6CD0380", Offset = "0x6CCF380", VA = "0x186CD0380")]
			public GraphicTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD03C0", Offset = "0x6CCF3C0", VA = "0x186CD03C0", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6CD04A0", Offset = "0x6CCF4A0", VA = "0x186CD04A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x898960", Offset = "0x897960", VA = "0x180898960", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x195B780", Offset = "0x195A780", VA = "0x18195B780", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0730", Offset = "0x6CCF730", VA = "0x186CD0730")]
		public PlayableAssetEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD06A0", Offset = "0x6CCF6A0", VA = "0x186CD06A0")]
		public PlayableAssetEffect(StateVisualAsset playableAsset, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0640", Offset = "0x6CCF640", VA = "0x186CD0640", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85AF30", Offset = "0x859F30", VA = "0x18085AF30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CD0790", Offset = "0x6CCF790", VA = "0x186CD0790", Slot = "10")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CD12C0", Offset = "0x6CD02C0", VA = "0x186CD12C0")]
		public SetTargetsActiveEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1310", Offset = "0x6CD0310", VA = "0x186CD1310")]
		public SetTargetsActiveEffect(List<GameObject> targets, bool invert = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1150", Offset = "0x6CD0150", VA = "0x186CD1150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CD1480", Offset = "0x6CD0480", VA = "0x186CD1480")]
		public SpriteSwapEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1390", Offset = "0x6CD0390", VA = "0x186CD1390", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CD14E0", Offset = "0x6CD04E0", VA = "0x186CD14E0", Slot = "22")]
			protected override void ApplyColor(Color color, SpriteRenderer sprite)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6CD1560", Offset = "0x6CD0560", VA = "0x186CD1560", Slot = "23")]
			protected override bool GetColor(SpriteRenderer sprite, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6CD1600", Offset = "0x6CD0600", VA = "0x186CD1600")]
			public SpriteTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1640", Offset = "0x6CD0640", VA = "0x186CD1640", Slot = "13")]
		protected override TintBehaviour<SpriteRenderer> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1720", Offset = "0x6CD0720", VA = "0x186CD1720")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x455ED80", Offset = "0x455DD80", VA = "0x18455ED80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Color TintColor
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xAE6AD0", Offset = "0xAE5AD0", VA = "0x180AE6AD0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x913D50", Offset = "0x912D50", VA = "0x180913D50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BlendType BlendMode
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7C2D80", Offset = "0x7C1D80", VA = "0x1807C2D80")]
				[CompilerGenerated]
				get
				{
					return default(BlendType);
				}
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7C2D70", Offset = "0x7C1D70", VA = "0x1807C2D70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x455ECF0", Offset = "0x455DCF0", VA = "0x18455ECF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x455E530", Offset = "0x455D530", VA = "0x18455E530", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x455E370", Offset = "0x455D370", VA = "0x18455E370", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x455E660", Offset = "0x455D660", VA = "0x18455E660", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x455E7C0", Offset = "0x455D7C0", VA = "0x18455E7C0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x86B920", Offset = "0x86A920", VA = "0x18086B920", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x952CC0", Offset = "0x951CC0", VA = "0x180952CC0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected BlendType BlendMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8C3A40", Offset = "0x8C2A40", VA = "0x1808C3A40")]
			get
			{
				return default(BlendType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x455F270", Offset = "0x455E270", VA = "0x18455F270")]
		public TintEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x455F2E0", Offset = "0x455E2E0", VA = "0x18455F2E0")]
		public TintEffect(PlaybackType playbackMode, float transitionDuration, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x455F150", Offset = "0x455E150", VA = "0x18455F150", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x455EF10", Offset = "0x455DF10", VA = "0x18455EF10", Slot = "10")]
		public override bool Evaluate(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract TintBehaviour<T> CreatePlayableAndBehaviour(PlayableGraph graph);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x455F0B0", Offset = "0x455E0B0", VA = "0x18455F0B0", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x455F010", Offset = "0x455E010", VA = "0x18455F010", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C4590", Offset = "0x8C3590", VA = "0x1808C4590", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7DE5F0", Offset = "0x7DD5F0", VA = "0x1807DE5F0", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xC77620", Offset = "0xC76620", VA = "0x180C77620", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3940", Offset = "0x6CD2940", VA = "0x186CD3940")]
		public TwoWayAnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD39A0", Offset = "0x6CD29A0", VA = "0x186CD39A0")]
		public TwoWayAnimationEffect(AnimationClip forwardClip, AnimationClip reverseClip, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3690", Offset = "0x6CD2690", VA = "0x186CD3690", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3540", Offset = "0x6CD2540", VA = "0x186CD3540", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5790", VA = "0x1807C6790", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public VisualStates VisualStates
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IStateVisualizerDriver.StateValueSetEventHandler StateValueSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6CD0500", Offset = "0x6CCF500", VA = "0x186CD0500", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6CD05A0", Offset = "0x6CCF5A0", VA = "0x186CD05A0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD04E0", Offset = "0x6CCF4E0", VA = "0x186CD04E0")]
		public void PushStateChange(int id, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80", Slot = "7")]
		public void SetVisualStates(VisualStates states)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB7F7F0", Offset = "0xB7E7F0", VA = "0x180B7F7F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0")]
				get
				{
					return (TKey)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public TValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x90DA20", Offset = "0x90CA20", VA = "0x18090DA20")]
				get
				{
					return (TValue)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xC3D550", Offset = "0xC3C550", VA = "0x180C3D550")]
			public SerializableDictionaryEntry(TKey key, TValue value)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<SerializableDictionaryEntry> entries;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4466490", Offset = "0x4465490", VA = "0x184466490", Slot = "46")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4466150", Offset = "0x4465150", VA = "0x184466150", Slot = "47")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4466890", Offset = "0x4465890", VA = "0x184466890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CD1800", Offset = "0x6CD0800", VA = "0x186CD1800", Slot = "4")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC62570", Offset = "0xC61570", VA = "0x180C62570")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
			get
			{
				return default(PlayableEffect.PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC62570", Offset = "0xC61570", VA = "0x180C62570")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public float Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x9471F0", Offset = "0x9461F0", VA = "0x1809471F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x947290", Offset = "0x946290", VA = "0x180947290")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float PreviousValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0xA007F0", Offset = "0x9FF7F0", VA = "0x180A007F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xA00E00", Offset = "0x9FFE00", VA = "0x180A00E00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public bool IsVariable
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5790", VA = "0x1807C6790")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7C6570", Offset = "0x7C5570", VA = "0x1807C6570")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6CD3080", Offset = "0x6CD2080", VA = "0x186CD3080")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public SerializableDictionary<int, State> StateContainers
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7C65A0", Offset = "0x7C55A0", VA = "0x1807C65A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1F70", Offset = "0x6CD0F70", VA = "0x186CD1F70")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CD20C0", Offset = "0x6CD10C0", VA = "0x186CD20C0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2D20", Offset = "0x6CD1D20", VA = "0x186CD2D20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1EA0", Offset = "0x6CD0EA0", VA = "0x186CD1EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6CD18D0", Offset = "0x6CD08D0", VA = "0x186CD18D0")]
		public void AddEffect(int stateId, IEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2000", Offset = "0x6CD1000", VA = "0x186CD2000")]
		public bool RemoveEffect(int stateId, IEffect effect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6CD28D0", Offset = "0x6CD18D0", VA = "0x186CD28D0")]
		private void UpdateStateValue(int stateId, float newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1AB0", Offset = "0x6CD0AB0", VA = "0x186CD1AB0")]
		private bool EvaluateEffects()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6CD29A0", Offset = "0x6CD19A0", VA = "0x186CD29A0")]
		private bool UpdateWeight(IAnimationMixableEffect mixableEffect, State state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2F50", Offset = "0x6CD1F50", VA = "0x186CD2F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CD3A50", Offset = "0x6CD2A50", VA = "0x186CD3A50")]
		public bool HasState(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA680", Offset = "0x8A9680", VA = "0x1808AA680")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color TargetColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAE6AD0", Offset = "0xAE5AD0", VA = "0x180AE6AD0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x913D50", Offset = "0x912D50", VA = "0x180913D50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6CCFE90", Offset = "0x6CCEE90", VA = "0x186CCFE90")]
			public ColorSwapBeahvior()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6CCF530", Offset = "0x6CCE530", VA = "0x186CCF530")]
			public void ApplyColor(Color color, Graphic target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6CCF5C0", Offset = "0x6CCE5C0", VA = "0x186CCF5C0")]
			public bool GetColor(Graphic target, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6CCF660", Offset = "0x6CCE660", VA = "0x186CCF660", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6CCF840", Offset = "0x6CCE840", VA = "0x186CCF840", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6CCF980", Offset = "0x6CCE980", VA = "0x186CCF980", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6CCFB10", Offset = "0x6CCEB10", VA = "0x186CCFB10", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEED3F0", Offset = "0xEEC3F0", VA = "0x180EED3F0")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x41BBE20", Offset = "0x41BAE20", VA = "0x1841BBE20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3280", Offset = "0x6CD2280", VA = "0x186CD3280", Slot = "6")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3110", Offset = "0x6CD2110", VA = "0x186CD3110", Slot = "8")]
		protected override bool SetValue(Color value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3400", Offset = "0x6CD2400", VA = "0x186CD3400")]
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
		[Cpp2IlInjected.Address(RVA = "0x455C770", Offset = "0x455B770", VA = "0x18455C770", Slot = "6")]
		public virtual void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x455C300", Offset = "0x455B300", VA = "0x18455C300", Slot = "7")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool SetValue(T value, float parameter);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x455C3E0", Offset = "0x455B3E0", VA = "0x18455C3E0")]
		private void OnActiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x455C530", Offset = "0x455B530", VA = "0x18455C530")]
		private void OnInactiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CD3470", Offset = "0x6CD2470", VA = "0x186CD3470", Slot = "8")]
		protected override bool SetValue(Material value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3500", Offset = "0x6CD2500", VA = "0x186CD3500")]
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
		private bool MDHOHBJHHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool OMIIKCOCFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool HPKKGACHNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x113")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool KPENFJCAJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool CNIMEPBAECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool IMIEAGLALLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x116")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool ANKCNKFNBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x117")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool PMFHABJPHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool PPBLPJLIAFF;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool PNBCBOBDPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB337E0", Offset = "0xB327E0", VA = "0x180B337E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool LHAGNHODLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6CD0FF0", Offset = "0x6CCFFF0", VA = "0x186CD0FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool LKPJBLHICLK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6CD1040", Offset = "0x6CD0040", VA = "0x186CD1040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool FPBBEBDDBNH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6CD1060", Offset = "0x6CD0060", VA = "0x186CD1060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool JFJDAAFMOOK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6CD1080", Offset = "0x6CD0080", VA = "0x186CD1080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UnityEvent HOLJNOJJMDG
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x98DFE0", Offset = "0x98CFE0", VA = "0x18098DFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA2F700", Offset = "0xA2E700", VA = "0x180A2F700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool BIDCINMPICP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6CD1010", Offset = "0x6CD0010", VA = "0x186CD1010", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IStateVisualizerDriver.StateValueSetEventHandler ANEJBPOBPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6CD0F40", Offset = "0x6CCFF40", VA = "0x186CD0F40", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6CD10A0", Offset = "0x6CD00A0", VA = "0x186CD10A0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0B60", Offset = "0x6CCFB60", VA = "0x186CD0B60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0B10", Offset = "0x6CCFB10", VA = "0x186CD0B10", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0C20", Offset = "0x6CCFC20", VA = "0x186CD0C20", Slot = "34")]
		public override void OnPointerEnter(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0C80", Offset = "0x6CCFC80", VA = "0x186CD0C80", Slot = "35")]
		public override void OnPointerExit(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0BC0", Offset = "0x6CCFBC0", VA = "0x186CD0BC0", Slot = "32")]
		public override void OnPointerDown(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0CE0", Offset = "0x6CCFCE0", VA = "0x186CD0CE0", Slot = "33")]
		public override void OnPointerUp(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0D30", Offset = "0x6CCFD30", VA = "0x186CD0D30", Slot = "36")]
		public override void OnSelect(BaseEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0AB0", Offset = "0x6CCFAB0", VA = "0x186CD0AB0", Slot = "37")]
		public override void OnDeselect(BaseEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0A40", Offset = "0x6CCFA40", VA = "0x186CD0A40", Slot = "26")]
		protected override void DoStateTransition(SelectionState DKOKOEEPCNN, bool DCJGPAELDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0D90", Offset = "0x6CCFD90", VA = "0x186CD0D90", Slot = "46")]
		public void SetVisualStates(VisualStates DECLMMLJMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0EC0", Offset = "0x6CCFEC0", VA = "0x186CD0EC0")]
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
