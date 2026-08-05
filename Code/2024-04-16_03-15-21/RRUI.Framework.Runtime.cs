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
			[Cpp2IlInjected.Address(RVA = "0x88D8E0", Offset = "0x88CAE0", VA = "0x18088D8E0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC60A40", Offset = "0xC5FC40", VA = "0x180C60A40", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7D2830", Offset = "0x7D1A30", VA = "0x1807D2830", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x932640", Offset = "0x931840", VA = "0x180932640", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B3B850", Offset = "0x6B3AA50", VA = "0x186B3B850")]
		public AnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B3B8B0", Offset = "0x6B3AAB0", VA = "0x186B3B8B0")]
		public AnimationEffect(AnimationClip clip, PlaybackType playbackMode, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B3B790", Offset = "0x6B3A990", VA = "0x186B3B790", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B3C340", Offset = "0x6B3B540", VA = "0x186B3C340", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C470", Offset = "0x6B3B670", VA = "0x186B3C470", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C510", Offset = "0x6B3B710", VA = "0x186B3C510")]
			public GraphicFadeBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C550", Offset = "0x6B3B750", VA = "0x186B3C550", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C630", Offset = "0x6B3B830", VA = "0x186B3C630")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B3C670", Offset = "0x6B3B870", VA = "0x186B3C670", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C700", Offset = "0x6B3B900", VA = "0x186B3C700", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C7A0", Offset = "0x6B3B9A0", VA = "0x186B3C7A0")]
			public GraphicTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C7E0", Offset = "0x6B3B9E0", VA = "0x186B3C7E0", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C8C0", Offset = "0x6B3BAC0", VA = "0x186B3C8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x88D8E0", Offset = "0x88CAE0", VA = "0x18088D8E0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x192E900", Offset = "0x192DB00", VA = "0x18192E900", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CB50", Offset = "0x6B3BD50", VA = "0x186B3CB50")]
		public PlayableAssetEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CAC0", Offset = "0x6B3BCC0", VA = "0x186B3CAC0")]
		public PlayableAssetEffect(StateVisualAsset playableAsset, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CA60", Offset = "0x6B3BC60", VA = "0x186B3CA60", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x853EA0", Offset = "0x8530A0", VA = "0x180853EA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x854310", Offset = "0x853510", VA = "0x180854310")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3CBB0", Offset = "0x6B3BDB0", VA = "0x186B3CBB0", Slot = "10")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3D6E0", Offset = "0x6B3C8E0", VA = "0x186B3D6E0")]
		public SetTargetsActiveEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D730", Offset = "0x6B3C930", VA = "0x186B3D730")]
		public SetTargetsActiveEffect(List<GameObject> targets, bool invert = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D570", Offset = "0x6B3C770", VA = "0x186B3D570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3D8A0", Offset = "0x6B3CAA0", VA = "0x186B3D8A0")]
		public SpriteSwapEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D7B0", Offset = "0x6B3C9B0", VA = "0x186B3D7B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B3D900", Offset = "0x6B3CB00", VA = "0x186B3D900", Slot = "22")]
			protected override void ApplyColor(Color color, SpriteRenderer sprite)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D980", Offset = "0x6B3CB80", VA = "0x186B3D980", Slot = "23")]
			protected override bool GetColor(SpriteRenderer sprite, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6B3DA20", Offset = "0x6B3CC20", VA = "0x186B3DA20")]
			public SpriteTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DA60", Offset = "0x6B3CC60", VA = "0x186B3DA60", Slot = "13")]
		protected override TintBehaviour<SpriteRenderer> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DB40", Offset = "0x6B3CD40", VA = "0x186B3DB40")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x4478A30", Offset = "0x4477C30", VA = "0x184478A30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Color TintColor
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x909750", Offset = "0x908950", VA = "0x180909750")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BlendType BlendMode
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B8130", VA = "0x1807B8F30")]
				[CompilerGenerated]
				get
				{
					return default(BlendType);
				}
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8860", VA = "0x1807B9660")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x44789A0", Offset = "0x4477BA0", VA = "0x1844789A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4478210", Offset = "0x4477410", VA = "0x184478210", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4478060", Offset = "0x4477260", VA = "0x184478060", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4478340", Offset = "0x4477540", VA = "0x184478340", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x44784A0", Offset = "0x44776A0", VA = "0x1844784A0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x860BD0", Offset = "0x85FDD0", VA = "0x180860BD0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9451E0", Offset = "0x9443E0", VA = "0x1809451E0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected BlendType BlendMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B8830", Offset = "0x8B7A30", VA = "0x1808B8830")]
			get
			{
				return default(BlendType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4478EE0", Offset = "0x44780E0", VA = "0x184478EE0")]
		public TintEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4478F50", Offset = "0x4478150", VA = "0x184478F50")]
		public TintEffect(PlaybackType playbackMode, float transitionDuration, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4478DD0", Offset = "0x4477FD0", VA = "0x184478DD0", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4478BA0", Offset = "0x4477DA0", VA = "0x184478BA0", Slot = "10")]
		public override bool Evaluate(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract TintBehaviour<T> CreatePlayableAndBehaviour(PlayableGraph graph);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4478D30", Offset = "0x4477F30", VA = "0x184478D30", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4478C90", Offset = "0x4477E90", VA = "0x184478C90", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B9370", Offset = "0x8B8570", VA = "0x1808B9370", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7D2840", Offset = "0x7D1A40", VA = "0x1807D2840", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xC66390", Offset = "0xC65590", VA = "0x180C66390", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FE50", Offset = "0x6B3F050", VA = "0x186B3FE50")]
		public TwoWayAnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FEB0", Offset = "0x6B3F0B0", VA = "0x186B3FEB0")]
		public TwoWayAnimationEffect(AnimationClip forwardClip, AnimationClip reverseClip, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FBA0", Offset = "0x6B3EDA0", VA = "0x186B3FBA0", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FA50", Offset = "0x6B3EC50", VA = "0x186B3FA50", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B77B0", Offset = "0x7B69B0", VA = "0x1807B77B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public VisualStates VisualStates
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IStateVisualizerDriver.StateValueSetEventHandler StateValueSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C920", Offset = "0x6B3BB20", VA = "0x186B3C920", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C9C0", Offset = "0x6B3BBC0", VA = "0x186B3C9C0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B3C900", Offset = "0x6B3BB00", VA = "0x186B3C900")]
		public void PushStateChange(int id, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150", Slot = "7")]
		public void SetVisualStates(VisualStates states)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB6EB80", Offset = "0xB6DD80", VA = "0x180B6EB80")]
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
				[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0")]
				get
				{
					return (TKey)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public TValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x8FFBE0", Offset = "0x8FEDE0", VA = "0x1808FFBE0")]
				get
				{
					return (TValue)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xC29F90", Offset = "0xC29190", VA = "0x180C29F90")]
			public SerializableDictionaryEntry(TKey key, TValue value)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<SerializableDictionaryEntry> entries;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x43868E0", Offset = "0x4385AE0", VA = "0x1843868E0", Slot = "46")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x43865C0", Offset = "0x43857C0", VA = "0x1843865C0", Slot = "47")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4386CA0", Offset = "0x4385EA0", VA = "0x184386CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3DC20", Offset = "0x6B3CE20", VA = "0x186B3DC20", Slot = "4")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC519B0", Offset = "0xC50BB0", VA = "0x180C519B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
			get
			{
				return default(PlayableEffect.PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC519B0", Offset = "0xC50BB0", VA = "0x180C519B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public float Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x939B60", Offset = "0x938D60", VA = "0x180939B60")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x939C00", Offset = "0x938E00", VA = "0x180939C00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float PreviousValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x9F2660", Offset = "0x9F1860", VA = "0x1809F2660")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9F2BF0", Offset = "0x9F1DF0", VA = "0x1809F2BF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public bool IsVariable
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x7B77B0", Offset = "0x7B69B0", VA = "0x1807B77B0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7B7540", Offset = "0x7B6740", VA = "0x1807B7540")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6B3F590", Offset = "0x6B3E790", VA = "0x186B3F590")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public SerializableDictionary<int, State> StateContainers
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7B7530", Offset = "0x7B6730", VA = "0x1807B7530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E3D0", Offset = "0x6B3D5D0", VA = "0x186B3E3D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E520", Offset = "0x6B3D720", VA = "0x186B3E520", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F230", Offset = "0x6B3E430", VA = "0x186B3F230")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E300", Offset = "0x6B3D500", VA = "0x186B3E300")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DCF0", Offset = "0x6B3CEF0", VA = "0x186B3DCF0")]
		public void AddEffect(int stateId, IEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E460", Offset = "0x6B3D660", VA = "0x186B3E460")]
		public bool RemoveEffect(int stateId, IEffect effect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B3ED30", Offset = "0x6B3DF30", VA = "0x186B3ED30")]
		private void UpdateStateValue(int stateId, float newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6B3DED0", Offset = "0x6B3D0D0", VA = "0x186B3DED0")]
		private bool EvaluateEffects()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EE00", Offset = "0x6B3E000", VA = "0x186B3EE00")]
		private bool UpdateWeight(IAnimationMixableEffect mixableEffect, State state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F460", Offset = "0x6B3E660", VA = "0x186B3F460")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3FF60", Offset = "0x6B3F160", VA = "0x186B3FF60")]
		public bool HasState(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89F080", Offset = "0x89E280", VA = "0x18089F080")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color TargetColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x909750", Offset = "0x908950", VA = "0x180909750")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6B3C2B0", Offset = "0x6B3B4B0", VA = "0x186B3C2B0")]
			public ColorSwapBeahvior()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6B3B950", Offset = "0x6B3AB50", VA = "0x186B3B950")]
			public void ApplyColor(Color color, Graphic target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6B3B9E0", Offset = "0x6B3ABE0", VA = "0x186B3B9E0")]
			public bool GetColor(Graphic target, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6B3BA80", Offset = "0x6B3AC80", VA = "0x186B3BA80", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6B3BC60", Offset = "0x6B3AE60", VA = "0x186B3BC60", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6B3BDA0", Offset = "0x6B3AFA0", VA = "0x186B3BDA0", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6B3BF30", Offset = "0x6B3B130", VA = "0x186B3BF30", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEDB930", Offset = "0xEDAB30", VA = "0x180EDB930")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x41A0570", Offset = "0x419F770", VA = "0x1841A0570")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F790", Offset = "0x6B3E990", VA = "0x186B3F790", Slot = "6")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F620", Offset = "0x6B3E820", VA = "0x186B3F620", Slot = "8")]
		protected override bool SetValue(Color value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6B3F910", Offset = "0x6B3EB10", VA = "0x186B3F910")]
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
		[Cpp2IlInjected.Address(RVA = "0x44765B0", Offset = "0x44757B0", VA = "0x1844765B0", Slot = "6")]
		public virtual void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4476170", Offset = "0x4475370", VA = "0x184476170", Slot = "7")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool SetValue(T value, float parameter);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4476250", Offset = "0x4475450", VA = "0x184476250")]
		private void OnActiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4476390", Offset = "0x4475590", VA = "0x184476390")]
		private void OnInactiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3F980", Offset = "0x6B3EB80", VA = "0x186B3F980", Slot = "8")]
		protected override bool SetValue(Material value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6B3FA10", Offset = "0x6B3EC10", VA = "0x186B3FA10")]
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
		private bool PPNCGCJLHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool BEJMEPEIJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool OEKBEIMGIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x113")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool IMAILOPAJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool BJFEFPAANDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool MLGLJCHAKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x116")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool OENCHFFNHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x117")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool PMAHFDDLLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool DKMLLKENEJJ;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EJECNOODHEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB236C0", Offset = "0xB228C0", VA = "0x180B236C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool MGJGDPFKALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D410", Offset = "0x6B3C610", VA = "0x186B3D410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool DINPMJFNJGG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D460", Offset = "0x6B3C660", VA = "0x186B3D460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool FANHDGHKMCP
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D480", Offset = "0x6B3C680", VA = "0x186B3D480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool PJCFKOIPBMH
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D4A0", Offset = "0x6B3C6A0", VA = "0x186B3D4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UnityEvent DBOIOEODDBF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x981820", Offset = "0x980A20", VA = "0x180981820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA20CC0", Offset = "0xA1FEC0", VA = "0x180A20CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DKJNEMPHMPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D430", Offset = "0x6B3C630", VA = "0x186B3D430", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IStateVisualizerDriver.StateValueSetEventHandler JMIAOIJCHOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D360", Offset = "0x6B3C560", VA = "0x186B3D360", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6B3D4C0", Offset = "0x6B3C6C0", VA = "0x186B3D4C0", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CF80", Offset = "0x6B3C180", VA = "0x186B3CF80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CF30", Offset = "0x6B3C130", VA = "0x186B3CF30", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D040", Offset = "0x6B3C240", VA = "0x186B3D040", Slot = "34")]
		public override void OnPointerEnter(PointerEventData NEMGAFJFCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D0A0", Offset = "0x6B3C2A0", VA = "0x186B3D0A0", Slot = "35")]
		public override void OnPointerExit(PointerEventData NEMGAFJFCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CFE0", Offset = "0x6B3C1E0", VA = "0x186B3CFE0", Slot = "32")]
		public override void OnPointerDown(PointerEventData NEMGAFJFCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D100", Offset = "0x6B3C300", VA = "0x186B3D100", Slot = "33")]
		public override void OnPointerUp(PointerEventData NEMGAFJFCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D150", Offset = "0x6B3C350", VA = "0x186B3D150", Slot = "36")]
		public override void OnSelect(BaseEventData NEMGAFJFCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CED0", Offset = "0x6B3C0D0", VA = "0x186B3CED0", Slot = "37")]
		public override void OnDeselect(BaseEventData NEMGAFJFCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6B3CE60", Offset = "0x6B3C060", VA = "0x186B3CE60", Slot = "26")]
		protected override void DoStateTransition(SelectionState GAEMKAANAID, bool NEEAPNKIGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D1B0", Offset = "0x6B3C3B0", VA = "0x186B3D1B0", Slot = "46")]
		public void SetVisualStates(VisualStates DCNHCABEFAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D2E0", Offset = "0x6B3C4E0", VA = "0x186B3D2E0")]
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
