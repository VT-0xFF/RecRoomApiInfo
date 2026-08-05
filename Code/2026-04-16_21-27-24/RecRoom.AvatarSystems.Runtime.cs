using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecNet;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
using RecRoom.Avatars.Serialization;
using RecRoom.Core.DataStructures.Tokens;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Debugging;
using RecRoom.Experiments;
using RecRoom.Initialization;
using RecRoom.JsonSerialization;
using RecRoom.Logger;
using RecRoom.MathUtils;
using RecRoom.MathUtils.Springs;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using RecRoom.Protobuf.Core;
using RootMotion.FinalIK;
using UJect;
using UJect.Injection;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x96DCBA0", Offset = "0x96DB9A0", VA = "0x1896DCBA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96DED50", Offset = "0x96DDB50", VA = "0x1896DED50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	internal class HKRIRDOYMTR : TZIOLLKFKSU
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public HKRIRDOYMTR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AvatarConfiguration avatarConfiguration;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly FVUSYGNKQQU BDRWGJTOSMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly KOXMOAICEEE GIYFZQNEZCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly ZTRGYEFJHNU ASEPTXKOQXD;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96DBE30", Offset = "0x96DAC30", VA = "0x1896DBE30")]
		[CXDXQIFYXBD.Root.GameOnly]
		[UsedImplicitly]
		internal static void LUGXJCIHNZD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96DCA30", Offset = "0x96DB830", VA = "0x1896DCA30")]
		[RecRoom.NoEngine.Common.Preserve]
		internal HKRIRDOYMTR([Inject(null)] FVUSYGNKQQU avatarDataMigrations, [Inject(null)] KOXMOAICEEE avatarDataSerializerProvider, [Inject(null)] ZTRGYEFJHNU outfitManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96DBEA0", Offset = "0x96DACA0", VA = "0x1896DBEA0", Slot = "5")]
		public AvatarData LZBAOTOEMMN(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96DAF70", Offset = "0x96D9D70", VA = "0x1896DAF70", Slot = "4")]
		public AvatarData BNCQHWPUCSJ(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96DBA60", Offset = "0x96DA860", VA = "0x1896DBA60", Slot = "6")]
		public OutfitDTO GNYNXSGBAIY(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x96DC800", Offset = "0x96DB600", VA = "0x1896DC800", Slot = "7")]
		public bool WMDPLMQJCKC(BPJEUCVRRRA a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96DBB70", Offset = "0x96DA970", VA = "0x1896DBB70", Slot = "8")]
		public bool HZPCNMEXCLW(OutfitDTO a, [Out][NotNullWhen(true)] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96DC770", Offset = "0x96DB570", VA = "0x1896DC770", Slot = "9")]
		public bool TWCQMPKRYQP(OutfitDTO a, [Out] JQMCULYOABB? outfitData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2160", Offset = "0x3AD0F60", VA = "0x183AD2160")]
		private bool VKYFNROEISN<a, b>(a a, VHOJFPPGYFK<a, b> b, [Out] b? result) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96DC890", Offset = "0x96DB690", VA = "0x1896DC890")]
		[CompilerGenerated]
		private SRLGFNKBGFU YXDXTQBPDEB(FaceFeatureType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x96DBC50", Offset = "0x96DAA50", VA = "0x1896DBC50")]
		[CompilerGenerated]
		private SRLGFNKBGFU LMWZZMBFWJM(FaceFeatureType a, <>c__DisplayClass6_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tested]
	internal class YPXGMWHTCCR : FVUSYGNKQQU
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate void MigrationFunc<in TData>(TData avatarData, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ZVHFLELJGRV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public RangeDataType OQKIRKDUAXQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AvatarVersion IWYOQMZMIKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AvatarVersion GHBFWBQSSXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public RangeMigration? KBFJOJWRXRL;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZVHFLELJGRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x96DED30", Offset = "0x96DDB30", VA = "0x1896DED30")]
			internal bool RAYASQPRUOB(RangeMigration a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x96DECB0", Offset = "0x96DDAB0", VA = "0x1896DECB0")]
			internal bool RASTVJVULCS(RangeMigration a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly ZTRGYEFJHNU ASEPTXKOQXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly LPZDEKKDVPV ODDJXNRQKTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MigrationFunc<AvatarData>?[] BDRWGJTOSMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MigrationFunc<JQMCULYOABB>?[] CEKNKSYMDWL;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96DDC40", Offset = "0x96DCA40", VA = "0x1896DDC40")]
		[CXDXQIFYXBD.Root.GameOnly]
		[UsedImplicitly]
		internal static void LUGXJCIHNZD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x96DE7C0", Offset = "0x96DD5C0", VA = "0x1896DE7C0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal YPXGMWHTCCR([Inject(null)] ZTRGYEFJHNU outfitManager, [Inject(null)] LPZDEKKDVPV debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x96DE560", Offset = "0x96DD360", VA = "0x1896DE560", Slot = "4")]
		public bool ZQXDUNRJNDB(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x96DE660", Offset = "0x96DD460", VA = "0x1896DE660", Slot = "5")]
		public bool ZQXDUNRJNDB(JQMCULYOABB a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x96DCE40", Offset = "0x96DBC40", VA = "0x1896DCE40")]
		private void BEUCZGGIRVG(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x96DCC20", Offset = "0x96DBA20", VA = "0x1896DCC20")]
		private void AOOTUNGOVVW(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x96DDF40", Offset = "0x96DCD40", VA = "0x1896DDF40")]
		private void UVIZRMPJCWB(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x96DE250", Offset = "0x96DD050", VA = "0x1896DE250")]
		private void ZBZNOSPGVTP(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x96DDA90", Offset = "0x96DC890", VA = "0x1896DDA90")]
		private void GUVGEQCVULY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x96DD9E0", Offset = "0x96DC7E0", VA = "0x1896DD9E0")]
		private void BWGDWNQUDYH(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x96DDB90", Offset = "0x96DC990", VA = "0x1896DDB90")]
		private void HKNPOXIHDQR(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96DDEF0", Offset = "0x96DCCF0", VA = "0x1896DDEF0")]
		private void SPIYJOBFOJS(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x96DDB60", Offset = "0x96DC960", VA = "0x1896DDB60")]
		private void HJWZFTIYBDD(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96DDCB0", Offset = "0x96DCAB0", VA = "0x1896DDCB0")]
		private void QFXQOMCAMUE(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96DDF70", Offset = "0x96DCD70", VA = "0x1896DDF70")]
		private void XKNZMQLUEUQ(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96DE280", Offset = "0x96DD080", VA = "0x1896DE280")]
		private AvatarData ZOWRQMSQQDP(AvatarData a, List<RangeMigration> b, AvatarVersion c, AvatarVersion d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96DDF00", Offset = "0x96DCD00", VA = "0x1896DDF00")]
		private float UMEZSZCVVON(float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96DDD30", Offset = "0x96DCB30", VA = "0x1896DDD30")]
		private (RangeMigration?, RangeMigration?) SLGTBXSDAGX(List<RangeMigration> a, RangeDataType b, AvatarVersion c, AvatarVersion d)
		{
			return default((RangeMigration?, RangeMigration?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface FVUSYGNKQQU
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ZQXDUNRJNDB(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZQXDUNRJNDB(JQMCULYOABB a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[TooltipAttribute("Type of pose")]
		public AnimationPoseType AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[TooltipAttribute("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[TooltipAttribute("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[TooltipAttribute("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[TooltipAttribute("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[TooltipAttribute("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[TooltipAttribute("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96BE780", Offset = "0x96BD580", VA = "0x1896BE780")]
		public void SZIFRVTZCZD(AnimationPoseSetting a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96BE8B0", Offset = "0x96BD6B0", VA = "0x1896BE8B0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[TooltipAttribute("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[TooltipAttribute("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96BF1C0", Offset = "0x96BDFC0", VA = "0x1896BF1C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96BF180", Offset = "0x96BDF80", VA = "0x1896BF180")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96BE8D0", Offset = "0x96BD6D0", VA = "0x1896BE8D0")]
		private void HOWLFBUCMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9647840", Offset = "0x9646640", VA = "0x189647840", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96BF1F0", Offset = "0x96BDFF0", VA = "0x1896BF1F0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[TooltipAttribute("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[TooltipAttribute("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[TooltipAttribute("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[TooltipAttribute("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[TooltipAttribute("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[TooltipAttribute("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[TooltipAttribute("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[TooltipAttribute("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96BF230", Offset = "0x96BE030", VA = "0x1896BF230")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum IKHandleType
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private IKHandleType handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96BF8D0", Offset = "0x96BE6D0", VA = "0x1896BF8D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96BF890", Offset = "0x96BE690", VA = "0x1896BF890")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96BF270", Offset = "0x96BE070", VA = "0x1896BF270")]
		private void HOWLFBUCMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9647840", Offset = "0x9646640", VA = "0x189647840", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96BF900", Offset = "0x96BE700", VA = "0x1896BF900")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, VPKEMEEDDUX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		protected AvatarModernBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Material modestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Texture2D BodyEmissiveSkinMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private DMWBGZGDKAI GVSGLYLCLEW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DMWBGZGDKAI GYVWECDVSHT
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xF61FD0", Offset = "0xF60DD0", VA = "0x180F61FD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform QEBZDHQIGRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x96C07F0", Offset = "0x96BF5F0", VA = "0x1896C07F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96BF930", Offset = "0x96BE730", VA = "0x1896BF930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x96C06B0", Offset = "0x96BF4B0", VA = "0x1896C06B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x96C0660", Offset = "0x96BF460", VA = "0x1896C0660")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x96C05F0", Offset = "0x96BF3F0", VA = "0x1896C05F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x96BF930", Offset = "0x96BE730", VA = "0x1896BF930", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x96BFD90", Offset = "0x96BEB90", VA = "0x1896BFD90", Slot = "6")]
		public DMWBGZGDKAI CreateAvatarSystem(string identifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x96C05F0", Offset = "0x96BF3F0", VA = "0x1896C05F0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x96BF9F0", Offset = "0x96BE7F0", VA = "0x1896BF9F0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x96C0700", Offset = "0x96BF500", VA = "0x1896C0700", Slot = "9")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xCE6140", Offset = "0xCE4F40", VA = "0x180CE6140")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AvatarModernBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Header("Turning")]
		[TooltipAttribute("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[TooltipAttribute("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[TooltipAttribute("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[TooltipAttribute("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[TooltipAttribute("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[TooltipAttribute("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[TooltipAttribute("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[TooltipAttribute("Lower than 1 makes the head bob less.")]
		public float BeanHeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[TooltipAttribute("Numbers under 1 = uses a slower locomotion animation. Above = faster.")]
		public float BeanLocomotionAnimationSelectionScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[TooltipAttribute("Numbers under 1 = plays the locomotion animations at a slower speed. Above = faster.")]
		public float BeanLocomotionAnimationSpeedScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[TooltipAttribute("Forward offset applied to bean animations.")]
		public float BeanHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[TooltipAttribute("Straighten the back by moving the pelvis instead of leaning towards the head.")]
		public float BeanStraightBackFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[TooltipAttribute("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[TooltipAttribute("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[TooltipAttribute("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[TooltipAttribute("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Header("Head Objects Placement")]
		[TooltipAttribute("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Header("Hand Placement")]
		[TooltipAttribute("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[TooltipAttribute("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float ClassicBeanHandSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Header("Watch")]
		[TooltipAttribute("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[TooltipAttribute("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[TooltipAttribute("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[TooltipAttribute("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Header("Performance Tuning")]
		[TooltipAttribute("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[TooltipAttribute("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[TooltipAttribute("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x405")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[TooltipAttribute("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Header("Leaning")]
		[TooltipAttribute("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[TooltipAttribute("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[TooltipAttribute("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[TooltipAttribute("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[TooltipAttribute("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[TooltipAttribute("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Header("Hand Blending")]
		[TooltipAttribute("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[TooltipAttribute("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[TooltipAttribute("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[TooltipAttribute("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[TooltipAttribute("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[TooltipAttribute("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[TooltipAttribute("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Header("Body Twisting")]
		[TooltipAttribute("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[TooltipAttribute("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[TooltipAttribute("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[TooltipAttribute("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[TooltipAttribute("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[TooltipAttribute("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[TooltipAttribute("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[TooltipAttribute("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[TooltipAttribute("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[TooltipAttribute("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[TooltipAttribute("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Header("Seated animation settings")]
		[TooltipAttribute("How much to twist shoulders when seated.")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[TooltipAttribute("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[TooltipAttribute("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[TooltipAttribute("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Hand Snapping")]
		[TooltipAttribute("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[TooltipAttribute("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[TooltipAttribute("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[TooltipAttribute("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[TooltipAttribute("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[TooltipAttribute("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Header("Foot Pinning")]
		[TooltipAttribute("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[TooltipAttribute("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[TooltipAttribute("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[TooltipAttribute("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[TooltipAttribute("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[TooltipAttribute("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[TooltipAttribute("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D4")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[TooltipAttribute("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Header("Shoe Settings")]
		[TooltipAttribute("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[TooltipAttribute("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[TooltipAttribute("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4FC")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[TooltipAttribute("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[TooltipAttribute("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x508")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[TooltipAttribute("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x510")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[TooltipAttribute("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x96C0810", Offset = "0x96BF610", VA = "0x1896C0810")]
		public AnimationPoseSetting GetAnimationPoseSetting(AnimationPoseType animationPoseType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x96C0840", Offset = "0x96BF640", VA = "0x1896C0840")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x96C0880", Offset = "0x96BF680", VA = "0x1896C0880")]
		public AvatarModernBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class GYVWECDVSHT : DMWBGZGDKAI
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class RYXYYDYPFQR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private Vector3 ONXSMQKUABW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Quaternion VZTTFLBAISP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private Vector3 STXEAYOHMYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private Transform HECKULQAUYN;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Vector3 HRKLIMKTEEA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0xEF85D0", Offset = "0xEF73D0", VA = "0x180EF85D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x96E9660", Offset = "0x96E8460", VA = "0x1896E9660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Quaternion RDCJBWZAKNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x1F27130", Offset = "0x1F25F30", VA = "0x181F27130")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x1F26F90", Offset = "0x1F25D90", VA = "0x181F26F90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public float UXFVTARZFHK
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x12AEE60", Offset = "0x12ADC60", VA = "0x1812AEE60")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x1A915E0", Offset = "0x1A903E0", VA = "0x181A915E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool MIKUAEEYIGX
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xCE7920", Offset = "0xCE6720", VA = "0x180CE7920")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xCE82C0", Offset = "0xCE70C0", VA = "0x180CE82C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool NQOEFERMBCV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B10", Offset = "0xCE6910", VA = "0x180CE7B10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0xCE7AF0", Offset = "0xCE68F0", VA = "0x180CE7AF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool XCSMSSADEFI
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B70", Offset = "0xCE6970", VA = "0x180CE7B70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xCE78F0", Offset = "0xCE66F0", VA = "0x180CE78F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float SXPWEIKSLSN
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xE0EB00", Offset = "0xE0D900", VA = "0x180E0EB00")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0xE0ED70", Offset = "0xE0DB70", VA = "0x180E0ED70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x96E97E0", Offset = "0x96E85E0", VA = "0x1896E97E0")]
			public void XACXXCKYPZP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x96E9320", Offset = "0x96E8120", VA = "0x1896E9320")]
			public void FOVBIKOIQCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x96E9110", Offset = "0x96E7F10", VA = "0x1896E9110")]
			public float FEZRHELLIOP(Vector3 a, Quaternion b, [In] AvatarFootSettings footSettings, float c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x96E8A30", Offset = "0x96E7830", VA = "0x1896E8A30")]
			public void FEVDKLLANHD(Vector3 a, Quaternion b, Transform c, float d, bool e, bool f, float g, float h, Transform i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x96E9330", Offset = "0x96E8130", VA = "0x1896E9330")]
			public void KSZNNPYZPIY(Transform a, Transform b, bool c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x96E9560", Offset = "0x96E8360", VA = "0x1896E9560")]
			private void NNXZCCPUOKU(Transform a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x96E9690", Offset = "0x96E8490", VA = "0x1896E9690")]
			public bool WXXQOQSWVMJ(Transform a, AvatarModernBodyConfiguration b, Vector3 c, float d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x96E9670", Offset = "0x96E8470", VA = "0x1896E9670")]
			public void VOKZKGLYWSW(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x96E97F0", Offset = "0x96E85F0", VA = "0x1896E97F0")]
			public RYXYYDYPFQR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class CPVUBOYDHHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public float OQMCHJQURBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private bool RFYQMDIYTXW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public AnimationPoseSetting AVPQPZAQYQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private float TRGWEMXTIYW;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x96E1C30", Offset = "0x96E0A30", VA = "0x1896E1C30")]
			public void WEJOPGGFVNA(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x96E1040", Offset = "0x96DFE40", VA = "0x1896E1040")]
			public void CWPNEKLNNYR(IKSolverVR.Arm a, float b, bool c, AvatarModernBodyConfiguration d, float e, bool f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x96E10D0", Offset = "0x96DFED0", VA = "0x1896E10D0")]
			private void DRNJSWCDDRQ(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x96E1850", Offset = "0x96E0650", VA = "0x1896E1850")]
			public void WCTNGTBJKWX(IKSolverVR.Arm a, Transform b, Transform c, Quaternion d, Vector3 e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x96E2260", Offset = "0x96E1060", VA = "0x1896E2260")]
			private (Vector3, Quaternion) YVSLSALZEPA(YOVGUUSBMJO a, Quaternion b, Vector3 c)
			{
				return default((Vector3, Quaternion));
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x96E2100", Offset = "0x96E0F00", VA = "0x1896E2100")]
			public void YTRXDWBOEUW(YOVGUUSBMJO a, IKSolverVR.Arm b, Quaternion c, Vector3 d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x96E1110", Offset = "0x96DFF10", VA = "0x1896E1110")]
			public void EOMUWYMZPNV(YOVGUUSBMJO a, IKSolverVR.Arm b, Quaternion c, Vector3 d, [In] AvatarModernBodyConfiguration config, [In] AvatarSystemUpdateState state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x96E1710", Offset = "0x96E0510", VA = "0x1896E1710")]
			public void HHDHYQABAXT(AnimationPoseType a, AvatarModernBodyConfiguration b, AvatarSystemUpdateState c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x96E1C60", Offset = "0x96E0A60", VA = "0x1896E1C60")]
			public void YLTSJLMRFOI(IKSolverVR.Arm a, Transform b, Vector3 c, float d, Quaternion e, Vector3 f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x96E26F0", Offset = "0x96E14F0", VA = "0x1896E26F0")]
			public CPVUBOYDHHP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum MovementUpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			Smooth,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			BalancedBasedOnDeadzones,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			ForceSnapIntoPlace
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass271_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public float strideScale;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <>c__DisplayClass271_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public Transform pelvis;
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly int AWKSTDIHPHO;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly int LFGVGTWLDXX;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly int RWNPJRZHTME;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly int MLCASFUHHDA;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly int GYRXTASPATH;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly int BIKDVPVVSMN;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly int CWFQUIJNPVH;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly int YLMXHGTKEGU;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly int RQUBGZCHDXW;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly int EDOOCXAQJLY;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly int OBRKAEFMPZR;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly int HICORAGXUIB;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static readonly int KYDJVPGQUPX;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly int ZSYYOPEVZFM;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly int HPLWWMZGORI;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly int WLXTTRRKYKL;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly int RPSRNGQHMVH;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly int UGYCGYIBIHP;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly int JGKDAYXYQXN;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly int ZESKXWNWCDX;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly int RRVPGIMWWVB;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly int OWVXNAVZOHW;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int LVCGAMBAOCA;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly int JSEJQSIJWTQ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly int UAPZZFDSVSD;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly int VBRNVOBPEZY;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly int QLCFEQWVCII;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly int FGUCHCAELRU;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static readonly int VTQMBPOSJUA;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly int PRBUSZIGRIF;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly int BHGLCRAZAWZ;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly int DWRGCARVRLS;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Vector3 XPNCXEDQDJL;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly int UOGMSQDWSEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool MEHPDIJPRVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool CVPTETUTSDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool ZIXAHBPUZOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool JLNNMBMWFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool FOAFSLTYHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool IGCWPDENYMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Vector3 XHWRVIQUUSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private string DDMSKFKPPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AvatarSystemInitState? PKEGGKLJCKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private AvatarSystemPlayerSetupState? GDFNXPNVXPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AvatarDisplaySystem ROFYZNNPNSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private RREOUCKQFCY GLHDOMAXAWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private YOVGUUSBMJO UKWQYSZJQYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private YOVGUUSBMJO PPCXKJYEMSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool UNXPSHGPVJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x299")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool YJXMWRJKZCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly RMRODFGKIKN PHIIJZUEWZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly CQXTYFLYXDU EAIHLUJCBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int HAYIKSMBJZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float TARAPVLBALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GameObject XCXQIDYPHSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Transform ZRTVXQLOCTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private Transform QRJYOQDUUSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private Transform IQUUIYEXOZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Transform BPHEBSLMCSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private float BIOBAYCEDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private float GLQJASIQOYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Vector3 JVFDLCLYRSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Quaternion XOQCKDGKJBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private Transform NFWMQANDJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private Transform MLQLUZXJWMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private Transform HIIIISHCSNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private HIOLXNETGPC SKKMKVWAQUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private CKAEZMOWUEX<ObscuredFloat> HHRQOYGFVVY;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ProfilerMarker QUQRCLWWIWK;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly ProfilerMarker QKSIEWYEGQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ProfilerMarker RJJFMWFLPVO;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly ProfilerMarker DGALIYWSXRD;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ProfilerMarker TZNCDLVKBEN;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly ProfilerMarker ANOUEOSMKRE;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly List<GYVWECDVSHT> DAIYMAPIPHY;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private static int LWJRODCWGSY;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> LOVZYDUELWF;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static int BWJAZTAPKNA;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static int WELQBJAMQST;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static int QOVZONGXXMY;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int LBOXLYRHSCV;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static float AGPQRIUJXCR;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private static int QQMVAIQWRBK;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static float OXGBMIUXDVF;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static float CULIKEXREPU;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static float VYMFTQFRAGW;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static float UTUMZMFOPYB;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static PMDDFTYMFOC RXYXCHCWGSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private float TYYUGTFKTLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private bool YVZFZBVRYUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private float CHUPIAOUJJS;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly int PCFZOYOEMWU;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly int YNYVRSBTZHR;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly int FSHQGAQKNOL;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static readonly int JTYXFRBRLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private RYXYYDYPFQR OAEUOXXMBGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private RYXYYDYPFQR DHEWQVCGUNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private float KBGLZZHCRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 KMFRSFRBGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3 CIBXGHSBUFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool VABOTJJSYUS;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly Quaternion VQYYRBJYSYP;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly Quaternion CJTRXJIOWTA;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Vector3 SKCFVHQHEFR;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly Vector3 DCRDBBAOMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float JPTCGMMFSDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private float GXJMNXQMESL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private CPVUBOYDHHP YYBRTAODCTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private CPVUBOYDHHP EWOTSMNSGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TOIIZGSLBUB VMEUJYOFYJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private JHTKWZTPKQI PHCVZXHKRZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly RWNFMFRUGCQ YMTBDIBHUDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float NJWINGOJSGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float DXKSGDLEGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly JHTKWZTPKQI VKEQTESGVLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 GYXSOGEWIXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 NUYBMLTQLOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float MMMIMPBGTUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private float GHBVWDEACMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly JHTKWZTPKQI PMUJNHTACCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly TOIIZGSLBUB QIDIQVIJPRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly JHTKWZTPKQI VLOVBAOFDBC;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DYNHRMPGIXT UNJBKSPMCUI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public DYNHRMPGIXT QBKOEEYVISP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AvatarConfiguration YAJGHHUVCKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x96C5FA0", Offset = "0x96C4DA0", VA = "0x1896C5FA0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AvatarBodyType LFXKRJNCSEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x96CEBD0", Offset = "0x96CD9D0", VA = "0x1896CEBD0", Slot = "24")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AvatarModernBodyConfiguration PIPDNHQUTGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x96D67F0", Offset = "0x96D55F0", VA = "0x1896D67F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Transform SJTSAKFZSNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x96D12C0", Offset = "0x96D00C0", VA = "0x1896D12C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Transform OXGWJBTHIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x96CBFB0", Offset = "0x96CADB0", VA = "0x1896CBFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private SkinnedMeshRenderer NBIKHPJHUBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x96D14A0", Offset = "0x96D02A0", VA = "0x1896D14A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Renderer[] BCXMQSYIBMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x96C19F0", Offset = "0x96C07F0", VA = "0x1896C19F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GameObject[] ZKXXLTHDATG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x96D83E0", Offset = "0x96D71E0", VA = "0x1896D83E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Animator NHGSRCVHUVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x96CE3C0", Offset = "0x96CD1C0", VA = "0x1896CE3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private VRIK LYHLJCCGRWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x96C3880", Offset = "0x96C2680", VA = "0x1896C3880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private YRYFAVSQIOI CIJPGYHDQEW
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x96D7B00", Offset = "0x96D6900", VA = "0x1896D7B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private YRYFAVSQIOI ZKEHALPUCWN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x96C3960", Offset = "0x96C2760", VA = "0x1896C3960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private YRYFAVSQIOI ALTZFREYWTC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x96C8F00", Offset = "0x96C7D00", VA = "0x1896C8F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private YRYFAVSQIOI NGSYCBHRVFM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x96D1710", Offset = "0x96D0510", VA = "0x1896D1710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private YRYFAVSQIOI SUYUIJJHAIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x96D8FE0", Offset = "0x96D7DE0", VA = "0x1896D8FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private YRYFAVSQIOI GCAYHBZMKXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x96C2A90", Offset = "0x96C1890", VA = "0x1896C2A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private YRYFAVSQIOI LXYDAWFIEYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x96D5100", Offset = "0x96D3F00", VA = "0x1896D5100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private YRYFAVSQIOI NLXWDHYHFAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x96C6190", Offset = "0x96C4F90", VA = "0x1896C6190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AvatarSystemPlayerSetupState LSXSIWUQXNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x96D1580", Offset = "0x96D0380", VA = "0x1896D1580", Slot = "16")]
			get
			{
				return default(AvatarSystemPlayerSetupState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BOBRVBCAJZS IRIRWQRJWDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x19F0EF0", Offset = "0x19EFCF0", VA = "0x1819F0EF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MLJWUMZUSLJ TPECCDPTMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1115360", Offset = "0x1114160", VA = "0x181115360", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public QURFJSQAQDF RIYPRPHCBQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x246FEF0", Offset = "0x246ECF0", VA = "0x18246FEF0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public QURFJSQAQDF XGNLTCGYFSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1657BF0", Offset = "0x16569F0", VA = "0x181657BF0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string VQRUGTSIEYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private Transform VXATCWRQUOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x96D0CB0", Offset = "0x96CFAB0", VA = "0x1896D0CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Transform HGYXXPYEFYP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x96CECB0", Offset = "0x96CDAB0", VA = "0x1896CECB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Transform ZYFHMKOQZDL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x96CB730", Offset = "0x96CA530", VA = "0x1896CB730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private Transform GFLFRYSUXUB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x96D50C0", Offset = "0x96D3EC0", VA = "0x1896D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private Transform WWIGSBOZXVC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x96CE320", Offset = "0x96CD120", VA = "0x1896CE320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool GFXIINXLQJT
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x96D44A0", Offset = "0x96D32A0", VA = "0x1896D44A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool SNGASLOEBSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x96D44A0", Offset = "0x96D32A0", VA = "0x1896D44A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private bool CSIQVAPALWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x96D62B0", Offset = "0x96D50B0", VA = "0x1896D62B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Transform FUGMQDNATVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x96CEAF0", Offset = "0x96CD8F0", VA = "0x1896CEAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GameObject VPJJVBBJETS
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x96C1C60", Offset = "0x96C0A60", VA = "0x1896C1C60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HeadLogicOffsets DRFHHOTHWAN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x96D0950", Offset = "0x96CF750", VA = "0x1896D0950", Slot = "34")]
			get
			{
				return default(HeadLogicOffsets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Transform VAZPTJCDCZP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1F0F430", Offset = "0x1F0E230", VA = "0x181F0F430", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Transform YOGGLROAYQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE51C40", Offset = "0xE50A40", VA = "0x180E51C40", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Transform QRUSGMRRITY
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1F0F660", Offset = "0x1F0E460", VA = "0x181F0F660", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform KNLMDDRWHVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1658440", Offset = "0x1657240", VA = "0x181658440", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NGDULZSWTUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x96D90C0", Offset = "0x96D7EC0", VA = "0x1896D90C0", Slot = "39")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float OJWHDIXEPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x96CBF60", Offset = "0x96CAD60", VA = "0x1896CBF60", Slot = "40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Transform EUZICMXMYQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x96C8AC0", Offset = "0x96C78C0", VA = "0x1896C8AC0", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Transform RPBTVTHAWAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2115000", Offset = "0x2113E00", VA = "0x182115000", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Transform YIVCWOZGBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2523AC0", Offset = "0x25228C0", VA = "0x182523AC0", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform IPUULMEECNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x27E45A0", Offset = "0x27E33A0", VA = "0x1827E45A0", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool HCIMNEVZLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x96C1410", Offset = "0x96C0210", VA = "0x1896C1410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ASNKAFBFVVA<DMWBGZGDKAI.FootEvent> DDHKQXCGDJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x20FE340", Offset = "0x20FD140", VA = "0x1820FE340", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool MSPRJDSVHRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x96C9BE0", Offset = "0x96C89E0", VA = "0x1896C9BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private bool ZXLOUDPBGRZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x96C2A10", Offset = "0x96C1810", VA = "0x1896C2A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x96CE780", Offset = "0x96CD580", VA = "0x1896CE780")]
		private float MNEAYSDOLXC(AvatarStance a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x96C6270", Offset = "0x96C5070", VA = "0x1896C6270")]
		private void EQQKJUKONGS([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x96C2310", Offset = "0x96C1110", VA = "0x1896C2310")]
		private float CDDCUKQYGNS([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x96C9B60", Offset = "0x96C8960", VA = "0x1896C9B60")]
		private float IFSKQTCBBUA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x96CE190", Offset = "0x96CCF90", VA = "0x1896CE190")]
		private void KVGXKWUSLIS(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x96D4CD0", Offset = "0x96D3AD0", VA = "0x1896D4CD0")]
		private void TNEGVJBAMZA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x96C18F0", Offset = "0x96C06F0", VA = "0x1896C18F0")]
		private void AWHAZXTCOVN([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x96DAAB0", Offset = "0x96D98B0", VA = "0x1896DAAB0")]
		public GYVWECDVSHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x96C1D00", Offset = "0x96C0B00", VA = "0x1896C1D00", Slot = "47")]
		public void BNSTRJICCVU(float a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x96C7D40", Offset = "0x96C6B40", VA = "0x1896C7D40", Slot = "48")]
		public void FDFMJAMGCPD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x96D92A0", Offset = "0x96D80A0", VA = "0x1896D92A0", Slot = "13")]
		public void YKEVKKINHRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x96C1DD0", Offset = "0x96C0BD0", VA = "0x1896C1DD0", Slot = "14")]
		public void BSURPYWUWLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x96D99C0", Offset = "0x96D87C0", VA = "0x1896D99C0", Slot = "15")]
		public void ZKASESSWKFW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x96D9150", Offset = "0x96D7F50", VA = "0x1896D9150", Slot = "26")]
		public Transform YJPSZZTKUZB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x96C5A50", Offset = "0x96C4850", VA = "0x1896C5A50", Slot = "27")]
		public Vector3? DQHZYJFBTOM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x96D4A00", Offset = "0x96D3800", VA = "0x1896D4A00", Slot = "7")]
		public void TBUUAGLKJZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x96C9C60", Offset = "0x96C8A60", VA = "0x1896C9C60")]
		private void IJUNBRNSGAL(AvatarModernBodyConfiguration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x96D8DA0", Offset = "0x96D7BA0", VA = "0x1896D8DA0", Slot = "8")]
		public void XUQGBLNDOLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x96D13A0", Offset = "0x96D01A0", VA = "0x1896D13A0")]
		private void QCACXAOECKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x96CB1E0", Offset = "0x96C9FE0", VA = "0x1896CB1E0")]
		private Vector3 IZNLGAGNAXW([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x96C23F0", Offset = "0x96C11F0", VA = "0x1896C23F0", Slot = "6")]
		public void CMNEZQGJAVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x96CA930", Offset = "0x96C9730", VA = "0x1896CA930")]
		private void IVREJPNRZBG(bool a, MovementUpdateMode b, AvatarModernBodyConfiguration c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x96C92E0", Offset = "0x96C80E0", VA = "0x1896C92E0", Slot = "9")]
		public void HKRNTRNTPKQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x96C7DA0", Offset = "0x96C6BA0", VA = "0x1896C7DA0")]
		private void FVXXEQRABSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x96C3A40", Offset = "0x96C2840", VA = "0x1896C3A40", Slot = "4")]
		public void DPRYWNFKOOL(string a, AvatarSystemInitState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x96D0D00", Offset = "0x96CFB00", VA = "0x1896D0D00", Slot = "5")]
		public void PKQCGVCKLNF(AvatarSystemPlayerSetupState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x96D1180", Offset = "0x96CFF80", VA = "0x1896D1180", Slot = "12")]
		public void PSPADBLYIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x96C86B0", Offset = "0x96C74B0", VA = "0x1896C86B0", Slot = "25")]
		public void GQRWKCGVCHF([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x96C2B70", Offset = "0x96C1970", VA = "0x1896C2B70")]
		private void DFAPDUGQPJK([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x96CE3B0", Offset = "0x96CD1B0", VA = "0x1896CE3B0", Slot = "28")]
		public void LVMUOKTGWUA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x96CE7A0", Offset = "0x96CD5A0", VA = "0x1896CE7A0", Slot = "29")]
		public void MUDTHDUFQUN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x96C23A0", Offset = "0x96C11A0", VA = "0x1896C23A0", Slot = "49")]
		public void CJBTCPSWFWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x96D9A90", Offset = "0x96D8890", VA = "0x1896D9A90", Slot = "30")]
		public void ZNOAVHWFWKO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x96CE730", Offset = "0x96CD530", VA = "0x1896CE730", Slot = "31")]
		public HandLogicOffsets MMWZGEFVZRX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x96C7DF0", Offset = "0x96C6BF0", VA = "0x1896C7DF0", Slot = "32")]
		public PlatformSpecificPlayerHandOffsets GDPRKHKIBFE()
		{
			return default(PlatformSpecificPlayerHandOffsets);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x96C18C0", Offset = "0x96C06C0", VA = "0x1896C18C0")]
		private void ASKREYPKRKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x96C9160", Offset = "0x96C7F60", VA = "0x1896C9160")]
		private void HKQIRIWJDHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x96D84C0", Offset = "0x96D72C0", VA = "0x1896D84C0")]
		private void XDTYXEFNEFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x96D09D0", Offset = "0x96CF7D0", VA = "0x1896D09D0")]
		private void PAISLRGUYZB(QPQCJTUZEKK a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x96C8FE0", Offset = "0x96C7DE0", VA = "0x1896C8FE0")]
		private void HFPJDINHBMV(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x96CE360", Offset = "0x96CD160", VA = "0x1896CE360", Slot = "33")]
		public Vector3 LUYEPACBYQY()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x96CECF0", Offset = "0x96CDAF0", VA = "0x1896CECF0")]
		private void NYCKODBZION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x96D97E0", Offset = "0x96D85E0", VA = "0x1896D97E0")]
		private void YMTBBTGULGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x96CA290", Offset = "0x96C9090", VA = "0x1896CA290")]
		private void IRUHLSIBTLV(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x96D6130", Offset = "0x96D4F30", VA = "0x1896D6130")]
		private float UUFXJAELYBO([In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x96D6050", Offset = "0x96D4E50", VA = "0x1896D6050")]
		private int USSMFUXOGXP([In] AvatarSystemUpdateRateState updateRateState)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x96CBA30", Offset = "0x96CA830", VA = "0x1896CBA30")]
		private void KKVMQTWOGIE(AvatarSystemUpdateState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x96CFA00", Offset = "0x96CE800", VA = "0x1896CFA00")]
		private static void OLFVWLZDIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x96C2BA0", Offset = "0x96C19A0", VA = "0x1896C2BA0")]
		private static void DJJBPKEBTNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x96D3DE0", Offset = "0x96D2BE0", VA = "0x1896D3DE0")]
		private float SFGIMODWAJR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x96D83B0", Offset = "0x96D71B0", VA = "0x1896D83B0")]
		private static int WTTRRMLGQFZ(GYVWECDVSHT a, GYVWECDVSHT b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x96C28C0", Offset = "0x96C16C0", VA = "0x1896C28C0", Slot = "42")]
		public AvatarSystemUpdateState CQXIOUSWIUX()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x96D3FB0", Offset = "0x96D2DB0", VA = "0x1896D3FB0")]
		private bool SHODRXPHEMX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x96D1690", Offset = "0x96D0490", VA = "0x1896D1690")]
		public void QHJZMKSKTHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x96D2260", Offset = "0x96D1060", VA = "0x1896D2260")]
		private (bool, bool) QYURYLAKNBJ()
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x96C5DC0", Offset = "0x96C4BC0", VA = "0x1896C5DC0")]
		private (float, float) DVFRCGWNUBW([In] AvatarSystemUpdateState state)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x96CC530", Offset = "0x96CB330", VA = "0x1896CC530")]
		private void KSOIXOCIUYJ([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x96D0630", Offset = "0x96CF430", VA = "0x1896D0630")]
		private void OPQWCBRQMFV([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x96CF5E0", Offset = "0x96CE3E0", VA = "0x1896CF5E0")]
		private void OGXOTVWLFFA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config, AvatarFootSettings a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x96C8A40", Offset = "0x96C7840", VA = "0x1896C8A40")]
		private float GRURGLPRTDE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x96D2440", Offset = "0x96D1240", VA = "0x1896D2440")]
		private void RGHKAIAJGPI(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x96C9B10", Offset = "0x96C8910", VA = "0x1896C9B10")]
		private float HRBXTMQNLTN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x96D9AE0", Offset = "0x96D88E0", VA = "0x1896D9AE0")]
		private void ZPDZSYTCZKP([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x96D7DD0", Offset = "0x96D6BD0", VA = "0x1896D7DD0")]
		private void WCTNGTBJKWX([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x96D7340", Offset = "0x96D6140", VA = "0x1896D7340")]
		private void VRMRNGONPYV([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x96CE4A0", Offset = "0x96CD2A0", VA = "0x1896CE4A0")]
		private void MDWCOXMQOJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x96C8B20", Offset = "0x96C7920", VA = "0x1896C8B20")]
		private void GVRMBSOXDFL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x96C1AD0", Offset = "0x96C08D0", VA = "0x1896C1AD0")]
		private void BGXNZOCCNHE([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x96CC090", Offset = "0x96CAE90", VA = "0x1896CC090")]
		private void KNFDNRWGZRL(YOVGUUSBMJO a, IKSolverVR.Arm b, Transform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x96D7740", Offset = "0x96D6540", VA = "0x1896D7740")]
		private void VVVOAEMKRBI(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x96C5BF0", Offset = "0x96C49F0", VA = "0x1896C5BF0")]
		private void DVEORDHFSCN(HandGestureType a, QURFJSQAQDF b, IKSolverVR.Arm c, float d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x96CC320", Offset = "0x96CB120", VA = "0x1896CC320")]
		private void KNXLKYHLSAZ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x96CEFE0", Offset = "0x96CDDE0", VA = "0x1896CEFE0")]
		private void NZWNDXPGLZC([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x96C1500", Offset = "0x96C0300", VA = "0x1896C1500")]
		protected void AGYZFMBJWRA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x96D6880", Offset = "0x96D5680", VA = "0x1896D6880")]
		private void VGRLJDKGNOM([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x96D2010", Offset = "0x96D0E10", VA = "0x1896D2010")]
		protected void QXUUIHTIVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x96D17F0", Offset = "0x96D05F0", VA = "0x1896D17F0")]
		private void QSHPVUNYCCO([In] AvatarSystemUpdateState state, [In] MovementUpdateMode movementUpdateMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x96D44F0", Offset = "0x96D32F0", VA = "0x1896D44F0")]
		private void SRXTZUBLKDL(AvatarSystemUpdateState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x96CB760", Offset = "0x96CA560", VA = "0x1896CB760")]
		private void JXSXTQFXCWA([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x96D51E0", Offset = "0x96D3FE0", VA = "0x1896D51E0")]
		private Vector3 UIUBAECPIYI([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x96CB660", Offset = "0x96CA460", VA = "0x1896CB660")]
		private void JRJWALWPCAJ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x96D63A0", Offset = "0x96D51A0", VA = "0x1896D63A0")]
		private float UZLLEICKTNG(float a, [In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x96D5F00", Offset = "0x96D4D00", VA = "0x1896D5F00")]
		private void USMKDKFKKEX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x96C0D20", Offset = "0x96BFB20", VA = "0x1896C0D20")]
		private void ADBCCJRJCAO([In] AvatarSystemUpdateState state, MovementUpdateMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x96D5700", Offset = "0x96D4500", VA = "0x1896D5700")]
		private float UMKKYSOZAKZ([In] AvatarSystemUpdateState systemUpdateState)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x96C7EB0", Offset = "0x96C6CB0", VA = "0x1896C7EB0")]
		private void GEHEALNDLOS(AvatarSystemUpdateState a, MovementUpdateMode b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x96CB400", Offset = "0x96CA200", VA = "0x1896CB400")]
		private static void JEHWTPGXLRZ(Transform a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x96C25E0", Offset = "0x96C13E0", VA = "0x1896C25E0")]
		private void CNEKIUIAZNI([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x96D6BD0", Offset = "0x96D59D0", VA = "0x1896D6BD0")]
		private void VMOVCOLCIVD([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x96D7BE0", Offset = "0x96D69E0", VA = "0x1896D7BE0")]
		private void VZNCORDFPVN(float a, [In] AvatarSystemUpdateState systemUpdateState, float b = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x96C9350", Offset = "0x96C8150", VA = "0x1896C9350")]
		private float HMGRPCEWAKK([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x96D80C0", Offset = "0x96D6EC0", VA = "0x1896D80C0")]
		private void WSNJQKPQCVE([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x96CFC20", Offset = "0x96CEA20", VA = "0x1896CFC20")]
		private void ONIWCRFQBRD([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x96D3020", Offset = "0x96D1E20", VA = "0x1896D3020")]
		private void RQWWLZMQVWR([In] AvatarSystemUpdateState systemUpdateState, float a, float b, Vector3 c, float d = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x96D33F0", Offset = "0x96D21F0", VA = "0x1896D33F0")]
		private void RXUEQGKKXRF(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x96CB7A0", Offset = "0x96CA5A0", VA = "0x1896CB7A0")]
		private void KBMXEHMFBBV(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x96D88E0", Offset = "0x96D76E0", VA = "0x1896D88E0")]
		private void XIJUYQZZMBX(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x96D9800", Offset = "0x96D8600", VA = "0x1896D9800")]
		public void ZDZYAZNLFMQ([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x96D46A0", Offset = "0x96D34A0", VA = "0x1896D46A0")]
		public void SVJOEMFHNHG([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x96C2170", Offset = "0x96C0F70", VA = "0x1896C2170")]
		[CompilerGenerated]
		internal static void CABLUNUGOQL(Transform a, IKSolverVR.Arm b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x96CB5B0", Offset = "0x96CA3B0", VA = "0x1896CB5B0")]
		[CompilerGenerated]
		internal static void JKCIESIMSZG(Vector3 a, Vector3 b, <>c__DisplayClass271_0 c, <>c__DisplayClass271_1 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x96CB360", Offset = "0x96CA160", VA = "0x1896CB360")]
		[CompilerGenerated]
		internal static void JCEWPCDZTDD(RYXYYDYPFQR a, RYXYYDYPFQR b, Vector3 c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x96C6080", Offset = "0x96C4E80", VA = "0x1896C6080")]
		[CompilerGenerated]
		internal static bool DYTBTQSGPEA(IKSolverVR.Arm a, CHCGQQKHRHW b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x96D4060", Offset = "0x96D2E60", VA = "0x1896D4060")]
		[CompilerGenerated]
		internal static float SJFBREOHYTC(Vector3 a, Vector3 b, Vector3 c, AvatarSystemUpdateState d, AvatarModernBodyConfiguration e, float f)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class AvatarSystemManager : YBTRMOONJKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Dictionary<string, DMWBGZGDKAI> EPYRKPDGOXN;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x96E0060", Offset = "0x96DEE60", VA = "0x1896E0060")]
		[CXDXQIFYXBD.Root]
		internal static void XMSLCFHXLMT(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x96DFE40", Offset = "0x96DEC40", VA = "0x1896DFE40", Slot = "4")]
		public DMWBGZGDKAI SBREKADKRHM(string a, AvatarSystemConfiguration b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x96DFC60", Offset = "0x96DEA60", VA = "0x1896DFC60", Slot = "5")]
		public void QADPNADLWWM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x96DFB30", Offset = "0x96DE930", VA = "0x1896DFB30", Slot = "6")]
		public string KNNATPTXLZF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x96E00D0", Offset = "0x96DEED0", VA = "0x1896E00D0")]
		private string ZQVFMZLWMRJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x96E0140", Offset = "0x96DEF40", VA = "0x1896E0140")]
		public AvatarSystemManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class IXHLUHWVTEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private Dictionary<string, Transform> ULUMOLASYQG;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool VLZKORUYSFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x96E7810", Offset = "0x96E6610", VA = "0x1896E7810")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x96E7690", Offset = "0x96E6490", VA = "0x1896E7690")]
			public void AIQUKZGDPWF(VRIK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
			public void DFCIPEKRHMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x96E77C0", Offset = "0x96E65C0", VA = "0x1896E77C0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x96E7850", Offset = "0x96E6650", VA = "0x1896E7850")]
			public IXHLUHWVTEN()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly IXHLUHWVTEN GWFAVUVKSOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private VPKEMEEDDUX HSXEKJRZITW;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x96E01C0", Offset = "0x96DEFC0", VA = "0x1896E01C0")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x96E04A0", Offset = "0x96DF2A0", VA = "0x1896E04A0")]
		private bool KRNLFDWAEPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x96E0530", Offset = "0x96DF330", VA = "0x1896E0530")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x96E05A0", Offset = "0x96DF3A0", VA = "0x1896E05A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x96E0540", Offset = "0x96DF340", VA = "0x1896E0540")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x96E0850", Offset = "0x96DF650", VA = "0x1896E0850")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct HandsOpenCloseAmount
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x96E75D0", Offset = "0x96E63D0", VA = "0x1896E75D0")]
			public (float, float) PNSEAQEYZFO(float a)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[TooltipAttribute("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			[TooltipAttribute("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private int VSRRUMDXOYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			[TooltipAttribute("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[TooltipAttribute("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[TooltipAttribute("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			[TooltipAttribute("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x96E6E10", Offset = "0x96E5C10", VA = "0x1896E6E10")]
			public void RKCBVVMJUOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x96E6CD0", Offset = "0x96E5AD0", VA = "0x1896E6CD0")]
			public (float, float) QGOFEQSCMVW(Animator a, AnimatorStateInfo b)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int YPHGNHAANSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Dictionary<int, HandPoseSetting> HXZRHTMWXQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x96E7390", Offset = "0x96E6190", VA = "0x1896E7390")]
		public void RKCBVVMJUOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x96E7150", Offset = "0x96E5F50", VA = "0x1896E7150")]
		public (float, float) PDMLVFEOOTM(Animator a, AvatarStance b, float c)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x96E6EF0", Offset = "0x96E5CF0", VA = "0x1896E6EF0")]
		private (float, float) HLQTNSJPSKO(Animator a, AnimatorStateInfo b, AvatarStance c, float d)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x96E75C0", Offset = "0x96E63C0", VA = "0x1896E75C0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[TooltipAttribute("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[TooltipAttribute("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[TooltipAttribute("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x96E78D0", Offset = "0x96E66D0", VA = "0x1896E78D0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x96E7A40", Offset = "0x96E6840", VA = "0x1896E7A40")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal abstract class LJVVOBSMJNX<a, b> : VHOJFPPGYFK<a, b> where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected readonly LPZDEKKDVPV ODDJXNRQKTK;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x68B7BF0", Offset = "0x68B69F0", VA = "0x1868B7BF0")]
		protected LJVVOBSMJNX(LPZDEKKDVPV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x68B79F0", Offset = "0x68B67F0", VA = "0x1868B79F0", Slot = "5")]
		public bool VKYFNROEISN(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Tested]
	public static class BYDVONADILT
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly Regex EFQKCYUTPAY;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x96E0920", Offset = "0x96DF720", VA = "0x1896E0920")]
		public static NKDKIVTTVNA DDPPTBPEQFI(AvatarItemId a, CombinationId b, Guid? c, Color? d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x96E0B20", Offset = "0x96DF920", VA = "0x1896E0B20")]
		public static AvatarItemDesc LSZSUCREZEJ(NKDKIVTTVNA a)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x371BB20", Offset = "0x371A920", VA = "0x18371BB20")]
		internal static a? NXJYGDLJLXJ<a>(string? input, GWBNKFMGVBT<a> a, LPZDEKKDVPV b, InvalidGuidHandling c, a d) where a : struct, KDOUHRCNUXS
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x371B730", Offset = "0x371A530", VA = "0x18371B730")]
		internal static DBLSZILXZOY KJYQSXEVXHI<b>(string? input, GWBNKFMGVBT<b> a, LPZDEKKDVPV b, InvalidGuidHandling c, b d) where b : struct, KDOUHRCNUXS
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x96E0C80", Offset = "0x96DFA80", VA = "0x1896E0C80")]
		internal static List<CustomAvatarItemVisualData> MKIJVZMAADE(IEnumerable<OutfitSelectionDTO>? selections)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x371B2A0", Offset = "0x371A0A0", VA = "0x18371B2A0")]
		internal static string HAESXPUOTTZ<c>(c a, GWBNKFMGVBT<c> b, LPZDEKKDVPV c) where c : KDOUHRCNUXS
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class CXOULEQDJZT : KOXMOAICEEE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public VHOJFPPGYFK<BPJEUCVRRRA, AvatarData> UMLWZTHVGNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public VHOJFPPGYFK<OutfitDTO, JQMCULYOABB> FRFFOTLGKPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public VHOJFPPGYFK<OutfitDTO, JQMCULYOABB> RJCOQLAZIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public SPLFCZLGYOC XGTBLYLIYZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public NBCLFPYTEDL NEEQKZBYOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x96E2760", Offset = "0x96E1560", VA = "0x1896E2760")]
		[CXDXQIFYXBD.Root.GameOnly]
		[UsedImplicitly]
		internal static void LUGXJCIHNZD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x96E27D0", Offset = "0x96E15D0", VA = "0x1896E27D0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal CXOULEQDJZT([Inject("UnitySerialization")] IINDILCXIBD jsonSerializationService, [Inject(null)] BRWVJCZRHBS runtimeMapperProvider, [Inject(null)] LPZDEKKDVPV debugLogger)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum AvatarParseErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		InvalidJsonOutfitSelectionsFormat,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		InvalidLegacyOutfitSelectionsFormat,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		InvalidBodyPart,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		InvalidGuid,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		ModernGuidMappingFailed,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		LegacyGuidMappingFailed,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		InvalidJsonAvatarData,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		MissingLegacyData
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarParseException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x96DFAA0", Offset = "0x96DE8A0", VA = "0x1896DFAA0")]
		public AvatarParseException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x96DFB00", Offset = "0x96DE900", VA = "0x1896DFB00")]
		public AvatarParseException(string message, Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x96DFAD0", Offset = "0x96DE8D0", VA = "0x1896DFAD0")]
		public AvatarParseException(AvatarParseErrorCode code, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x96DFA60", Offset = "0x96DE860", VA = "0x1896DFA60")]
		public AvatarParseException(AvatarParseErrorCode code, string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal abstract class FCGGWAQOBBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly IINDILCXIBD OBGQMYOARBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly BRWVJCZRHBS SFUYRNWEJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly LPZDEKKDVPV ODDJXNRQKTK;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x96E4640", Offset = "0x96E3440", VA = "0x1896E4640")]
		protected FCGGWAQOBBK(IINDILCXIBD a, BRWVJCZRHBS b, LPZDEKKDVPV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x96E3020", Offset = "0x96E1E20", VA = "0x1896E3020")]
		protected string DVSTSSOXJIX(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x96E4470", Offset = "0x96E3270", VA = "0x1896E4470")]
		protected string TGWQJRAIQKF(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x96E2CF0", Offset = "0x96E1AF0", VA = "0x1896E2CF0")]
		private AvatarOutfitSelectionData DDPPTBPEQFI(NKDKIVTTVNA a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x96E4330", Offset = "0x96E3130", VA = "0x1896E4330")]
		private static AvatarCustomizationSettingsData.AnchorParams QCIJIQAHOZP(ZGNLUMMZQWK? a)
		{
			return default(AvatarCustomizationSettingsData.AnchorParams);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface VHOJFPPGYFK<in a, b> where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VKYFNROEISN(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface KOXMOAICEEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		VHOJFPPGYFK<BPJEUCVRRRA, AvatarData> UMLWZTHVGNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		VHOJFPPGYFK<OutfitDTO, JQMCULYOABB> RJCOQLAZIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		SPLFCZLGYOC XGTBLYLIYZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal enum InvalidGuidHandling
	{
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		UseNull,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		UseEmpty,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Throw
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface NBCLFPYTEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyOutfitDataDTO NYKTBLQYXAJ(AvatarData a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface SPLFCZLGYOC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OutfitDTO NYKTBLQYXAJ(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Tested]
	internal class UMLWZTHVGNX : LJVVOBSMJNX<BPJEUCVRRRA, AvatarData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly BRWVJCZRHBS SFUYRNWEJAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly FRFFOTLGKPR RYCGTSHQZGP;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x96E9DC0", Offset = "0x96E8BC0", VA = "0x1896E9DC0")]
		public UMLWZTHVGNX(IINDILCXIBD a, BRWVJCZRHBS b, LPZDEKKDVPV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x96E9B10", Offset = "0x96E8910", VA = "0x1896E9B10", Slot = "6")]
		public override AvatarData Deserialize(BPJEUCVRRRA input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitNewtonsoftJsonSerializer : IINDILCXIBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private class COEXRMLZDTC : JsonConverter<DBLSZILXZOY>
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x96E0F60", Offset = "0x96DFD60", VA = "0x1896E0F60", Slot = "9")]
			public override void WriteJson(JsonWriter writer, DBLSZILXZOY? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x96E0E50", Offset = "0x96DFC50", VA = "0x1896E0E50", Slot = "10")]
			public override DBLSZILXZOY ReadJson(JsonReader reader, Type objectType, DBLSZILXZOY? existingValue, bool hasExistingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x96E1000", Offset = "0x96DFE00", VA = "0x1896E1000")]
			public COEXRMLZDTC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class XUVNCHTXYNI : JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override bool CanRead
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x96EA780", Offset = "0x96E9580", VA = "0x1896EA780", Slot = "5")]
			public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x96EA3E0", Offset = "0x96E91E0", VA = "0x1896EA3E0", Slot = "6")]
			public override bool CanConvert(Type objectType)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x96EA7D0", Offset = "0x96E95D0", VA = "0x1896EA7D0", Slot = "4")]
			public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x96EA5A0", Offset = "0x96E93A0", VA = "0x1896EA5A0")]
			private static bool DBPTKNPAAUZ(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
			public XUVNCHTXYNI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly JsonSerializerSettings YVRRBALJRPC;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x96E83D0", Offset = "0x96E71D0", VA = "0x1896E83D0")]
		internal OutfitNewtonsoftJsonSerializer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C840", Offset = "0x3D7B640", VA = "0x183D7C840", Slot = "4")]
		public string YXPDUFKBJBU<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C6E0", Offset = "0x3D7B4E0", VA = "0x183D7C6E0", Slot = "5")]
		public b IWUIFEVHXEX<b>(string a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitUtf8JsonSerializer : IINDILCXIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CD10", Offset = "0x3D7BB10", VA = "0x183D7CD10", Slot = "4")]
		public string YXPDUFKBJBU<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CBC0", Offset = "0x3D7B9C0", VA = "0x183D7CBC0", Slot = "5")]
		public b IWUIFEVHXEX<b>(string a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public OutfitUtf8JsonSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Tested]
	internal class FRFFOTLGKPR : LJVVOBSMJNX<OutfitDTO, JQMCULYOABB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private readonly IINDILCXIBD OBGQMYOARBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private readonly BRWVJCZRHBS SFUYRNWEJAH;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x96E6BA0", Offset = "0x96E59A0", VA = "0x1896E6BA0")]
		public FRFFOTLGKPR(IINDILCXIBD a, BRWVJCZRHBS b, LPZDEKKDVPV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x96E4C00", Offset = "0x96E3A00", VA = "0x1896E4C00", Slot = "6")]
		public override JQMCULYOABB Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x96E5410", Offset = "0x96E4210", VA = "0x1896E5410")]
		internal void FGPPNEEWIDK(string a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x96E5C00", Offset = "0x96E4A00", VA = "0x1896E5C00")]
		public IEnumerable<NKDKIVTTVNA> LAAQCKPMJNK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x96E5020", Offset = "0x96E3E20", VA = "0x1896E5020")]
		private IEnumerable<NKDKIVTTVNA> EYUXNZFTOXY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x96E5CC0", Offset = "0x96E4AC0", VA = "0x1896E5CC0")]
		internal IEnumerable<NKDKIVTTVNA> OYSDYRFVTYG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x96E5560", Offset = "0x96E4360", VA = "0x1896E5560")]
		private NKDKIVTTVNA HPKIWNVURZS(AvatarOutfitSelectionData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x96E6310", Offset = "0x96E5110", VA = "0x1896E6310")]
		private void YXWRDPAUCMQ(AvatarCustomizationSettingsData a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x96E58E0", Offset = "0x96E46E0", VA = "0x1896E58E0")]
		private NKDKIVTTVNA HPKIWNVURZS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x96E47B0", Offset = "0x96E35B0", VA = "0x1896E47B0")]
		internal static (AvatarBodyPart, string, string) AXJYGTPCLCQ(string a, LPZDEKKDVPV b)
		{
			return default((AvatarBodyPart, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x96E6110", Offset = "0x96E4F10", VA = "0x1896E6110")]
		private SRLGFNKBGFU? QXADZTYGHEM(string? a, Vector2 b, float c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x96E4AA0", Offset = "0x96E38A0", VA = "0x1896E4AA0")]
		private static ZGNLUMMZQWK DMFJAUYRGYG(AvatarCustomizationSettingsData.AnchorParams a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Tested]
	internal class NEEQKZBYOKA : FCGGWAQOBBK, NBCLFPYTEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x96E4640", Offset = "0x96E3440", VA = "0x1896E4640")]
		public NEEQKZBYOKA(IINDILCXIBD a, BRWVJCZRHBS b, LPZDEKKDVPV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x96E7DE0", Offset = "0x96E6BE0", VA = "0x1896E7DE0", Slot = "4")]
		public LegacyOutfitDataDTO NYKTBLQYXAJ(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x96E7CF0", Offset = "0x96E6AF0", VA = "0x1896E7CF0")]
		private string MTOBBRBLELY(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x96E81A0", Offset = "0x96E6FA0", VA = "0x1896E81A0")]
		private string XAGEQAGKRCX(NKDKIVTTVNA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Tested]
	internal class RJCOQLAZIBC : LJVVOBSMJNX<OutfitDTO, JQMCULYOABB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly IINDILCXIBD OBGQMYOARBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly VHOJFPPGYFK<OutfitDTO, JQMCULYOABB> MBFSEDFDHJP;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x96E8940", Offset = "0x96E7740", VA = "0x1896E8940")]
		public RJCOQLAZIBC(VHOJFPPGYFK<OutfitDTO, JQMCULYOABB> a, LPZDEKKDVPV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x96E8520", Offset = "0x96E7320", VA = "0x1896E8520", Slot = "6")]
		public override JQMCULYOABB Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Tested]
	internal class XGTBLYLIYZV : SPLFCZLGYOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly IINDILCXIBD OBGQMYOARBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly NBCLFPYTEDL DGLMJZKOVMT;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x96EA300", Offset = "0x96E9100", VA = "0x1896EA300")]
		public XGTBLYLIYZV(NBCLFPYTEDL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x96E9F80", Offset = "0x96E8D80", VA = "0x1896E9F80", Slot = "4")]
		public OutfitDTO NYKTBLQYXAJ(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x96DF120", Offset = "0x96DDF20", VA = "0x1896DF120")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6140", Offset = "0xCE4F40", VA = "0x180CE6140")]
		public AnimatorDebugUtil()
		{
		}
	}
}
namespace RecRoom.Avatars.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class NCVEZFGKZGQ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x96E7A60", Offset = "0x96E6860", VA = "0x1896E7A60")]
		public static AvatarItemDesc Deserialize(this EFMDGJOQNUH data)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x96E7B70", Offset = "0x96E6970", VA = "0x1896E7B70")]
		public static EFMDGJOQNUH NYKTBLQYXAJ(this AvatarItemDesc a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x96E7C90", Offset = "0x96E6A90", VA = "0x1896E7C90")]
		public static bool PFGDAQDBYIH(this AvatarItemDesc a)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x81B5330", Offset = "0x81B4130", VA = "0x1881B5330")]
			public AnchorParams(Vector2 normalizedPosition, Vector3 hemisphereOffsets, Vector3 hemisphereRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x96DF070", Offset = "0x96DDE70", VA = "0x1896DF070")]
			internal ZGNLUMMZQWK NYKTBLQYXAJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams JEWGDPZKMYI
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x96DF5A0", Offset = "0x96DE3A0", VA = "0x1896DF5A0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x18FCFB0", Offset = "0x18FBDB0", VA = "0x1818FCFB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xE201A0", Offset = "0xE1EFA0", VA = "0x180E201A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x10AD750", Offset = "0x10AC550", VA = "0x1810AD750")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1345600", Offset = "0x1344400", VA = "0x181345600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x96DF9D0", Offset = "0x96DE7D0", VA = "0x1896DF9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCF16C0", Offset = "0xCF04C0", VA = "0x180CF16C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xD37FD0", Offset = "0xD36DD0", VA = "0x180D37FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD781C0", Offset = "0xD76FC0", VA = "0x180D781C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x2A9C220", Offset = "0x2A9B020", VA = "0x182A9C220")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xFD6C60", Offset = "0xFD5A60", VA = "0x180FD6C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x12AEE30", Offset = "0x12ADC30", VA = "0x1812AEE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x149FD00", Offset = "0x149EB00", VA = "0x18149FD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xCEB600", Offset = "0xCEA400", VA = "0x180CEB600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xCEB5F0", Offset = "0xCEA3F0", VA = "0x180CEB5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x24CB640", Offset = "0x24CA440", VA = "0x1824CB640")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xFF24A0", Offset = "0xFF12A0", VA = "0x180FF24A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xD00ED0", Offset = "0xCFFCD0", VA = "0x180D00ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xD113B0", Offset = "0xD101B0", VA = "0x180D113B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xCF4890", Offset = "0xCF3690", VA = "0x180CF4890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xCF4810", Offset = "0xCF3610", VA = "0x180CF4810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4840", Offset = "0xCF3640", VA = "0x180CF4840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4830", Offset = "0xCF3630", VA = "0x180CF4830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xCF48F0", Offset = "0xCF36F0", VA = "0x180CF48F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4870", Offset = "0xCF3670", VA = "0x180CF4870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xD15EB0", Offset = "0xD14CB0", VA = "0x180D15EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xF8DEC0", Offset = "0xF8CCC0", VA = "0x180F8DEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xCF47C0", Offset = "0xCF35C0", VA = "0x180CF47C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3650", VA = "0x180CF4850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xDC75F0", Offset = "0xDC63F0", VA = "0x180DC75F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xE82A70", Offset = "0xE81870", VA = "0x180E82A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xCE9E60", Offset = "0xCE8C60", VA = "0x180CE9E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCE9E70", Offset = "0xCE8C70", VA = "0x180CE9E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2C30", VA = "0x180EA3E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1005370", Offset = "0x1004170", VA = "0x181005370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xEA3B10", Offset = "0xEA2910", VA = "0x180EA3B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xEA24D0", Offset = "0xEA12D0", VA = "0x180EA24D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public HelmetHairState UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x10B77D0", Offset = "0x10B65D0", VA = "0x1810B77D0")]
			get
			{
				return default(HelmetHairState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x10B6740", Offset = "0x10B5540", VA = "0x1810B6740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xDE4D70", Offset = "0xDE3B70", VA = "0x180DE4D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xDE5070", Offset = "0xDE3E70", VA = "0x180DE5070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x96DF9F0", Offset = "0x96DE7F0", VA = "0x1896DF9F0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x96DFA10", Offset = "0x96DE810", VA = "0x1896DFA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x96DF650", Offset = "0x96DE450", VA = "0x1896DF650")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AvatarBodyPart BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private MaterialCombinationId? OUZDEKXXVTJ;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x96DFA30", Offset = "0x96DE830", VA = "0x1896DFA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public AvatarUgcOutfitData()
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
