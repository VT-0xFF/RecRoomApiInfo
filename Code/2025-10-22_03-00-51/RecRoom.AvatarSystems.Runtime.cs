using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x839B270", Offset = "0x8399870", VA = "0x18839B270")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B8DA0", Offset = "0x83B73A0", VA = "0x1883B8DA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	internal class YYVXFFXWLLW : ZKEWRVXTPBT
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public YYVXFFXWLLW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AvatarConfiguration avatarConfiguration;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly VLAUSGJURZN GQCLJLMPWKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly AOBGJARLJCL LKHRLKKESHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly UOSIMEINIFJ IMBIWSZJKCO;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83B88B0", Offset = "0x83B6EB0", VA = "0x1883B88B0")]
		[ZOKCDQOPSGU.Root.GameOnly]
		[UsedImplicitly]
		internal static void SMCYQCCCCSW(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83B8B90", Offset = "0x83B7190", VA = "0x1883B8B90")]
		[RecRoom.NoEngine.Common.Preserve]
		internal YYVXFFXWLLW([Inject(null)] VLAUSGJURZN avatarDataMigrations, [Inject(null)] AOBGJARLJCL avatarDataSerializerProvider, [Inject(null)] UOSIMEINIFJ outfitManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83B7ED0", Offset = "0x83B64D0", VA = "0x1883B7ED0", Slot = "5")]
		public AvatarData OISYTEZNBCQ(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83B70D0", Offset = "0x83B56D0", VA = "0x1883B70D0", Slot = "4")]
		public AvatarData FCDUFQWJJPA(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83B87A0", Offset = "0x83B6DA0", VA = "0x1883B87A0", Slot = "6")]
		public OutfitDTO QIFHUMNEFPL(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83B7D60", Offset = "0x83B6360", VA = "0x1883B7D60", Slot = "7")]
		public bool GYKUQALFPHR(NOBEVDNKZQB a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83B7DF0", Offset = "0x83B63F0", VA = "0x1883B7DF0", Slot = "8")]
		public bool HKLBFWYUITJ(OutfitDTO a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83B8920", Offset = "0x83B6F20", VA = "0x1883B8920", Slot = "9")]
		public bool TRWZMGJPRXM(OutfitDTO a, [Out] FFHOFKXHDEY? outfitData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9230", Offset = "0x3EE7830", VA = "0x183EE9230")]
		private bool PMFISQJBVYA<a, b>(a a, NNCDYHHEERZ<a, b> b, [Out] b? result) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83B7BC0", Offset = "0x83B61C0", VA = "0x1883B7BC0")]
		[CompilerGenerated]
		private JTJNJPVDFYD FXXPQYMHRQA(FaceFeatureType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83B89B0", Offset = "0x83B6FB0", VA = "0x1883B89B0")]
		[CompilerGenerated]
		private JTJNJPVDFYD WBMSLMQMQOH(FaceFeatureType a, <>c__DisplayClass6_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tested]
	internal class UQKHYZCIQME : VLAUSGJURZN
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate void MigrationFunc<in TData>(TData avatarData, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ZQYIBSVYBOY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public RangeDataType RMQTMWZAGUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AvatarVersion BXZEWNVSWBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AvatarVersion UNLQYPRGDZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public RangeMigration? KNTNUVFDUSG;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ZQYIBSVYBOY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x83B8D00", Offset = "0x83B7300", VA = "0x1883B8D00")]
			internal bool SQCEVNMSGKK(RangeMigration a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x83B8D20", Offset = "0x83B7320", VA = "0x1883B8D20")]
			internal bool SQHLSUGPPVT(RangeMigration a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UOSIMEINIFJ IMBIWSZJKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly LUVOEAWCUWK PYGTUNQHVVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MigrationFunc<AvatarData>?[] GQCLJLMPWKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MigrationFunc<FFHOFKXHDEY>?[] ELYDVICYSJY;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x839CA00", Offset = "0x839B000", VA = "0x18839CA00")]
		[ZOKCDQOPSGU.Root.GameOnly]
		[UsedImplicitly]
		internal static void SMCYQCCCCSW(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x839CE80", Offset = "0x839B480", VA = "0x18839CE80")]
		[RecRoom.NoEngine.Common.Preserve]
		internal UQKHYZCIQME([Inject(null)] UOSIMEINIFJ outfitManager, [Inject(null)] LUVOEAWCUWK debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x839B510", Offset = "0x8399B10", VA = "0x18839B510", Slot = "4")]
		public bool AYAWHVDPEEO(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x839B610", Offset = "0x8399C10", VA = "0x18839B610", Slot = "5")]
		public bool AYAWHVDPEEO(FFHOFKXHDEY a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x839BDC0", Offset = "0x839A3C0", VA = "0x18839BDC0")]
		private void OTXOQHRZTRL(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x839B2F0", Offset = "0x83998F0", VA = "0x18839B2F0")]
		private void AMQOXTOBGMF(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x839C950", Offset = "0x839AF50", VA = "0x18839C950")]
		private void PADVSNODHZA(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x839CA70", Offset = "0x839B070", VA = "0x18839CA70")]
		private void TMYZGXQWSMI(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x839CDB0", Offset = "0x839B3B0", VA = "0x18839CDB0")]
		private void ZLXVTDCVCXL(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x839B7B0", Offset = "0x8399DB0", VA = "0x18839B7B0")]
		private void GQVSERSJYUY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x839B870", Offset = "0x8399E70", VA = "0x18839B870")]
		private void LSKVPZCVRBE(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x839B860", Offset = "0x8399E60", VA = "0x18839B860")]
		private void KIQGFFLBUUN(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x839CAA0", Offset = "0x839B0A0", VA = "0x18839CAA0")]
		private void XPWGXRRJTKY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x839C980", Offset = "0x839AF80", VA = "0x18839C980")]
		private void RBNZITQLBMH(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x839BAE0", Offset = "0x839A0E0", VA = "0x18839BAE0")]
		private void NHKWATSTMYJ(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x839CAD0", Offset = "0x839B0D0", VA = "0x18839CAD0")]
		private AvatarData ZAYLXNQQJJG(AvatarData a, List<RangeMigration> b, AvatarVersion c, AvatarVersion d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x839B770", Offset = "0x8399D70", VA = "0x18839B770")]
		private float BXEWOARPEUQ(float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x839B920", Offset = "0x8399F20", VA = "0x18839B920")]
		private (RangeMigration?, RangeMigration?) MKVAMUOTGBO(List<RangeMigration> a, RangeDataType b, AvatarVersion c, AvatarVersion d)
		{
			return default((RangeMigration?, RangeMigration?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface VLAUSGJURZN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AYAWHVDPEEO(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AYAWHVDPEEO(FFHOFKXHDEY a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
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
		[Cpp2IlInjected.Address(RVA = "0x8398D10", Offset = "0x8397310", VA = "0x188398D10")]
		public void DOWPUHXEDMK(AnimationPoseSetting a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8398E40", Offset = "0x8397440", VA = "0x188398E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8399730", Offset = "0x8397D30", VA = "0x188399730")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83996F0", Offset = "0x8397CF0", VA = "0x1883996F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8398E60", Offset = "0x8397460", VA = "0x188398E60")]
		private void JWUJKNYDZSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x832ED20", Offset = "0x832D320", VA = "0x18832ED20", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8399760", Offset = "0x8397D60", VA = "0x188399760")]
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
		[Cpp2IlInjected.Address(RVA = "0x83997A0", Offset = "0x8397DA0", VA = "0x1883997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8399E20", Offset = "0x8398420", VA = "0x188399E20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8399DE0", Offset = "0x83983E0", VA = "0x188399DE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83997E0", Offset = "0x8397DE0", VA = "0x1883997E0")]
		private void JWUJKNYDZSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x832ED20", Offset = "0x832D320", VA = "0x18832ED20", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8399E50", Offset = "0x8398450", VA = "0x188399E50")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, BYZNVZLVJUS
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
		private GWUGCVKHRRN HKWFEDNUZDL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GWUGCVKHRRN YJMZLKOOBHW
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xB23D00", Offset = "0xB22300", VA = "0x180B23D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CHRKDDPFDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x839AD40", Offset = "0x8399340", VA = "0x18839AD40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8399E80", Offset = "0x8398480", VA = "0x188399E80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x839AC00", Offset = "0x8399200", VA = "0x18839AC00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x839ABB0", Offset = "0x83991B0", VA = "0x18839ABB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x839AB40", Offset = "0x8399140", VA = "0x18839AB40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8399E80", Offset = "0x8398480", VA = "0x188399E80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x839A2E0", Offset = "0x83988E0", VA = "0x18839A2E0", Slot = "6")]
		public GWUGCVKHRRN CreateAvatarSystem(string identifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x839AB40", Offset = "0x8399140", VA = "0x18839AB40", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8399F40", Offset = "0x8398540", VA = "0x188399F40", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x839AC50", Offset = "0x8399250", VA = "0x18839AC50", Slot = "9")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		[Cpp2IlInjected.Address(RVA = "0x839AD60", Offset = "0x8399360", VA = "0x18839AD60")]
		public AnimationPoseSetting GetAnimationPoseSetting(AnimationPoseType animationPoseType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x839AD90", Offset = "0x8399390", VA = "0x18839AD90")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x839ADD0", Offset = "0x83993D0", VA = "0x18839ADD0")]
		public AvatarModernBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class YJMZLKOOBHW : GWUGCVKHRRN
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class LJZFUSUSSVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private Vector3 HOXYAXKAXBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private Quaternion JSNSMMPAWHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Vector3 GUMOKAWCGRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private Transform XKAGPQWOJDM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Vector3 VMCVYOZGPKJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0xF7C070", Offset = "0xF7A670", VA = "0x180F7C070")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x83C0740", Offset = "0x83BED40", VA = "0x1883C0740")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Quaternion VOAVGEBCZEC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0x1FEC0E0", Offset = "0x1FEA6E0", VA = "0x181FEC0E0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x1FEBF40", Offset = "0x1FEA540", VA = "0x181FEBF40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public float USYQTBGHFJZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x1317960", Offset = "0x1315F60", VA = "0x181317960")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x1AC6860", Offset = "0x1AC4E60", VA = "0x181AC6860")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool ULANWZSUKBQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xAB3040", Offset = "0xAB1640", VA = "0x180AB3040")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0xAB31B0", Offset = "0xAB17B0", VA = "0x180AB31B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool JBZDHXRZNEU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAB3100", Offset = "0xAB1700", VA = "0x180AB3100")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xAB2930", Offset = "0xAB0F30", VA = "0x180AB2930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool HFIHINSHDYH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAB2940", Offset = "0xAB0F40", VA = "0x180AB2940")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0xAB2920", Offset = "0xAB0F20", VA = "0x180AB2920")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float HMDIHBOZRYM
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xE7D530", Offset = "0xE7BB30", VA = "0x180E7D530")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xE7DEC0", Offset = "0xE7C4C0", VA = "0x180E7DEC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x83C0710", Offset = "0x83BED10", VA = "0x1883C0710")]
			public void CKUEESCTSRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x83C0750", Offset = "0x83BED50", VA = "0x1883C0750")]
			public void KXKQKZXNOSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x83C1160", Offset = "0x83BF760", VA = "0x1883C1160")]
			public float XNOMBRGINEG(Vector3 a, Quaternion b, [In] AvatarFootSettings footSettings, float c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x83C0990", Offset = "0x83BEF90", VA = "0x1883C0990")]
			public void MADUIODRVMK(Vector3 a, Quaternion b, Transform c, float d, bool e, bool f, float g, float h, Transform i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x83C0760", Offset = "0x83BED60", VA = "0x1883C0760")]
			public void LARVPCLMXHT(Transform a, Transform b, bool c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x83C1060", Offset = "0x83BF660", VA = "0x1883C1060")]
			private void SZVERBOOWIP(Transform a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x83C1370", Offset = "0x83BF970", VA = "0x1883C1370")]
			public bool ZRRSVXMBLQI(Transform a, AvatarModernBodyConfiguration b, Vector3 c, float d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x83C0720", Offset = "0x83BED20", VA = "0x1883C0720")]
			public void FOBVBDKXOCH(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x83C14C0", Offset = "0x83BFAC0", VA = "0x1883C14C0")]
			public LJZFUSUSSVW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class YHSRENBAXBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public float FBHBYTPAVOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			private bool FSNADPTAYSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public AnimationPoseSetting FNMCXRIEQXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private float EJODTNVTVTH;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x83C40E0", Offset = "0x83C26E0", VA = "0x1883C40E0")]
			public void KUVRNPEYNVP(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x83C4530", Offset = "0x83C2B30", VA = "0x1883C4530")]
			public void ROVABVIMMQY(IKSolverVR.Arm a, float b, bool c, AvatarModernBodyConfiguration d, float e, bool f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x83C4110", Offset = "0x83C2710", VA = "0x1883C4110")]
			private void PLLFBCQSPHN(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x83C4150", Offset = "0x83C2750", VA = "0x1883C4150")]
			public void QONKIFBXLCA(IKSolverVR.Arm a, Transform b, Transform c, Quaternion d, Vector3 e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x83C3C50", Offset = "0x83C2250", VA = "0x1883C3C50")]
			private (Vector3, Quaternion) KJDNFTZNVUV(EUTCLIJHWWP a, Quaternion b, Vector3 c)
			{
				return default((Vector3, Quaternion));
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x83C45C0", Offset = "0x83C2BC0", VA = "0x1883C45C0")]
			public void YIUWFIDYOTJ(EUTCLIJHWWP a, IKSolverVR.Arm b, Quaternion c, Vector3 d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x83C3510", Offset = "0x83C1B10", VA = "0x1883C3510")]
			public void FUFDPFBGCLS(EUTCLIJHWWP a, IKSolverVR.Arm b, Quaternion c, Vector3 d, [In] AvatarModernBodyConfiguration config, [In] AvatarSystemUpdateState state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x83C3B10", Offset = "0x83C2110", VA = "0x1883C3B10")]
			public void GULLHCZCOAE(AnimationPoseType a, AvatarModernBodyConfiguration b, AvatarSystemUpdateState c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x83C3070", Offset = "0x83C1670", VA = "0x1883C3070")]
			public void BGGUZSANNYB(IKSolverVR.Arm a, Transform b, Vector3 c, float d, Quaternion e, Vector3 f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x83C4720", Offset = "0x83C2D20", VA = "0x1883C4720")]
			public YHSRENBAXBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum MovementUpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			Smooth,
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			BalancedBasedOnDeadzones,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			ForceSnapIntoPlace
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass268_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public float strideScale;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <>c__DisplayClass268_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public Transform pelvis;
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly int KYTMDRLNOMH;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly int SXNXJUTJHWQ;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly int MNKBKIPBODL;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly int VKBJXQFYZBJ;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly int OCZZLPWLFDM;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly int XCVEPPGOHYS;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly int JAKWIZXAAGI;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly int JOINBDPWUKJ;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly int VOUADZLYOUV;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly int BMWKGLPUCUL;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly int VFCIMVSEPEQ;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly int QLTGXVUIRDQ;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static readonly int HYHOZFHWREA;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly int AMLZDNEQYRT;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly int AYIDJUJKOGR;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly int VPLFZGHXTVS;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly int OICFGFPEVFC;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly int LPJZTQVDVPK;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly int WHUBJLNIGFG;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly int IGFNPGWDCTE;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly int DZUWVEEXBJE;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly int ACZTEVYLLIX;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int VGTURQTTDJX;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly int JJJLNRHMKKJ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly int HSIMCNARVNQ;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly int VWHHRTHPDBJ;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly int DRCRPSZNGMP;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly int AGMQQUZEVKT;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static readonly int PKIVOOTOAHN;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly int VTURITPBXPG;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly int NLYZPZITJVW;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly int ZCTQKQYBCLR;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Vector3 OSXQCRPOCLK;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly int WFRNJOGDITE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool YNYMHFEOGAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool TYIVKOPDGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool ECOXVJFVBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool JIPAKRGBBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool TYBDQSMWDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool CEOJWSJFKOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Vector3 IEATGXCLXPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private string AEXUPOJOAHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AvatarSystemInitState? KKSGNULRLQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private AvatarSystemPlayerSetupState? KVHGAZSNJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AvatarDisplaySystem NTYZEJVBANS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private MVIIBCGSTDN NTSNDFQAISH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private EUTCLIJHWWP DVZMBYMYQKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private EUTCLIJHWWP DAQINAIHDTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool JARYVPWLWDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x299")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool ZQPSZNSUJFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly NWPRWDYMTXO BWSYBDKCHYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly AYCTVZMEYXV GDDRWUAVLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int LABIRIYQCBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float JGYJLIVNVYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GameObject JUTZQTHQYNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Transform QVMNMEHOFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private Transform GACGFNQYPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private Transform TGVMXRCSRPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Transform KPBCJLWWTIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private float GMEARNFYJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private float FGFOSAUSFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Vector3 BCMRTRMHZQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Quaternion YWFTFHGNILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private Transform BCPQQXMDTUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private Transform INIVQFLXMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private Transform BOTCNULCXWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private UUZLMRCJSDN LMTGKJOUPYE;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly ProfilerMarker XCXJZKCLIZN;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ProfilerMarker SLWLMDBHBSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private ProfilerMarker GNYIGFFYMNX;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly ProfilerMarker FCUBDUUOTRG;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly ProfilerMarker XRDIDKSUAAQ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ProfilerMarker BYOPSVWBGPB;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly List<YJMZLKOOBHW> ZOVFJCPZWCT;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static int SMOALVUMTHT;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CIGZPTIRBWI;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private static int RLESLSVVASR;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static int JCXPIPUGOHA;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static int RAASBMMUJFZ;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static int BQTMAGHRDNC;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static float XMNYASGNJXQ;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static int KLWHBUIFVUT;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private static float QJYQZPLTTIM;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static float ENEGDUTZADZ;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static float KVAXFGBXXNR;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static float ZSATWXETTRQ;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static KVGXKUYRKYJ DUPOPJUUPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private float QXZJOFEKVLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool GCUPTIFEFZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private float MTYTVYWXYHD;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly int UYPXKEMWUQP;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly int PPNVLCDGAKE;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly int GIUFSDICORQ;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly int NJWQFBFJKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private LJZFUSUSSVW HUVEDFBUPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private LJZFUSUSSVW GXTVRDFBVVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private float PPVHQOWVEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Vector3 BJOAIXMRUFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 BSFFSZUNYKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool SBIASJOHNFB;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static readonly Quaternion DUUQLFKGBYK;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly Quaternion CMQFGTDRXOJ;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly Vector3 VBZTRHORNZO;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Vector3 CEGHZXYGUSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private float PNWXXQGGGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float LGHCPZDPDXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private YHSRENBAXBM MYZKJLLNPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private YHSRENBAXBM JNNIWGDOSBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private NIEWVWUACNS KXALZDFONHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private SXLBSNECCGD AYTNJUEJYUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly GIWUFOYSCTH GHFHIXBEKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float QRENDYCYRKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float DZPTBMGDEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly SXLBSNECCGD TYHUWHBIRNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Vector3 RQTDEGZLKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 YUBDKWTBZCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float YABELPRRTHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float EEPKGTGNJEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly SXLBSNECCGD VWKYDMOQLUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly NIEWVWUACNS KAUFMGZNNRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly SXLBSNECCGD VKREZLGVKSR;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ENIVEIKFIDY TBHEWVZTNMT
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ENIVEIKFIDY CGCMJEBOXSK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AvatarConfiguration HMXRQQLAATM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x83A3280", Offset = "0x83A1880", VA = "0x1883A3280", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AvatarBodyType SMAKSTOOTWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x83A1C00", Offset = "0x83A0200", VA = "0x1883A1C00", Slot = "24")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AvatarModernBodyConfiguration NASTYTLQDBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x83AEF20", Offset = "0x83AD520", VA = "0x1883AEF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Transform SDAFZPPDJZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x83B0850", Offset = "0x83AEE50", VA = "0x1883B0850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Transform QKRXQVICIYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83A6650", Offset = "0x83A4C50", VA = "0x1883A6650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private SkinnedMeshRenderer DQMSEINUXJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83A3130", Offset = "0x83A1730", VA = "0x1883A3130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Renderer[] RREJTSAEZLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83B1CE0", Offset = "0x83B02E0", VA = "0x1883B1CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GameObject[] VYCEBCZRWBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83B3CE0", Offset = "0x83B22E0", VA = "0x1883B3CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Animator TIWSBMKJRNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83A7E70", Offset = "0x83A6470", VA = "0x1883A7E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private VRIK FWTGDFBQSLK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83AF2A0", Offset = "0x83AD8A0", VA = "0x1883AF2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private WWHBNSZLZGH NNANEIDSUQH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83A2640", Offset = "0x83A0C40", VA = "0x1883A2640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private WWHBNSZLZGH AQTBOVAKPEA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83B6050", Offset = "0x83B4650", VA = "0x1883B6050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private WWHBNSZLZGH XAHBHXEGXQV
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83AF460", Offset = "0x83ADA60", VA = "0x1883AF460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private WWHBNSZLZGH JMQKMPSUFKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83A79A0", Offset = "0x83A5FA0", VA = "0x1883A79A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private WWHBNSZLZGH FTIZIFDTXAU
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83A2A60", Offset = "0x83A1060", VA = "0x1883A2A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private WWHBNSZLZGH PWJKAZSBWZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x839E450", Offset = "0x839CA50", VA = "0x18839E450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private WWHBNSZLZGH EEATPQFKXES
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83A0E60", Offset = "0x839F460", VA = "0x1883A0E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private WWHBNSZLZGH JFNYMEAKDIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83AF380", Offset = "0x83AD980", VA = "0x1883AF380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AvatarSystemPlayerSetupState DESUNTQYVNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x839FFD0", Offset = "0x839E5D0", VA = "0x18839FFD0", Slot = "16")]
			get
			{
				return default(AvatarSystemPlayerSetupState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public VSMSINQHKSN ZBDNXNQUSZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCB0C20", Offset = "0xCAF220", VA = "0x180CB0C20", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public SKRDKAHCZBM EVSKKKNOIIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xCB0C10", Offset = "0xCAF210", VA = "0x180CB0C10", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KJKKOCPYILY TCXPGCSWTIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCB11F0", Offset = "0xCAF7F0", VA = "0x180CB11F0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public KJKKOCPYILY SZWKNUOAHZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCB07A0", Offset = "0xCAEDA0", VA = "0x180CB07A0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string OXUPZUIFZAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private Transform AKYQAHLELBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83A3820", Offset = "0x83A1E20", VA = "0x1883A3820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Transform AHUHHOQNKXE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83AA2C0", Offset = "0x83A88C0", VA = "0x1883AA2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Transform TAEGGTYMEFK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83B1DC0", Offset = "0x83B03C0", VA = "0x1883B1DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private Transform MOSVQFVKEWU
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x83A3DA0", Offset = "0x83A23A0", VA = "0x1883A3DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private Transform WCREEADOBJN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x83B41B0", Offset = "0x83B27B0", VA = "0x1883B41B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool ULDJRWHADTW
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x83A0E10", Offset = "0x839F410", VA = "0x1883A0E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool YDVHJRHCOQI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83A0E10", Offset = "0x839F410", VA = "0x1883A0E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private bool VPFCVUHRXPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83AB440", Offset = "0x83A9A40", VA = "0x1883AB440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Transform LRCTXAAPGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83A3DE0", Offset = "0x83A23E0", VA = "0x1883A3DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GameObject EAYEYPAFMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x83A29C0", Offset = "0x83A0FC0", VA = "0x1883A29C0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HeadLogicOffsets DOAJKARQCQC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x83A2F00", Offset = "0x83A1500", VA = "0x1883A2F00", Slot = "34")]
			get
			{
				return default(HeadLogicOffsets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Transform KSDDVBSJHKW
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xB0A090", Offset = "0xB08690", VA = "0x180B0A090", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Transform HDAVXPCIPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xB23E80", Offset = "0xB22480", VA = "0x180B23E80", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Transform GMQRWEMLIER
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xB4E760", Offset = "0xB4CD60", VA = "0x180B4E760", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform FMYLQVTJEPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC1DC60", Offset = "0xC1C260", VA = "0x180C1DC60", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 LQHWAGMJCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x83ABF40", Offset = "0x83AA540", VA = "0x1883ABF40", Slot = "39")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float IEREMDUYHXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x83B3520", Offset = "0x83B1B20", VA = "0x1883B3520", Slot = "40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Transform PYDWCFKKPFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x83AAE30", Offset = "0x83A9430", VA = "0x1883AAE30", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Transform UCZUGIYDPWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xC1DB60", Offset = "0xC1C160", VA = "0x180C1DB60", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Transform XUBDPBAIJCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xB4E880", Offset = "0xB4CE80", VA = "0x180B4E880", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform UYKIBGLHOQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB24010", Offset = "0xB22610", VA = "0x180B24010", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool DEAHXHYGVFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x839F740", Offset = "0x839DD40", VA = "0x18839F740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public YQBTYEHUFCJ<GWUGCVKHRRN.FootEvent> MLXGFNOZPMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x83A2630", Offset = "0x83A0C30", VA = "0x1883A2630", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool VRBFWNNJKFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x83B0E50", Offset = "0x83AF450", VA = "0x1883B0E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private bool LERCOALYNFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x83B07D0", Offset = "0x83AEDD0", VA = "0x1883B07D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83A3BC0", Offset = "0x83A21C0", VA = "0x1883A3BC0")]
		private float JCKXJYXCKDD(AvatarStance a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83B41F0", Offset = "0x83B27F0", VA = "0x1883B41F0")]
		private void YYYKHOSEAFB([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83B03E0", Offset = "0x83AE9E0", VA = "0x1883B03E0")]
		private float TFTZJYKJXDT([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83B6130", Offset = "0x83B4730", VA = "0x1883B6130")]
		private float ZXIUXEQZSPL([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83AF930", Offset = "0x83ADF30", VA = "0x1883AF930")]
		private void SWHHLYGCENL(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83B3DC0", Offset = "0x83B23C0", VA = "0x1883B3DC0")]
		private void XRQUNIPLWZZ([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x839F080", Offset = "0x839D680", VA = "0x18839F080")]
		private void BUYCEIFCTBQ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83B6C60", Offset = "0x83B5260", VA = "0x1883B6C60")]
		public YJMZLKOOBHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83ABFD0", Offset = "0x83AA5D0", VA = "0x1883ABFD0", Slot = "13")]
		public void QAGXJSTPOYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x839F180", Offset = "0x839D780", VA = "0x18839F180", Slot = "14")]
		public void CACQKUYGUTA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x839EFB0", Offset = "0x839D5B0", VA = "0x18839EFB0", Slot = "15")]
		public void BPGACTZLLZD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83A97C0", Offset = "0x83A7DC0", VA = "0x1883A97C0", Slot = "26")]
		public Transform OQUQWSFWJRK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83A2770", Offset = "0x83A0D70", VA = "0x1883A2770", Slot = "27")]
		public Vector3? FYFSDGCKLUR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83A0F40", Offset = "0x839F540", VA = "0x1883A0F40", Slot = "7")]
		public void EIEYRBQHTEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x839D370", Offset = "0x839B970", VA = "0x18839D370")]
		private void ADNYCCZQRMA(AvatarModernBodyConfiguration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83B5C40", Offset = "0x83B4240", VA = "0x1883B5C40", Slot = "8")]
		public void ZBZEIRSQTII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83B1DF0", Offset = "0x83B03F0", VA = "0x1883B1DF0")]
		private void VGNPZSAYYKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x839F5C0", Offset = "0x839DBC0", VA = "0x18839F5C0")]
		private Vector3 DBNERWQSFNB([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83A3870", Offset = "0x83A1E70", VA = "0x1883A3870", Slot = "6")]
		public void JAGPVMTOSHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x839F830", Offset = "0x839DE30", VA = "0x18839F830")]
		private void DUHQKOHYWJF(bool a, MovementUpdateMode b, AvatarModernBodyConfiguration c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83AA300", Offset = "0x83A8900", VA = "0x1883AA300", Slot = "9")]
		public void PGYJUUZDUBL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83A8B90", Offset = "0x83A7190", VA = "0x1883A8B90")]
		private void OBHCSIEMZZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83AC510", Offset = "0x83AAB10", VA = "0x1883AC510", Slot = "4")]
		public void QDJEBDXRTVU(string a, AvatarSystemInitState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83B0F80", Offset = "0x83AF580", VA = "0x1883B0F80", Slot = "5")]
		public void UPAFYHMKIWE(AvatarSystemPlayerSetupState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83A8620", Offset = "0x83A6C20", VA = "0x1883A8620", Slot = "12")]
		public void NRFYIITLKYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83AE520", Offset = "0x83ACB20", VA = "0x1883AE520", Slot = "25")]
		public void QDZCVFGLRHQ([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83A3100", Offset = "0x83A1700", VA = "0x1883A3100")]
		private void HMGAFLPPEJN([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83B5C30", Offset = "0x83B4230", VA = "0x1883B5C30", Slot = "28")]
		public void ZBOJCACCFML(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83B29D0", Offset = "0x83B0FD0", VA = "0x1883B29D0", Slot = "29")]
		public void WSBHAYKVDQY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x839F520", Offset = "0x839DB20", VA = "0x18839F520", Slot = "47")]
		public void CCPTGQTNIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x839F570", Offset = "0x839DB70", VA = "0x18839F570", Slot = "30")]
		public void CWTDQDSENJX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83B1400", Offset = "0x83AFA00", VA = "0x1883B1400", Slot = "31")]
		public HandLogicOffsets UUCDDOBVTXW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83A2900", Offset = "0x83A0F00", VA = "0x1883A2900", Slot = "32")]
		public PlatformSpecificPlayerHandOffsets GFQGTNNMRTP()
		{
			return default(PlatformSpecificPlayerHandOffsets);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83A3210", Offset = "0x83A1810", VA = "0x1883A3210")]
		private void HQDZCXMKEFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x839E530", Offset = "0x839CB30", VA = "0x18839E530")]
		private void ASQXIJAAHSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83A7F80", Offset = "0x83A6580", VA = "0x1883A7F80")]
		private void NJZWDMKNNVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83A0B30", Offset = "0x839F130", VA = "0x1883A0B30")]
		private void EDIDRPHNUBQ(RDQYEZMSIPZ a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83AF540", Offset = "0x83ADB40", VA = "0x1883AF540")]
		private void RRUVCCAYPAU(RDQYEZMSIPZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83A2720", Offset = "0x83A0D20", VA = "0x1883A2720", Slot = "33")]
		public Vector3 FYAGCNRDNTP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83A3530", Offset = "0x83A1B30", VA = "0x1883A3530")]
		private void IUCRWZWBGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x839E6B0", Offset = "0x839CCB0", VA = "0x18839E6B0")]
		private void BATBAXVPMWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83B2140", Offset = "0x83B0740", VA = "0x1883B2140")]
		private void VTVKTUFFCIC(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83A2F80", Offset = "0x83A1580", VA = "0x1883A2F80")]
		private float HIDMOPLRCMX([In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x839DEB0", Offset = "0x839C4B0", VA = "0x18839DEB0")]
		private int AFRBUFBQPMY([In] AvatarSystemUpdateRateState updateRateState)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x839EA90", Offset = "0x839D090", VA = "0x18839EA90")]
		private void BLFGCPQMYVJ(AvatarSystemUpdateState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x83B3AE0", Offset = "0x83B20E0", VA = "0x1883B3AE0")]
		private static void XJCFNFWXGEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83A6D30", Offset = "0x83A5330", VA = "0x1883A6D30")]
		private static void MLXDEOOSAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83AF760", Offset = "0x83ADD60", VA = "0x1883AF760")]
		private float SPZWKVPHROW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x83A7F50", Offset = "0x83A6550", VA = "0x1883A7F50")]
		private static int NGDBMZECYCA(YJMZLKOOBHW a, YJMZLKOOBHW b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83A3A70", Offset = "0x83A2070", VA = "0x1883A3A70", Slot = "42")]
		public AvatarSystemUpdateState JAXFABWQCOS()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83AF6C0", Offset = "0x83ADCC0", VA = "0x1883AF6C0")]
		private bool SDQWZVTMPSA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83B09B0", Offset = "0x83AEFB0", VA = "0x1883B09B0")]
		public void UGICSHFDLTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83A3360", Offset = "0x83A1960", VA = "0x1883A3360")]
		private (bool, bool) IRZJNLSGGFO()
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83AE8B0", Offset = "0x83ACEB0", VA = "0x1883AE8B0")]
		private (float, float) QNORNODKLQT([In] AvatarSystemUpdateState state)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83A4290", Offset = "0x83A2890", VA = "0x1883A4290")]
		private void KQBMMWLBOSW([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83AB120", Offset = "0x83A9720", VA = "0x1883AB120")]
		private void PVCQHCKEDCW([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83A8770", Offset = "0x83A6D70", VA = "0x1883A8770")]
		private void NRPRBYPXMLX([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config, AvatarFootSettings a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83B0930", Offset = "0x83AEF30", VA = "0x1883B0930")]
		private float UAWHYPIDMNN()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83A8BE0", Offset = "0x83A71E0", VA = "0x1883A8BE0")]
		private void OKNUNCOISZD(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83B61B0", Offset = "0x83B47B0", VA = "0x1883B61B0")]
		private float ZZLKXRXXAQS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x839DF90", Offset = "0x839C590", VA = "0x18839DF90")]
		private void AFTKWSRLEUM([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83AEA90", Offset = "0x83AD090", VA = "0x1883AEA90")]
		private void QONKIFBXLCA([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83A7A80", Offset = "0x83A6080", VA = "0x1883A7A80")]
		private void NDAXICVNRDG([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83A08A0", Offset = "0x839EEA0", VA = "0x1883A08A0")]
		private void DZQTFSANGTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83B3570", Offset = "0x83B1B70", VA = "0x1883B3570")]
		private void XEYMHARLBLO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83A9910", Offset = "0x83A7F10", VA = "0x1883A9910")]
		private void OVLGPQDGNEF([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83A8390", Offset = "0x83A6990", VA = "0x1883A8390")]
		private void NOFNZEYHCPC(EUTCLIJHWWP a, IKSolverVR.Arm b, Transform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83A2B40", Offset = "0x83A1140", VA = "0x1883A2B40")]
		private void GPTRKLQDSWX(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83B5E80", Offset = "0x83B4480", VA = "0x1883B5E80")]
		private void ZNOBVJAZBTY(HandGestureType a, KJKKOCPYILY b, IKSolverVR.Arm c, float d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83A6440", Offset = "0x83A4A40", VA = "0x1883A6440")]
		private void LMRUUVJOZUI([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83A6730", Offset = "0x83A4D30", VA = "0x1883A6730")]
		private void MBRXSMBODKZ([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x839E6D0", Offset = "0x839CCD0", VA = "0x18839E6D0")]
		protected void BGQLHRKCIPR([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83B0A30", Offset = "0x83AF030", VA = "0x1883B0A30")]
		private void UGSALMHSLEB([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83B1EF0", Offset = "0x83B04F0", VA = "0x1883B1EF0")]
		protected void VIBMTUWSGJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83A9AA0", Offset = "0x83A80A0", VA = "0x1883A9AA0")]
		private void PCWNNGEKFMN([In] AvatarSystemUpdateState state, [In] MovementUpdateMode movementUpdateMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83AFAC0", Offset = "0x83AE0C0", VA = "0x1883AFAC0")]
		private void SZWWOZPBRYS(AvatarSystemUpdateState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83A3240", Offset = "0x83A1840", VA = "0x1883A3240")]
		private void HVKJHSITBTD([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x839D9A0", Offset = "0x839BFA0", VA = "0x18839D9A0")]
		private Vector3 AFATBWVYLJP([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83B0D80", Offset = "0x83AF380", VA = "0x1883B0D80")]
		private void UIPCLIKTUGO([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83B1450", Offset = "0x83AFA50", VA = "0x1883B1450")]
		private float UVJIFITEMSJ(float a, [In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83A1DF0", Offset = "0x83A03F0", VA = "0x1883A1DF0")]
		private void FKGMYOABNRI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83A1F40", Offset = "0x83A0540", VA = "0x1883A1F40")]
		private void FNGKABJYBYD([In] AvatarSystemUpdateState state, MovementUpdateMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83B2D20", Offset = "0x83B1320", VA = "0x1883B2D20")]
		private float WXBXOTPBGCU([In] AvatarSystemUpdateState systemUpdateState)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83AA640", Offset = "0x83A8C40", VA = "0x1883AA640")]
		private void PIGNUMWPMAV(AvatarSystemUpdateState a, MovementUpdateMode b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83AED70", Offset = "0x83AD370", VA = "0x1883AED70")]
		private static void QPSYHAMEZGE(Transform a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83AA370", Offset = "0x83A8970", VA = "0x1883AA370")]
		private void PHNTHQZSYRH([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83AFC70", Offset = "0x83AE270", VA = "0x1883AFC70")]
		private void TESVYBSLJIA([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83B27E0", Offset = "0x83B0DE0", VA = "0x1883B27E0")]
		private void WKYUGKFNTXQ(float a, [In] AvatarSystemUpdateState systemUpdateState, float b = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83A00E0", Offset = "0x839E6E0", VA = "0x1883A00E0")]
		private float DYSRVTETZXH([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83AEFB0", Offset = "0x83AD5B0", VA = "0x1883AEFB0")]
		private void RHLETHZMPCH([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83AB530", Offset = "0x83A9B30", VA = "0x1883AB530")]
		private void PXUNBXASUKK([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83A3EC0", Offset = "0x83A24C0", VA = "0x1883A3EC0")]
		private void KOKFNHWWTUY([In] AvatarSystemUpdateState systemUpdateState, float a, float b, Vector3 c, float d = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83A1210", Offset = "0x839F810", VA = "0x1883A1210")]
		private void EKUGTFOQHJU(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83AAE90", Offset = "0x83A9490", VA = "0x1883AAE90")]
		private void PSQYSDZPKSE(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83A5F80", Offset = "0x83A4580", VA = "0x1883A5F80")]
		private void KYDZZVXTPEG(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x83A3BE0", Offset = "0x83A21E0", VA = "0x1883A3BE0")]
		public void JHTEYEQGNWX([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83B0470", Offset = "0x83AEA70", VA = "0x1883B0470")]
		public void THSQTNNVQZH([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x83B3940", Offset = "0x83B1F40", VA = "0x1883B3940")]
		[CompilerGenerated]
		internal static void XGSBSSTKDEL(Transform a, IKSolverVR.Arm b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83B0ED0", Offset = "0x83AF4D0", VA = "0x1883B0ED0")]
		[CompilerGenerated]
		internal static void UOTCADHNFNP(Vector3 a, Vector3 b, <>c__DisplayClass268_0 c, <>c__DisplayClass268_1 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83A5EE0", Offset = "0x83A44E0", VA = "0x1883A5EE0")]
		[CompilerGenerated]
		internal static void KXXYYSOFHSC(LJZFUSUSSVW a, LJZFUSUSSVW b, Vector3 c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83A1CE0", Offset = "0x83A02E0", VA = "0x1883A1CE0")]
		[CompilerGenerated]
		internal static bool FFLOOUYINEE(IKSolverVR.Arm a, KBUWEQMSEPV b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x83B18A0", Offset = "0x83AFEA0", VA = "0x1883B18A0")]
		[CompilerGenerated]
		internal static float UYHIMUCVDKI(Vector3 a, Vector3 b, Vector3 c, AvatarSystemUpdateState d, AvatarModernBodyConfiguration e, float f)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class AvatarSystemManager : OXRKEQVYAYS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Dictionary<string, GWUGCVKHRRN> HFCHVELYHKK;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x83BA2F0", Offset = "0x83B88F0", VA = "0x1883BA2F0")]
		[ZOKCDQOPSGU.Root]
		internal static void FONBXMDWXTO(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x83BA0D0", Offset = "0x83B86D0", VA = "0x1883BA0D0", Slot = "4")]
		public GWUGCVKHRRN DCYFFXVXFUF(string a, AvatarSystemConfiguration b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83BA360", Offset = "0x83B8960", VA = "0x1883BA360", Slot = "5")]
		public void GWMAQDDDLOR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83BA5B0", Offset = "0x83B8BB0", VA = "0x1883BA5B0", Slot = "6")]
		public string RPJGNVPQIZG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83BA540", Offset = "0x83B8B40", VA = "0x1883BA540")]
		private string INKUFFRPJKS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x83BA6E0", Offset = "0x83B8CE0", VA = "0x1883BA6E0")]
		public AvatarSystemManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class UXVCAWBMNRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private Dictionary<string, Transform> DPVNMCADBJX;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool XEAGQKLOKWN
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x83C2E30", Offset = "0x83C1430", VA = "0x1883C2E30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x83C2E70", Offset = "0x83C1470", VA = "0x1883C2E70")]
			public void JVREPHFEJSS(VRIK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
			public void KMJMPRSNWMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x83C2FA0", Offset = "0x83C15A0", VA = "0x1883C2FA0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83C2FF0", Offset = "0x83C15F0", VA = "0x1883C2FF0")]
			public UXVCAWBMNRI()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly UXVCAWBMNRI MYZSHUSWUPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private BYZNVZLVJUS ORWZOKSNMLN;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83BA760", Offset = "0x83B8D60", VA = "0x1883BA760")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83BAD60", Offset = "0x83B9360", VA = "0x1883BAD60")]
		private bool XCEEVVLPTSC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83BAA40", Offset = "0x83B9040", VA = "0x1883BAA40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83BAAB0", Offset = "0x83B90B0", VA = "0x1883BAAB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83BAA50", Offset = "0x83B9050", VA = "0x1883BAA50")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83BADF0", Offset = "0x83B93F0", VA = "0x1883BADF0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x83BD680", Offset = "0x83BBC80", VA = "0x1883BD680")]
			public (float, float) QBKRMMQJDJT(float a)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[TooltipAttribute("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			[TooltipAttribute("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			private int GYIXTIJBPYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			[TooltipAttribute("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			[TooltipAttribute("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[TooltipAttribute("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[TooltipAttribute("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x83BCD80", Offset = "0x83BB380", VA = "0x1883BCD80")]
			public void FTYJJGFKYMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x83BCE60", Offset = "0x83BB460", VA = "0x1883BCE60")]
			public (float, float) IPKWDSJGERT(Animator a, AnimatorStateInfo b)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly int BAPJTITYIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Dictionary<int, HandPoseSetting> ISGETXSYYUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83BD200", Offset = "0x83BB800", VA = "0x1883BD200")]
		public void FTYJJGFKYMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83BD3E0", Offset = "0x83BB9E0", VA = "0x1883BD3E0")]
		public (float, float) QCCAZERHDVD(Animator a, AvatarStance b, float c)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83BCFA0", Offset = "0x83BB5A0", VA = "0x1883BCFA0")]
		private (float, float) BLQSJUROOYZ(Animator a, AnimatorStateInfo b, AvatarStance c, float d)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83BD670", Offset = "0x83BBC70", VA = "0x1883BD670")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[TooltipAttribute("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[TooltipAttribute("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[TooltipAttribute("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x83C1E30", Offset = "0x83C0430", VA = "0x1883C1E30", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83C1F90", Offset = "0x83C0590", VA = "0x1883C1F90")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal abstract class KETZPGYOOHG<a, b> : NNCDYHHEERZ<a, b> where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		protected readonly LUVOEAWCUWK PYGTUNQHVVB;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x53ADC90", Offset = "0x53AC290", VA = "0x1853ADC90")]
		protected KETZPGYOOHG(LUVOEAWCUWK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x53ADBF0", Offset = "0x53AC1F0", VA = "0x1853ADBF0", Slot = "5")]
		public bool PMFISQJBVYA(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Tested]
	public static class OTXJYWEYGCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly Regex VZBWCYPQVYH;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x83C2110", Offset = "0x83C0710", VA = "0x1883C2110")]
		public static DOUQKMCCEPT OZETPTTQAEH(AvatarItemId a, CombinationId b, Guid? c, Color? d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x83C1FB0", Offset = "0x83C05B0", VA = "0x1883C1FB0")]
		public static AvatarItemDesc LCOMHNTUDNM(DOUQKMCCEPT a)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3B11AE0", Offset = "0x3B100E0", VA = "0x183B11AE0")]
		internal static a? AZLYPKNUWLW<a>(string? input, IEGAUYGQEOI<a> a, LUVOEAWCUWK b, InvalidGuidHandling c, a d) where a : struct, UUHQRAMECBL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E900", Offset = "0x3B1CF00", VA = "0x183B1E900")]
		internal static UAXJCZQLHLT OSOAVJHFNCR<b>(string? input, IEGAUYGQEOI<b> a, LUVOEAWCUWK b, InvalidGuidHandling c, b d) where b : struct, UUHQRAMECBL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x83C2310", Offset = "0x83C0910", VA = "0x1883C2310")]
		internal static List<CustomAvatarItemVisualData> TMFNFESWBQL(IEnumerable<OutfitSelectionDTO>? selections)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E470", Offset = "0x3B1CA70", VA = "0x183B1E470")]
		internal static string LAUFMXVGMMY<c>(c a, IEGAUYGQEOI<c> b, LUVOEAWCUWK c) where c : UUHQRAMECBL
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class AOYYRDSGAGY : AOBGJARLJCL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public NNCDYHHEERZ<NOBEVDNKZQB, AvatarData> ICVZIWXHQSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public NNCDYHHEERZ<OutfitDTO, FFHOFKXHDEY> IRTMHLKOPYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public NNCDYHHEERZ<OutfitDTO, FFHOFKXHDEY> RTRDNVHZBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public USMEGIAHWTH GRGCCWWVPLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public JUMYLVJGQBI MHRNKXSQCHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x83B90C0", Offset = "0x83B76C0", VA = "0x1883B90C0")]
		[ZOKCDQOPSGU.Root.GameOnly]
		[UsedImplicitly]
		internal static void SMCYQCCCCSW(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x83B9130", Offset = "0x83B7730", VA = "0x1883B9130")]
		[RecRoom.NoEngine.Common.Preserve]
		internal AOYYRDSGAGY([Inject("UnitySerialization")] MFZPMULPUAG jsonSerializationService, [Inject(null)] SIWMVBMNGCJ runtimeMapperProvider, [Inject(null)] LUVOEAWCUWK debugLogger)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum AvatarParseErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		InvalidJsonOutfitSelectionsFormat,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		InvalidLegacyOutfitSelectionsFormat,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		InvalidBodyPart,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		InvalidGuid,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		ModernGuidMappingFailed,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		LegacyGuidMappingFailed,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		InvalidJsonAvatarData,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		MissingLegacyData
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarParseException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x83BA040", Offset = "0x83B8640", VA = "0x1883BA040")]
		public AvatarParseException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x83BA0A0", Offset = "0x83B86A0", VA = "0x1883BA0A0")]
		public AvatarParseException(string message, Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x83BA070", Offset = "0x83B8670", VA = "0x1883BA070")]
		public AvatarParseException(AvatarParseErrorCode code, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x83BA000", Offset = "0x83B8600", VA = "0x1883BA000")]
		public AvatarParseException(AvatarParseErrorCode code, string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal abstract class CZXBGKSMOXT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly MFZPMULPUAG VOEMTUPIFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		protected readonly SIWMVBMNGCJ KBBAFMMWVHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly LUVOEAWCUWK PYGTUNQHVVB;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x83BC7D0", Offset = "0x83BADD0", VA = "0x1883BC7D0")]
		protected CZXBGKSMOXT(MFZPMULPUAG a, SIWMVBMNGCJ b, LUVOEAWCUWK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x83BB3C0", Offset = "0x83B99C0", VA = "0x1883BB3C0")]
		protected string QMLYEDNVUTQ(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x83BAEC0", Offset = "0x83B94C0", VA = "0x1883BAEC0")]
		protected string CDWYKRDZKOC(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x83BB090", Offset = "0x83B9690", VA = "0x1883BB090")]
		private AvatarOutfitSelectionData OZETPTTQAEH(DOUQKMCCEPT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x83BC690", Offset = "0x83BAC90", VA = "0x1883BC690")]
		private static AvatarCustomizationSettingsData.AnchorParams WXYYHBAGVAQ(CKTLCGPSOZV? a)
		{
			return default(AvatarCustomizationSettingsData.AnchorParams);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface NNCDYHHEERZ<in a, b> where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PMFISQJBVYA(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface AOBGJARLJCL
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		NNCDYHHEERZ<NOBEVDNKZQB, AvatarData> ICVZIWXHQSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		NNCDYHHEERZ<OutfitDTO, FFHOFKXHDEY> RTRDNVHZBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		USMEGIAHWTH GRGCCWWVPLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal enum InvalidGuidHandling
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		UseNull,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		UseEmpty,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Throw
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface JUMYLVJGQBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyOutfitDataDTO KYZOGDONURM(AvatarData a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface USMEGIAHWTH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OutfitDTO KYZOGDONURM(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Tested]
	internal class ICVZIWXHQSY : KETZPGYOOHG<NOBEVDNKZQB, AvatarData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private readonly SIWMVBMNGCJ KBBAFMMWVHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly IRTMHLKOPYK MOQRMKPMYOK;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x83BD9E0", Offset = "0x83BBFE0", VA = "0x1883BD9E0")]
		public ICVZIWXHQSY(MFZPMULPUAG a, SIWMVBMNGCJ b, LUVOEAWCUWK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x83BD740", Offset = "0x83BBD40", VA = "0x1883BD740", Slot = "6")]
		public override AvatarData Deserialize(NOBEVDNKZQB input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitNewtonsoftJsonSerializer : MFZPMULPUAG
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private class IPEMPAKRLHF : JsonConverter<UAXJCZQLHLT>
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x83BDCB0", Offset = "0x83BC2B0", VA = "0x1883BDCB0", Slot = "9")]
			public override void WriteJson(JsonWriter writer, UAXJCZQLHLT? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x83BDBA0", Offset = "0x83BC1A0", VA = "0x1883BDBA0", Slot = "10")]
			public override UAXJCZQLHLT ReadJson(JsonReader reader, Type objectType, UAXJCZQLHLT? existingValue, bool hasExistingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x83BDD50", Offset = "0x83BC350", VA = "0x1883BDD50")]
			public IPEMPAKRLHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class IXIWBYIJYCL : JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override bool CanRead
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x83C05E0", Offset = "0x83BEBE0", VA = "0x1883C05E0", Slot = "5")]
			public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x83C0230", Offset = "0x83BE830", VA = "0x1883C0230", Slot = "6")]
			public override bool CanConvert(Type objectType)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x83C0630", Offset = "0x83BEC30", VA = "0x1883C0630", Slot = "4")]
			public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x83C0400", Offset = "0x83BEA00", VA = "0x1883C0400")]
			private static bool LMDPVUNBEDC(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
			public IXIWBYIJYCL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly JsonSerializerSettings QVFBSGRPICZ;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x83C24D0", Offset = "0x83C0AD0", VA = "0x1883C24D0")]
		internal OutfitNewtonsoftJsonSerializer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3B25960", Offset = "0x3B23F60", VA = "0x183B25960", Slot = "4")]
		public string JRPNDVGPMEN<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3B25AB0", Offset = "0x3B240B0", VA = "0x183B25AB0", Slot = "5")]
		public b RRVKVLWCFMA<b>(string a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitUtf8JsonSerializer : MFZPMULPUAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3B25E70", Offset = "0x3B24470", VA = "0x183B25E70", Slot = "4")]
		public string JRPNDVGPMEN<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3B25FC0", Offset = "0x3B245C0", VA = "0x183B25FC0", Slot = "5")]
		public b RRVKVLWCFMA<b>(string a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public OutfitUtf8JsonSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Tested]
	internal class IRTMHLKOPYK : KETZPGYOOHG<OutfitDTO, FFHOFKXHDEY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly MFZPMULPUAG VOEMTUPIFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private readonly SIWMVBMNGCJ KBBAFMMWVHO;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83C0100", Offset = "0x83BE700", VA = "0x1883C0100")]
		public IRTMHLKOPYK(MFZPMULPUAG a, SIWMVBMNGCJ b, LUVOEAWCUWK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83BDF90", Offset = "0x83BC590", VA = "0x1883BDF90", Slot = "6")]
		public override FFHOFKXHDEY Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83BFCD0", Offset = "0x83BE2D0", VA = "0x1883BFCD0")]
		internal void UBJQYFATBEF(string a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83BF400", Offset = "0x83BDA00", VA = "0x1883BF400")]
		public IEnumerable<DOUQKMCCEPT> NOXVBYIPDXN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83BF8F0", Offset = "0x83BDEF0", VA = "0x1883BF8F0")]
		private IEnumerable<DOUQKMCCEPT> RZXOPAULVTR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83BF4C0", Offset = "0x83BDAC0", VA = "0x1883BF4C0")]
		internal IEnumerable<DOUQKMCCEPT> OVBSYFWOPFF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83BEC10", Offset = "0x83BD210", VA = "0x1883BEC10")]
		private DOUQKMCCEPT JWSDYJXAXWJ(AvatarOutfitSelectionData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83BE3A0", Offset = "0x83BC9A0", VA = "0x1883BE3A0")]
		private void FWACTUPXEOV(AvatarCustomizationSettingsData a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83BEF80", Offset = "0x83BD580", VA = "0x1883BEF80")]
		private DOUQKMCCEPT JWSDYJXAXWJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83BFE10", Offset = "0x83BE410", VA = "0x1883BFE10")]
		internal static (AvatarBodyPart, string, string) VBGWXYYUNFH(string a, LUVOEAWCUWK b)
		{
			return default((AvatarBodyPart, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x83BDD90", Offset = "0x83BC390", VA = "0x1883BDD90")]
		private JTJNJPVDFYD? AAUTDOHDRCV(string? a, Vector2 b, float c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83BF2A0", Offset = "0x83BD8A0", VA = "0x1883BF2A0")]
		private static CKTLCGPSOZV NNOEGHXHANF(AvatarCustomizationSettingsData.AnchorParams a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Tested]
	internal class MHRNKXSQCHL : CZXBGKSMOXT, JUMYLVJGQBI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x83BC7D0", Offset = "0x83BADD0", VA = "0x1883BC7D0")]
		public MHRNKXSQCHL(MFZPMULPUAG a, SIWMVBMNGCJ b, LUVOEAWCUWK c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x83C15C0", Offset = "0x83BFBC0", VA = "0x1883C15C0", Slot = "4")]
		public LegacyOutfitDataDTO KYZOGDONURM(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x83C14D0", Offset = "0x83BFAD0", VA = "0x1883C14D0")]
		private string EFLERPLSIDT(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x83C1970", Offset = "0x83BFF70", VA = "0x1883C1970")]
		private string LRNPPYLEBJE(DOUQKMCCEPT a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Tested]
	internal class RTRDNVHZBKJ : KETZPGYOOHG<OutfitDTO, FFHOFKXHDEY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private readonly MFZPMULPUAG VOEMTUPIFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly NNCDYHHEERZ<OutfitDTO, FFHOFKXHDEY> JXMISXBDODG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x83C2A30", Offset = "0x83C1030", VA = "0x1883C2A30")]
		public RTRDNVHZBKJ(NNCDYHHEERZ<OutfitDTO, FFHOFKXHDEY> a, LUVOEAWCUWK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x83C2620", Offset = "0x83C0C20", VA = "0x1883C2620", Slot = "6")]
		public override FFHOFKXHDEY Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Tested]
	internal class GRGCCWWVPLU : USMEGIAHWTH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly MFZPMULPUAG VOEMTUPIFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly JUMYLVJGQBI DJIJCYELXGO;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x83BCCA0", Offset = "0x83BB2A0", VA = "0x1883BCCA0")]
		public GRGCCWWVPLU(JUMYLVJGQBI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83BC940", Offset = "0x83BAF40", VA = "0x1883BC940", Slot = "4")]
		public OutfitDTO KYZOGDONURM(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
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
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83B9700", Offset = "0x83B7D00", VA = "0x1883B9700")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public AnimatorDebugUtil()
		{
		}
	}
}
namespace RecRoom.Avatars.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class MTTZFJEDXMR
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x83C1BA0", Offset = "0x83C01A0", VA = "0x1883C1BA0")]
		public static AvatarItemDesc Deserialize(this AHPFMPJKDVW data)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x83C1D10", Offset = "0x83C0310", VA = "0x1883C1D10")]
		public static AHPFMPJKDVW KYZOGDONURM(this AvatarItemDesc a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83C1CB0", Offset = "0x83C02B0", VA = "0x1883C1CB0")]
		public static bool HZIQMYTDUSG(this AvatarItemDesc a)
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
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x66F0940", Offset = "0x66EEF40", VA = "0x1866F0940")]
			public AnchorParams(Vector2 normalizedPosition, Vector3 hemisphereOffsets, Vector3 hemisphereRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x83B9650", Offset = "0x83B7C50", VA = "0x1883B9650")]
			internal CKTLCGPSOZV KYZOGDONURM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams GHREWKGRQYR
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x83B9B80", Offset = "0x83B8180", VA = "0x1883B9B80")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x194ABD0", Offset = "0x19491D0", VA = "0x18194ABD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xE9B380", Offset = "0xE99980", VA = "0x180E9B380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x111C820", Offset = "0x111AE20", VA = "0x18111C820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x1DF4B80", Offset = "0x1DF3180", VA = "0x181DF4B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x83B9F70", Offset = "0x83B8570", VA = "0x1883B9F70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAB0760", Offset = "0xAAED60", VA = "0x180AB0760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xAF6B30", Offset = "0xAF5130", VA = "0x180AF6B30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xDF7AE0", Offset = "0xDF60E0", VA = "0x180DF7AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2A2D1A0", Offset = "0x2A2B7A0", VA = "0x182A2D1A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x102BC60", Offset = "0x102A260", VA = "0x18102BC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1317930", Offset = "0x1315F30", VA = "0x181317930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x14FC390", Offset = "0x14FA990", VA = "0x1814FC390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB070", VA = "0x180AACA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2677460", Offset = "0x2675A60", VA = "0x182677460")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x1071240", Offset = "0x106F840", VA = "0x181071240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xAC1710", Offset = "0xABFD10", VA = "0x180AC1710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAD0F30", Offset = "0xACF530", VA = "0x180AD0F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A90", Offset = "0xAB3090", VA = "0x180AB4A90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xAB50B0", Offset = "0xAB36B0", VA = "0x180AB50B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAB49F0", Offset = "0xAB2FF0", VA = "0x180AB49F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xAB50A0", Offset = "0xAB36A0", VA = "0x180AB50A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4960", Offset = "0xAB2F60", VA = "0x180AB4960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB36D0", VA = "0x180AB50D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAD5EB0", Offset = "0xAD44B0", VA = "0x180AD5EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xBD1340", Offset = "0xBCF940", VA = "0x180BD1340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A30", Offset = "0xAB3030", VA = "0x180AB4A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xAB4A50", Offset = "0xAB3050", VA = "0x180AB4A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xBD1370", Offset = "0xBCF970", VA = "0x180BD1370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xBD1270", Offset = "0xBCF870", VA = "0x180BD1270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E40", Offset = "0xAA8440", VA = "0x180AA9E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA150", Offset = "0xAA8750", VA = "0x180AAA150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xBD1290", Offset = "0xBCF890", VA = "0x180BD1290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xBD1390", Offset = "0xBCF990", VA = "0x180BD1390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xC52410", Offset = "0xC50A10", VA = "0x180C52410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xC4FD90", Offset = "0xC4E390", VA = "0x180C4FD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public HelmetHairState UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1124C10", Offset = "0x1123210", VA = "0x181124C10")]
			get
			{
				return default(HelmetHairState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x11249A0", Offset = "0x1122FA0", VA = "0x1811249A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xE7C8E0", Offset = "0xE7AEE0", VA = "0x180E7C8E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xE7CBD0", Offset = "0xE7B1D0", VA = "0x180E7CBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x83B9F90", Offset = "0x83B8590", VA = "0x1883B9F90")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x83B9FB0", Offset = "0x83B85B0", VA = "0x1883B9FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x83B9C20", Offset = "0x83B8220", VA = "0x1883B9C20")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public AvatarBodyPart BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private MaterialCombinationId? NLNXNXWPRDA;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x83B9FD0", Offset = "0x83B85D0", VA = "0x1883B9FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
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
