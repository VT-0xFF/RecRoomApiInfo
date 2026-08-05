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
			[Cpp2IlInjected.Address(RVA = "0x8965B0", Offset = "0x8959B0", VA = "0x1808965B0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xC65650", Offset = "0xC64A50", VA = "0x180C65650", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7DBDF0", Offset = "0x7DB1F0", VA = "0x1807DBDF0", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x93D9F0", Offset = "0x93CDF0", VA = "0x18093D9F0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BA3B40", Offset = "0x6BA2F40", VA = "0x186BA3B40")]
		public AnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BA3BA0", Offset = "0x6BA2FA0", VA = "0x186BA3BA0")]
		public AnimationEffect(AnimationClip clip, PlaybackType playbackMode, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BA3A80", Offset = "0x6BA2E80", VA = "0x186BA3A80", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BA4630", Offset = "0x6BA3A30", VA = "0x186BA4630", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4760", Offset = "0x6BA3B60", VA = "0x186BA4760", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4800", Offset = "0x6BA3C00", VA = "0x186BA4800")]
			public GraphicFadeBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4840", Offset = "0x6BA3C40", VA = "0x186BA4840", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4920", Offset = "0x6BA3D20", VA = "0x186BA4920")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BA4960", Offset = "0x6BA3D60", VA = "0x186BA4960", Slot = "22")]
			protected override void ApplyColor(Color color, Graphic graphic)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6BA49F0", Offset = "0x6BA3DF0", VA = "0x186BA49F0", Slot = "23")]
			protected override bool GetColor(Graphic graphic, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4A90", Offset = "0x6BA3E90", VA = "0x186BA4A90")]
			public GraphicTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4AD0", Offset = "0x6BA3ED0", VA = "0x186BA4AD0", Slot = "13")]
		protected override TintBehaviour<Graphic> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4BB0", Offset = "0x6BA3FB0", VA = "0x186BA4BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8965B0", Offset = "0x8959B0", VA = "0x1808965B0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x18F31C0", Offset = "0x18F25C0", VA = "0x1818F31C0", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4E20", Offset = "0x6BA4220", VA = "0x186BA4E20")]
		public PlayableAssetEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4D90", Offset = "0x6BA4190", VA = "0x186BA4D90")]
		public PlayableAssetEffect(StateVisualAsset playableAsset, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA4D30", Offset = "0x6BA4130", VA = "0x186BA4D30", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850900", VA = "0x180851500")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA4E80", Offset = "0x6BA4280", VA = "0x186BA4E80", Slot = "10")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA59B0", Offset = "0x6BA4DB0", VA = "0x186BA59B0")]
		public SetTargetsActiveEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5A00", Offset = "0x6BA4E00", VA = "0x186BA5A00")]
		public SetTargetsActiveEffect(List<GameObject> targets, bool invert = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5840", Offset = "0x6BA4C40", VA = "0x186BA5840", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA5B70", Offset = "0x6BA4F70", VA = "0x186BA5B70")]
		public SpriteSwapEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
		public void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5A80", Offset = "0x6BA4E80", VA = "0x186BA5A80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BA5BD0", Offset = "0x6BA4FD0", VA = "0x186BA5BD0", Slot = "22")]
			protected override void ApplyColor(Color color, SpriteRenderer sprite)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5C50", Offset = "0x6BA5050", VA = "0x186BA5C50", Slot = "23")]
			protected override bool GetColor(SpriteRenderer sprite, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5CF0", Offset = "0x6BA50F0", VA = "0x186BA5CF0")]
			public SpriteTintBehaviour()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5D30", Offset = "0x6BA5130", VA = "0x186BA5D30", Slot = "13")]
		protected override TintBehaviour<SpriteRenderer> CreatePlayableAndBehaviour(PlayableGraph graph)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5E10", Offset = "0x6BA5210", VA = "0x186BA5E10")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x448C2F0", Offset = "0x448B6F0", VA = "0x18448C2F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Color TintColor
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xAE23A0", Offset = "0xAE17A0", VA = "0x180AE23A0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x910430", Offset = "0x90F830", VA = "0x180910430")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public BlendType BlendMode
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
				[CompilerGenerated]
				get
				{
					return default(BlendType);
				}
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7C6770", Offset = "0x7C5B70", VA = "0x1807C6770")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x448C260", Offset = "0x448B660", VA = "0x18448C260")]
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
			[Cpp2IlInjected.Address(RVA = "0x448BAA0", Offset = "0x448AEA0", VA = "0x18448BAA0", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x448B8E0", Offset = "0x448ACE0", VA = "0x18448B8E0", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x448BBD0", Offset = "0x448AFD0", VA = "0x18448BBD0", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x448BD30", Offset = "0x448B130", VA = "0x18448BD30", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x868FA0", Offset = "0x8683A0", VA = "0x180868FA0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x950D70", Offset = "0x950170", VA = "0x180950D70", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected BlendType BlendMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BE4A0", Offset = "0x8BD8A0", VA = "0x1808BE4A0")]
			get
			{
				return default(BlendType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x448C7E0", Offset = "0x448BBE0", VA = "0x18448C7E0")]
		public TintEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x448C850", Offset = "0x448BC50", VA = "0x18448C850")]
		public TintEffect(PlaybackType playbackMode, float transitionDuration, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x448C6C0", Offset = "0x448BAC0", VA = "0x18448C6C0", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x448C480", Offset = "0x448B880", VA = "0x18448C480", Slot = "10")]
		public override bool Evaluate(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract TintBehaviour<T> CreatePlayableAndBehaviour(PlayableGraph graph);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x448C620", Offset = "0x448BA20", VA = "0x18448C620", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x448C580", Offset = "0x448B980", VA = "0x18448C580", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x8BEFE0", Offset = "0x8BE3E0", VA = "0x1808BEFE0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected override PlaybackType PlaybackMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "8")]
			get
			{
				return default(PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IAnimationMixableEffect.WeightType WeightMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE00", Offset = "0x7DB200", VA = "0x1807DBE00", Slot = "11")]
			get
			{
				return default(IAnimationMixableEffect.WeightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TransitionDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xC6F020", Offset = "0xC6E420", VA = "0x180C6F020", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8030", Offset = "0x6BA7430", VA = "0x186BA8030")]
		public TwoWayAnimationEffect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8090", Offset = "0x6BA7490", VA = "0x186BA8090")]
		public TwoWayAnimationEffect(AnimationClip forwardClip, AnimationClip reverseClip, float speed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7D80", Offset = "0x6BA7180", VA = "0x186BA7D80", Slot = "9")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7C30", Offset = "0x6BA7030", VA = "0x186BA7C30", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C4670", Offset = "0x7C3A70", VA = "0x1807C4670", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public VisualStates VisualStates
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event IStateVisualizerDriver.StateValueSetEventHandler StateValueSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4BF0", Offset = "0x6BA3FF0", VA = "0x186BA4BF0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4C90", Offset = "0x6BA4090", VA = "0x186BA4C90", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67594D0", Offset = "0x67588D0", VA = "0x1867594D0")]
		public void PushStateChange(int id, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80", Slot = "7")]
		public void SetVisualStates(VisualStates states)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xB78E50", Offset = "0xB78250", VA = "0x180B78E50")]
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
				[Cpp2IlInjected.Address(RVA = "0x919B20", Offset = "0x918F20", VA = "0x180919B20")]
				get
				{
					return (TKey)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public TValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x90B110", Offset = "0x90A510", VA = "0x18090B110")]
				get
				{
					return (TValue)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xC40350", Offset = "0xC3F750", VA = "0x180C40350")]
			public SerializableDictionaryEntry(TKey key, TValue value)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<SerializableDictionaryEntry> entries;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x438CD30", Offset = "0x438C130", VA = "0x18438CD30", Slot = "46")]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x438C9F0", Offset = "0x438BDF0", VA = "0x18438C9F0", Slot = "47")]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x438D130", Offset = "0x438C530", VA = "0x18438D130")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA5EF0", Offset = "0x6BA52F0", VA = "0x186BA5EF0", Slot = "4")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC5AF60", Offset = "0xC5A360", VA = "0x180C5AF60")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
			get
			{
				return default(PlayableEffect.PlaybackType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xC5AF60", Offset = "0xC5A360", VA = "0x180C5AF60")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public float Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x944730", Offset = "0x943B30", VA = "0x180944730")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x9447D0", Offset = "0x943BD0", VA = "0x1809447D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float PreviousValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x9FAB00", Offset = "0x9F9F00", VA = "0x1809FAB00")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x9FB0D0", Offset = "0x9FA4D0", VA = "0x1809FB0D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public bool IsVariable
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x7C4670", Offset = "0x7C3A70", VA = "0x1807C4670")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7C4680", Offset = "0x7C3A80", VA = "0x1807C4680")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6BA7770", Offset = "0x6BA6B70", VA = "0x186BA7770")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public SerializableDictionary<int, State> StateContainers
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Animator Animator
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6660", Offset = "0x6BA5A60", VA = "0x186BA6660")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA67B0", Offset = "0x6BA5BB0", VA = "0x186BA67B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7410", Offset = "0x6BA6810", VA = "0x186BA7410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6590", Offset = "0x6BA5990", VA = "0x186BA6590")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5FC0", Offset = "0x6BA53C0", VA = "0x186BA5FC0")]
		public void AddEffect(int stateId, IEffect effect)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6BA66F0", Offset = "0x6BA5AF0", VA = "0x186BA66F0")]
		public bool RemoveEffect(int stateId, IEffect effect)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6FC0", Offset = "0x6BA63C0", VA = "0x186BA6FC0")]
		private void UpdateStateValue(int stateId, float newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6BA61A0", Offset = "0x6BA55A0", VA = "0x186BA61A0")]
		private bool EvaluateEffects()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7090", Offset = "0x6BA6490", VA = "0x186BA7090")]
		private bool UpdateWeight(IAnimationMixableEffect mixableEffect, State state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7640", Offset = "0x6BA6A40", VA = "0x186BA7640")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA8140", Offset = "0x6BA7540", VA = "0x186BA8140")]
		public bool HasState(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A68F0", Offset = "0x8A5CF0", VA = "0x1808A68F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Color TargetColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAE23A0", Offset = "0xAE17A0", VA = "0x180AE23A0")]
				[CompilerGenerated]
				get
				{
					return default(Color);
				}
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x910430", Offset = "0x90F830", VA = "0x180910430")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6BA45A0", Offset = "0x6BA39A0", VA = "0x186BA45A0")]
			public ColorSwapBeahvior()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6BA3C40", Offset = "0x6BA3040", VA = "0x186BA3C40")]
			public void ApplyColor(Color color, Graphic target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6BA3CD0", Offset = "0x6BA30D0", VA = "0x186BA3CD0")]
			public bool GetColor(Graphic target, [Out] Color color)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6BA3D70", Offset = "0x6BA3170", VA = "0x186BA3D70", Slot = "13")]
			public override void OnGraphStart(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6BA3F50", Offset = "0x6BA3350", VA = "0x186BA3F50", Slot = "14")]
			public override void OnGraphStop(Playable playable)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4090", Offset = "0x6BA3490", VA = "0x186BA4090", Slot = "19")]
			public override void PrepareFrame(Playable playable, FrameData info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6BA4220", Offset = "0x6BA3620", VA = "0x186BA4220", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC9EB0", Offset = "0xEC92B0", VA = "0x180EC9EB0")]
			[CompilerGenerated]
			get
			{
				return default(Playable);
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3773CF0", Offset = "0x37730F0", VA = "0x183773CF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7970", Offset = "0x6BA6D70", VA = "0x186BA7970", Slot = "6")]
		public override void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7800", Offset = "0x6BA6C00", VA = "0x186BA7800", Slot = "8")]
		protected override bool SetValue(Color value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7AF0", Offset = "0x6BA6EF0", VA = "0x186BA7AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x447CF40", Offset = "0x447C340", VA = "0x18447CF40", Slot = "6")]
		public virtual void Setup(PlayableGraph graph, GameObject owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x447CAD0", Offset = "0x447BED0", VA = "0x18447CAD0", Slot = "7")]
		public virtual bool Evaluate(float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool SetValue(T value, float parameter);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x447CBB0", Offset = "0x447BFB0", VA = "0x18447CBB0")]
		private void OnActiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x447CD00", Offset = "0x447C100", VA = "0x18447CD00")]
		private void OnInactiveThemeValueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA7B60", Offset = "0x6BA6F60", VA = "0x186BA7B60", Slot = "8")]
		protected override bool SetValue(Material value, float parameter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7BF0", Offset = "0x6BA6FF0", VA = "0x186BA7BF0")]
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
		private bool PPGHJANHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool IENMEIIECCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x112")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool NGOAGLENIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x113")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool JMOHNKODKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool HHLICBNDONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool GDEALBAOBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x116")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private bool BFOEHCHNGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x117")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private bool CJPMGLMLNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool DLNCCAIKHNH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool GBBOKMIJDDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB2D110", Offset = "0xB2C510", VA = "0x180B2D110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool NNNIPMMGFCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6BA56E0", Offset = "0x6BA4AE0", VA = "0x186BA56E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HIFEINJMDKP
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5730", Offset = "0x6BA4B30", VA = "0x186BA5730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool LPEDAOADGEE
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5750", Offset = "0x6BA4B50", VA = "0x186BA5750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool ONELPFHFAOM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5770", Offset = "0x6BA4B70", VA = "0x186BA5770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UnityEvent IIPPBBEBPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8F7830", Offset = "0x8F6C30", VA = "0x1808F7830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA2AB50", Offset = "0xA29F50", VA = "0x180A2AB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool KGLFEHMMBBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5700", Offset = "0x6BA4B00", VA = "0x186BA5700", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IStateVisualizerDriver.StateValueSetEventHandler KKJBKIKIGLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5630", Offset = "0x6BA4A30", VA = "0x186BA5630", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6BA5790", Offset = "0x6BA4B90", VA = "0x186BA5790", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5250", Offset = "0x6BA4650", VA = "0x186BA5250", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5200", Offset = "0x6BA4600", VA = "0x186BA5200", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5310", Offset = "0x6BA4710", VA = "0x186BA5310", Slot = "34")]
		public override void OnPointerEnter(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5370", Offset = "0x6BA4770", VA = "0x186BA5370", Slot = "35")]
		public override void OnPointerExit(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6BA52B0", Offset = "0x6BA46B0", VA = "0x186BA52B0", Slot = "32")]
		public override void OnPointerDown(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6BA53D0", Offset = "0x6BA47D0", VA = "0x186BA53D0", Slot = "33")]
		public override void OnPointerUp(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5420", Offset = "0x6BA4820", VA = "0x186BA5420", Slot = "36")]
		public override void OnSelect(BaseEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6BA51A0", Offset = "0x6BA45A0", VA = "0x186BA51A0", Slot = "37")]
		public override void OnDeselect(BaseEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5130", Offset = "0x6BA4530", VA = "0x186BA5130", Slot = "26")]
		protected override void DoStateTransition(SelectionState KDDFGNJPJNG, bool LEPKMAKKPGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5480", Offset = "0x6BA4880", VA = "0x186BA5480", Slot = "46")]
		public void SetVisualStates(VisualStates CHCHCAGKBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BA55B0", Offset = "0x6BA49B0", VA = "0x186BA55B0")]
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
