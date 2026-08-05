using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x81AC070", Offset = "0x81AA870", VA = "0x1881AC070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x81ADD90", Offset = "0x81AC590", VA = "0x1881ADD90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	internal class WBSNAAXVWYZ : LVPHDKFPSRM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public WBSNAAXVWYZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AvatarConfiguration avatarConfiguration;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ETUKICUFZVY TYZBKVGCJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly MLIPXYEBJHI TWPMSECSIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly IZHOBKNCFQE ZCBMFEYYXMH;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81AC5A0", Offset = "0x81AADA0", VA = "0x1881AC5A0")]
		[SLGIUIECCXF.Root.GameOnly]
		[UsedImplicitly]
		internal static void MEHSPUGYGPJ(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81ADC20", Offset = "0x81AC420", VA = "0x1881ADC20")]
		[RecRoom.NoEngine.Common.Preserve]
		internal WBSNAAXVWYZ([Inject(null)] ETUKICUFZVY avatarDataMigrations, [Inject(null)] MLIPXYEBJHI avatarDataSerializerProvider, [Inject(null)] IZHOBKNCFQE outfitManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81AC7F0", Offset = "0x81AAFF0", VA = "0x1881AC7F0", Slot = "5")]
		public AvatarData WQQKWJTDYKL(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81AD0F0", Offset = "0x81AB8F0", VA = "0x1881AD0F0", Slot = "4")]
		public AvatarData ZWHJFCPFTIH(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81AC0F0", Offset = "0x81AA8F0", VA = "0x1881AC0F0", Slot = "6")]
		public OutfitDTO AYAZLZPNDOS(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81AC510", Offset = "0x81AAD10", VA = "0x1881AC510", Slot = "7")]
		public bool KJAUWUNWHHS(GBLZIKNPJCA a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81AC430", Offset = "0x81AAC30", VA = "0x1881AC430", Slot = "8")]
		public bool JUEBQJXNHCW(OutfitDTO a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81AC3A0", Offset = "0x81AABA0", VA = "0x1881AC3A0", Slot = "9")]
		public bool CXNVXSXPYSR(OutfitDTO a, [Out] IBKULMGEALL? outfitData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BEF080", Offset = "0x3BED880", VA = "0x183BEF080")]
		private bool PTSAVBKPZVV<a, b>(a a, SBFYZLRWHCW<a, b> b, [Out] b? result) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81AC200", Offset = "0x81AAA00", VA = "0x1881AC200")]
		[CompilerGenerated]
		private HUBJOIYZBOY CPCVGKXVNTJ(FaceFeatureType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81AC610", Offset = "0x81AAE10", VA = "0x1881AC610")]
		[CompilerGenerated]
		private HUBJOIYZBOY MNTKREZIMLS(FaceFeatureType a, <>c__DisplayClass6_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tested]
	internal class LSPHQWHPMPV : ETUKICUFZVY
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate void MigrationFunc<in TData>(TData avatarData, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NAFFDINEDQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public RangeDataType ZSBMTIXBGMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AvatarVersion XMJQWEZGNVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AvatarVersion QJDUMIKKXDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public RangeMigration? HGERZERDKTF;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NAFFDINEDQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x81AC050", Offset = "0x81AA850", VA = "0x1881AC050")]
			internal bool QUCWNBSPJXZ(RangeMigration a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x81ABFD0", Offset = "0x81AA7D0", VA = "0x1881ABFD0")]
			internal bool QTXPPUYSAMQ(RangeMigration a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly IZHOBKNCFQE ZCBMFEYYXMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly WTCYPBNJOYZ VXWXZITTUAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MigrationFunc<AvatarData>?[] TYZBKVGCJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MigrationFunc<IBKULMGEALL>?[] JCQEXNKDEQR;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81AA2C0", Offset = "0x81A8AC0", VA = "0x1881AA2C0")]
		[SLGIUIECCXF.Root.GameOnly]
		[UsedImplicitly]
		internal static void MEHSPUGYGPJ(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81ABAE0", Offset = "0x81AA2E0", VA = "0x1881ABAE0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal LSPHQWHPMPV([Inject(null)] IZHOBKNCFQE outfitManager, [Inject(null)] WTCYPBNJOYZ debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81AA740", Offset = "0x81A8F40", VA = "0x1881AA740", Slot = "4")]
		public bool PEBMQSMTYGB(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81AA840", Offset = "0x81A9040", VA = "0x1881AA840", Slot = "5")]
		public bool PEBMQSMTYGB(IBKULMGEALL a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81AAA50", Offset = "0x81A9250", VA = "0x1881AAA50")]
		private void QHTGCQFGEXA(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81AA330", Offset = "0x81A8B30", VA = "0x1881AA330")]
		private void MSYVCBMYMSG(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81AA710", Offset = "0x81A8F10", VA = "0x1881AA710")]
		private void OWIXEBLKQQH(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81AB6F0", Offset = "0x81A9EF0", VA = "0x1881AB6F0")]
		private void UZFVOJFRCAD(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81AB5E0", Offset = "0x81A9DE0", VA = "0x1881AB5E0")]
		private void QTPEAJWUBUY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81AA9A0", Offset = "0x81A91A0", VA = "0x1881AA9A0")]
		private void PUIOQJLAPUF(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81AB750", Offset = "0x81A9F50", VA = "0x1881AB750")]
		private void WSZBSZQNLMD(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81AA2B0", Offset = "0x81A8AB0", VA = "0x1881AA2B0")]
		private void LGOVDBFGNTM(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81AB720", Offset = "0x81A9F20", VA = "0x1881AB720")]
		private void WRZMKXFEYFZ(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81A9F50", Offset = "0x81A8750", VA = "0x1881A9F50")]
		private void GERPUGAIUDY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81AB800", Offset = "0x81AA000", VA = "0x1881AB800")]
		private void WYDNRJZKSIC(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81A9FD0", Offset = "0x81A87D0", VA = "0x1881A9FD0")]
		private AvatarData KRJROVMURHR(AvatarData a, List<RangeMigration> b, AvatarVersion c, AvatarVersion d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81AB6B0", Offset = "0x81A9EB0", VA = "0x1881AB6B0")]
		private float UEBNKPTYQFN(float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81AA550", Offset = "0x81A8D50", VA = "0x1881AA550")]
		private (RangeMigration?, RangeMigration?) OCESSKJHXEV(List<RangeMigration> a, RangeDataType b, AvatarVersion c, AvatarVersion d)
		{
			return default((RangeMigration?, RangeMigration?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface ETUKICUFZVY
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool PEBMQSMTYGB(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PEBMQSMTYGB(IBKULMGEALL a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
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
		[Cpp2IlInjected.Address(RVA = "0x818DA00", Offset = "0x818C200", VA = "0x18818DA00")]
		public void AWWJUYRLEDJ(AnimationPoseSetting a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x818DB30", Offset = "0x818C330", VA = "0x18818DB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x818E420", Offset = "0x818CC20", VA = "0x18818E420")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x818E3E0", Offset = "0x818CBE0", VA = "0x18818E3E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x818DB50", Offset = "0x818C350", VA = "0x18818DB50")]
		private void LIOEAEUPKYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8119290", Offset = "0x8117A90", VA = "0x188119290", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x818E450", Offset = "0x818CC50", VA = "0x18818E450")]
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
		[Cpp2IlInjected.Address(RVA = "0x818E490", Offset = "0x818CC90", VA = "0x18818E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x818EB10", Offset = "0x818D310", VA = "0x18818EB10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x818EAD0", Offset = "0x818D2D0", VA = "0x18818EAD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x818E4D0", Offset = "0x818CCD0", VA = "0x18818E4D0")]
		private void LIOEAEUPKYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8119290", Offset = "0x8117A90", VA = "0x188119290", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x818EB40", Offset = "0x818D340", VA = "0x18818EB40")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, BVYYTMQYWMV
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
		private WXNNQUADKFU SWJRSPVSDJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public WXNNQUADKFU BQKOIEMIWRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xCE66C0", Offset = "0xCE4EC0", VA = "0x180CE66C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KQOEZFHDIGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x818FA30", Offset = "0x818E230", VA = "0x18818FA30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x818EB70", Offset = "0x818D370", VA = "0x18818EB70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x818F8F0", Offset = "0x818E0F0", VA = "0x18818F8F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x818F8A0", Offset = "0x818E0A0", VA = "0x18818F8A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x818F830", Offset = "0x818E030", VA = "0x18818F830")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x818EB70", Offset = "0x818D370", VA = "0x18818EB70", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x818EFD0", Offset = "0x818D7D0", VA = "0x18818EFD0", Slot = "6")]
		public WXNNQUADKFU CreateAvatarSystem(string identifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x818F830", Offset = "0x818E030", VA = "0x18818F830", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x818EC30", Offset = "0x818D430", VA = "0x18818EC30", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x818F940", Offset = "0x818E140", VA = "0x18818F940", Slot = "9")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x818FA50", Offset = "0x818E250", VA = "0x18818FA50")]
		public AnimationPoseSetting GetAnimationPoseSetting(AnimationPoseType animationPoseType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x818FA80", Offset = "0x818E280", VA = "0x18818FA80")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x818FAC0", Offset = "0x818E2C0", VA = "0x18818FAC0")]
		public AvatarModernBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class BQKOIEMIWRJ : WXNNQUADKFU
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class NOOTBLALJTN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private Vector3 IAEIORJPFVU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Quaternion FWOODCEPGQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private Vector3 GASQXRSTTWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private Transform HTWSGKPCTTV;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Vector3 KBCOQHDNSCO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0xC7D050", Offset = "0xC7B850", VA = "0x180C7D050")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x81B1450", Offset = "0x81AFC50", VA = "0x1881B1450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Quaternion CPRBSABCCIN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x1C882A0", Offset = "0x1C86AA0", VA = "0x181C882A0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x1C88290", Offset = "0x1C86A90", VA = "0x181C88290")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public float BIDZEGFZJLU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0x102F170", Offset = "0x102D970", VA = "0x18102F170")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x17F7490", Offset = "0x17F5C90", VA = "0x1817F7490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool TZHHHTRJPFD
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAB4110", Offset = "0xAB2910", VA = "0x180AB4110")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xAB4150", Offset = "0xAB2950", VA = "0x180AB4150")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool JKACQFWVNLV
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAB3910", Offset = "0xAB2110", VA = "0x180AB3910")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0xAB3A20", Offset = "0xAB2220", VA = "0x180AB3A20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool AKIUYJTWYBS
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xAB39C0", Offset = "0xAB21C0", VA = "0x180AB39C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xAB3A30", Offset = "0xAB2230", VA = "0x180AB3A30")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float SEBLVSBXAFZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xB84850", Offset = "0xB83050", VA = "0x180B84850")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0xB848F0", Offset = "0xB830F0", VA = "0x180B848F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x81B1FE0", Offset = "0x81B07E0", VA = "0x1881B1FE0")]
			public void TGXMOCRPVMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x81B1580", Offset = "0x81AFD80", VA = "0x1881B1580")]
			public void KMOVUUDGZIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x81B1240", Offset = "0x81AFA40", VA = "0x1881B1240")]
			public float CZNZOGTTHFL(Vector3 a, Quaternion b, [In] AvatarFootSettings footSettings, float c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x81B1910", Offset = "0x81B0110", VA = "0x1881B1910")]
			public void TCDLIIIKZOT(Vector3 a, Quaternion b, Transform c, float d, bool e, bool f, float g, float h, Transform i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x81B1590", Offset = "0x81AFD90", VA = "0x1881B1590")]
			public void RQJTGMHVSBM(Transform a, Transform b, bool c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x81B1460", Offset = "0x81AFC60", VA = "0x1881B1460")]
			private void HRCQAQYGNDM(Transform a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x81B17C0", Offset = "0x81AFFC0", VA = "0x1881B17C0")]
			public bool RRBLRFABQOL(Transform a, AvatarModernBodyConfiguration b, Vector3 c, float d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x81B1560", Offset = "0x81AFD60", VA = "0x1881B1560")]
			public void JLSRUFTBDIQ(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x81B1FF0", Offset = "0x81B07F0", VA = "0x1881B1FF0")]
			public NOOTBLALJTN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class VCZGHYSJSCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public float WLIQGLGTRNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private bool LOHWYPLGPFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public AnimationPoseSetting TOCCCRAOSRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private float OWFRXNQOKIQ;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x81B4270", Offset = "0x81B2A70", VA = "0x1881B4270")]
			public void WUNRMSRFQNW(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x81B3470", Offset = "0x81B1C70", VA = "0x1881B3470")]
			public void MLIRJQJTBLR(IKSolverVR.Arm a, float b, bool c, AvatarModernBodyConfiguration d, float e, bool f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x81B4230", Offset = "0x81B2A30", VA = "0x1881B4230")]
			private void WKWMQDDFHTS(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x81B2BF0", Offset = "0x81B13F0", VA = "0x1881B2BF0")]
			public void ICZFJESUREN(IKSolverVR.Arm a, Transform b, Transform c, Quaternion d, Vector3 e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x81B3C40", Offset = "0x81B2440", VA = "0x1881B3C40")]
			private (Vector3, Quaternion) RUHSJGTREAY(QJNMADAOQZE a, Quaternion b, Vector3 c)
			{
				return default((Vector3, Quaternion));
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x81B40D0", Offset = "0x81B28D0", VA = "0x1881B40D0")]
			public void WJEQMQTDTGU(QJNMADAOQZE a, IKSolverVR.Arm b, Quaternion c, Vector3 d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x81B3640", Offset = "0x81B1E40", VA = "0x1881B3640")]
			public void RMWAHGZHJSV(QJNMADAOQZE a, IKSolverVR.Arm b, Quaternion c, Vector3 d, [In] AvatarModernBodyConfiguration config, [In] AvatarSystemUpdateState state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x81B3500", Offset = "0x81B1D00", VA = "0x1881B3500")]
			public void RBELCKXIMCX(AnimationPoseType a, AvatarModernBodyConfiguration b, AvatarSystemUpdateState c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x81B2FD0", Offset = "0x81B17D0", VA = "0x1881B2FD0")]
			public void IVCRTRJDJXM(IKSolverVR.Arm a, Transform b, Vector3 c, float d, Quaternion e, Vector3 f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x81B42A0", Offset = "0x81B2AA0", VA = "0x1881B42A0")]
			public VCZGHYSJSCP()
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
		private static readonly int BRIZXANSVMK;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly int GEXTNCICNVB;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly int MBWYPCROMOC;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly int VEOBUPMBBZK;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly int QJLSBOTGIHB;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly int ZPYMORPTUMD;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly int DUTLSYRXMPN;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly int LQYWFQVRHMS;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly int ZDRCCLWFTNE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly int NBGXWEJEIPK;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly int WZEDUMYCJJX;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly int EQUWZCEDEMX;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static readonly int PSDAXUBTQDF;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly int DGHJXSZDYAM;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly int GDSQCODKVIM;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly int EVUSARYEOJD;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly int QVGZFJHWMPR;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly int CUJFBQRYUHV;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly int MVESOUJXAXH;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly int PBYPNYMFWRV;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly int GZCOPXRBOVX;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly int NDBNCWLXZDE;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int THJGXOYTEPI;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly int ECEFJTOSWWQ;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly int KHCYHZZDGYF;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly int YENQYCLLEWI;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly int RPFWMKITDKG;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly int GPDCSGQQQDO;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static readonly int ABOCKWIBTYK;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly int CVJPNRPFCTZ;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly int PDSEFUYQMRR;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly int MPLULOAPDPA;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Vector3 YEMBSNOAGUH;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly int PTDEFUKYTVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool XWQRPUCMOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool EETEJPFJRVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool CARFMYNXFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool CYGCXBLZFTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool DIBLLAGMYFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool CJLDUKMWOVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Vector3 YBXGSQBYOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private string TQLZWCWPNGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AvatarSystemInitState? LQHMCIBTOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private AvatarSystemPlayerSetupState? VDHLCLHJIPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AvatarDisplaySystem NRMYNRPYGRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private KEJUSOGABHI ZIFUNIPLXWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private QJNMADAOQZE VPLVEVSZPTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private QJNMADAOQZE OHHCYYVPKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool PBZRWBUSUWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x299")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool UMNJDAKPIZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly GSLITNCRENN IZHFJECPBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly YPGXFEFEWTC LJSUFFYOWYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int YFLDEDZETAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float YGICYJLLZUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GameObject HNZJMTNQOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Transform OWXKWKHLKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private Transform NXADCFJLCVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private Transform JVVZZDIUIGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Transform HTALTMJYFCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private float AXXNNUXXSNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private float NRXJEEWJTCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Vector3 RLVKUPNFTVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Quaternion XNMTPIVDYSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private Transform KCTTQALKIOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private Transform YETWSAWGUPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private Transform BMFLEZJUSNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private MFFKMPOBLPU ONLUHGZJWBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private QTYJKGAEVFD<ObscuredFloat> JZFGODEKXXS;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ProfilerMarker DSINWLRTQRO;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly ProfilerMarker YVBOUIGTCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ProfilerMarker KVLGOMFWJJM;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly ProfilerMarker PZYORHTDZBJ;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ProfilerMarker AHVTJCEOUHV;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly ProfilerMarker EIXEPEVVRVK;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly List<BQKOIEMIWRJ> OQLZMVWKNBW;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private static int FUSSKZKAEOG;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> ULBKYIKUGCD;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static int VNMBGKAKVNK;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static int BLVQDLIPOXT;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static int SFHRDNBVLFE;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int DAJKGVXXOIT;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static float NBRFYHJFKWP;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private static int CHEUJNMFGTY;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static float HDGCUYNHTLX;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static float OXGDDQQAHOM;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static float NDYJRMNSEEU;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static float JWBBPESCWZZ;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static SDIUWPXOJBO URZBLTLFBNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private float KGQIDNKMQSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private bool OCJZIAFCNKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private float SRFZJSZKAAG;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly int FYZAXVTEHSO;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly int VFXKTKUGFVL;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly int QYNRVRMHDSB;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static readonly int ERBUBGCYFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private NOOTBLALJTN ADYKOWSEPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private NOOTBLALJTN FMDQCTMGNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private float EJQYTOUKIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 FDONKHEHSBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3 LNUSQGMFGJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool NMARKYMVXZK;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly Quaternion QLWHAAPMTBL;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly Quaternion WKQUPAZGVCY;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Vector3 QIBQPGLZNGF;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly Vector3 CLSHDIUYJXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float ZYRMVZSPRTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private float FAGNRIHJRWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private VCZGHYSJSCP JGKBHEJNUDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private VCZGHYSJSCP SGGKJZVVFVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private ABEXLCVRDNF VRNFQPBBTMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private ETRSGRGVAXM DJDEAIVMKGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly WJTUGXZCZBE UIAUBDKNYGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float AZFBMDVIBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float WRWXYINOMUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly ETRSGRGVAXM HMGDZJTSPBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 OHWDOFUNRXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 IQFNVKYAEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float TQWDVUTJNAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private float WVXEOKVJPSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly ETRSGRGVAXM ZSXFVDYBCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly ABEXLCVRDNF RYYTIRSNAYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly ETRSGRGVAXM TWGACDQAJHI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public XOOCNKBZGKP UYKKGYPALKW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public XOOCNKBZGKP GZIEFPVGOWV
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AvatarConfiguration VHJHAHHXWBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8191DA0", Offset = "0x81905A0", VA = "0x188191DA0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AvatarBodyType MEUTGVGZYIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x818FF60", Offset = "0x818E760", VA = "0x18818FF60", Slot = "24")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AvatarModernBodyConfiguration PVXFBLUFDJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x81A7620", Offset = "0x81A5E20", VA = "0x1881A7620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Transform VLJIAHMGHRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8199AD0", Offset = "0x81982D0", VA = "0x188199AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Transform SDUAYRJAWRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8190CA0", Offset = "0x818F4A0", VA = "0x188190CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private SkinnedMeshRenderer MZRCZOETSDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x81A6B20", Offset = "0x81A5320", VA = "0x1881A6B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Renderer[] DDKEHNDUIFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x81A56C0", Offset = "0x81A3EC0", VA = "0x1881A56C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GameObject[] ZQIUXIUOHMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x81904E0", Offset = "0x818ECE0", VA = "0x1881904E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Animator QCFRXRHCHUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x819AAB0", Offset = "0x81992B0", VA = "0x18819AAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private VRIK NJXECJABYXB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x81A8220", Offset = "0x81A6A20", VA = "0x1881A8220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LWBLBDRCTOW ZMXBKDDNQSU
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x819AE30", Offset = "0x8199630", VA = "0x18819AE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private LWBLBDRCTOW ZUMTLOWJTUX
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x819DED0", Offset = "0x819C6D0", VA = "0x18819DED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LWBLBDRCTOW MYJPIVGENUC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8197220", Offset = "0x8195A20", VA = "0x188197220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LWBLBDRCTOW OSBZSABDOGU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x819FC90", Offset = "0x819E490", VA = "0x18819FC90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LWBLBDRCTOW OXJCIKCUOCN
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x81A7210", Offset = "0x81A5A10", VA = "0x1881A7210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private LWBLBDRCTOW KEFALHLSOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x81A5210", Offset = "0x81A3A10", VA = "0x1881A5210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private LWBLBDRCTOW IGMLFLCKINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x819FBB0", Offset = "0x819E3B0", VA = "0x18819FBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private LWBLBDRCTOW EXWXBZDJWTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x81A0C10", Offset = "0x819F410", VA = "0x1881A0C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AvatarSystemPlayerSetupState TTJDYIBDYTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x81A2AB0", Offset = "0x81A12B0", VA = "0x1881A2AB0", Slot = "16")]
			get
			{
				return default(AvatarSystemPlayerSetupState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FPMWPTESEEW JVBRKYHZWEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x17AB3D0", Offset = "0x17A9BD0", VA = "0x1817AB3D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JXZAHTZEYVD RRYLYDLXOWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xE93710", Offset = "0xE91F10", VA = "0x180E93710", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KBLIJBEPRHD VLXVKVELDCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8191D90", Offset = "0x8190590", VA = "0x188191D90", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public KBLIJBEPRHD ENZQYTQYOTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x13C51F0", Offset = "0x13C39F0", VA = "0x1813C51F0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string GYKJPXPTTAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private Transform XDHIOAFQDEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8191C80", Offset = "0x8190480", VA = "0x188191C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Transform CHUAXUQPEIB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x81A1340", Offset = "0x819FB40", VA = "0x1881A1340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Transform LZLRHZATQZB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x819FD70", Offset = "0x819E570", VA = "0x18819FD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private Transform MWLZRDVWRJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x819F330", Offset = "0x819DB30", VA = "0x18819F330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private Transform WQLTHTFXAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x81A1760", Offset = "0x819FF60", VA = "0x1881A1760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool VZNXQLHAMDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x819AB90", Offset = "0x8199390", VA = "0x18819AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool BKROYFDQBET
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x819AB90", Offset = "0x8199390", VA = "0x18819AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private bool JRMTWRKWLXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x81A0B20", Offset = "0x819F320", VA = "0x1881A0B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Transform GYBJFSLXXAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8190BC0", Offset = "0x818F3C0", VA = "0x188190BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GameObject QXHRVEKBABE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8190040", Offset = "0x818E840", VA = "0x188190040", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HeadLogicOffsets YASMVZEFNHV
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x81A2A30", Offset = "0x81A1230", VA = "0x1881A2A30", Slot = "34")]
			get
			{
				return default(HeadLogicOffsets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Transform KSMYYNRQNTN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1C7B9E0", Offset = "0x1C7A1E0", VA = "0x181C7B9E0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Transform HKJMRFQGLQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xBD5C90", Offset = "0xBD4490", VA = "0x180BD5C90", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Transform FFTOZYWKXAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1C7BC10", Offset = "0x1C7A410", VA = "0x181C7BC10", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform DHNSVKEBHXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x13C5A30", Offset = "0x13C4230", VA = "0x1813C5A30", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 IFDGNPSRMHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x81A2460", Offset = "0x81A0C60", VA = "0x1881A2460", Slot = "39")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float IVBOBZTTWKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8195B30", Offset = "0x8194330", VA = "0x188195B30", Slot = "40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Transform GNLBXOFFXDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x819A420", Offset = "0x8198C20", VA = "0x18819A420", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Transform BYAVTDELNDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1E60A10", Offset = "0x1E5F210", VA = "0x181E60A10", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Transform IPHOVUYYJQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2255BA0", Offset = "0x22543A0", VA = "0x182255BA0", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform DSEUJCKOPYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2514520", Offset = "0x2512D20", VA = "0x182514520", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool PVCFUTUVIBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8197130", Offset = "0x8195930", VA = "0x188197130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public WXSKNELZHVC<WXNNQUADKFU.FootEvent> EKYRTMMWMFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1E4F5E0", Offset = "0x1E4DDE0", VA = "0x181E4F5E0", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool CCCLPMPZGUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8192EA0", Offset = "0x81916A0", VA = "0x188192EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private bool YHJZNNLKTBX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8192780", Offset = "0x8190F80", VA = "0x188192780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x819D4C0", Offset = "0x819BCC0", VA = "0x18819D4C0")]
		private float LIUVWXYLVCO(AvatarStance a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81975E0", Offset = "0x8195DE0", VA = "0x1881975E0")]
		private void IPPGHIQKGLC([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8196260", Offset = "0x8194A60", VA = "0x188196260")]
		private float HURVSQMGJMO([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8193050", Offset = "0x8191850", VA = "0x188193050")]
		private float DVJQBKXERYK([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x819FA20", Offset = "0x819E220", VA = "0x18819FA20")]
		private void OLGZXWNTPHC(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81A6C00", Offset = "0x81A5400", VA = "0x1881A6C00")]
		private void WWXXCFGWBMA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8192F50", Offset = "0x8191750", VA = "0x188192F50")]
		private void DTRWDEFYRON([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81A9A90", Offset = "0x81A8290", VA = "0x1881A9A90")]
		public BQKOIEMIWRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81956C0", Offset = "0x8193EC0", VA = "0x1881956C0", Slot = "47")]
		public void FYFIHHBPOXG(float a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x819D460", Offset = "0x819BC60", VA = "0x18819D460", Slot = "48")]
		public void LESDQFSPSUP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81A24F0", Offset = "0x81A0CF0", VA = "0x1881A24F0", Slot = "13")]
		public void TZERCOAXXNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8195790", Offset = "0x8193F90", VA = "0x188195790", Slot = "14")]
		public void FZEJDFCFMPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8195B80", Offset = "0x8194380", VA = "0x188195B80", Slot = "15")]
		public void GNUSBIMVGWO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81A74D0", Offset = "0x81A5CD0", VA = "0x1881A74D0", Slot = "26")]
		public Transform YNDXNIEVKWF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8190130", Offset = "0x818E930", VA = "0x188190130", Slot = "27")]
		public Vector3? APFSZRDCETE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81A0CF0", Offset = "0x819F4F0", VA = "0x1881A0CF0", Slot = "7")]
		public void QKADBRQJMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x819A480", Offset = "0x8198C80", VA = "0x18819A480")]
		private void KDVGIEAKAQN(AvatarModernBodyConfiguration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8193900", Offset = "0x8192100", VA = "0x188193900", Slot = "8")]
		public void EDMQHHFASGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x81A7940", Offset = "0x81A6140", VA = "0x1881A7940")]
		private void YVRFWNRMGQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81A7090", Offset = "0x81A5890", VA = "0x1881A7090")]
		private Vector3 YALQORDPIYW([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8195320", Offset = "0x8193B20", VA = "0x188195320", Slot = "6")]
		public void FXOASRADITS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81A6270", Offset = "0x81A4A70", VA = "0x1881A6270")]
		private void WMVXBXIBZKS(bool a, MovementUpdateMode b, AvatarModernBodyConfiguration c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x819DFB0", Offset = "0x819C7B0", VA = "0x18819DFB0", Slot = "9")]
		public void MFLQVXXDATI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81A51C0", Offset = "0x81A39C0", VA = "0x1881A51C0")]
		private void UYPYPVVPSFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x819AF90", Offset = "0x8199790", VA = "0x18819AF90", Slot = "4")]
		public void LBBBKERTXDT(string a, AvatarSystemInitState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x819F5A0", Offset = "0x819DDA0", VA = "0x18819F5A0", Slot = "5")]
		public void OBIVQUCZKZX(AvatarSystemPlayerSetupState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x819F450", Offset = "0x819DC50", VA = "0x18819F450", Slot = "12")]
		public void NWEVHNWINRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8192340", Offset = "0x8190B40", VA = "0x188192340", Slot = "25")]
		public void CMUCWWGBJPD([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8192F20", Offset = "0x8191720", VA = "0x188192F20")]
		private void DLNLPRVDISS([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81902C0", Offset = "0x818EAC0", VA = "0x1881902C0", Slot = "28")]
		public void AXKKOGAOWKS(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8199020", Offset = "0x8197820", VA = "0x188199020", Slot = "29")]
		public void IQQYWLUTDMD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x81900E0", Offset = "0x818E8E0", VA = "0x1881900E0", Slot = "49")]
		public void ANHFPDSQYZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8193CB0", Offset = "0x81924B0", VA = "0x188193CB0", Slot = "30")]
		public void FCRTYODZREY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8193B40", Offset = "0x8192340", VA = "0x188193B40", Slot = "31")]
		public HandLogicOffsets EGPNHBVNDEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8191CD0", Offset = "0x81904D0", VA = "0x188191CD0", Slot = "32")]
		public PlatformSpecificPlayerHandOffsets BUXYJUFOISQ()
		{
			return default(PlatformSpecificPlayerHandOffsets);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x81A57A0", Offset = "0x81A3FA0", VA = "0x1881A57A0")]
		private void VVSUBVBJWGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81A22E0", Offset = "0x81A0AE0", VA = "0x1881A22E0")]
		private void TMUXLYTAWNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8194F10", Offset = "0x8193710", VA = "0x188194F10")]
		private void FRTUOQCESRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8197300", Offset = "0x8195B00", VA = "0x188197300")]
		private void INHHLIAHCLH(CSFUYHSFTRK a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8199370", Offset = "0x8197B70", VA = "0x188199370")]
		private void IVNCYGLKKYL(CSFUYHSFTRK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8193C60", Offset = "0x8192460", VA = "0x188193C60", Slot = "33")]
		public Vector3 FBZWZLDSWHA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x81A57D0", Offset = "0x81A3FD0", VA = "0x1881A57D0")]
		private void VXJKLXUQOTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81A1380", Offset = "0x819FB80", VA = "0x1881A1380")]
		private void QXKKIRDQUDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8192800", Offset = "0x8191000", VA = "0x188192800")]
		private void DAZXBXOCDMZ(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81A7F50", Offset = "0x81A6750", VA = "0x1881A7F50")]
		private float YZVHWSVJVTA([In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x819F370", Offset = "0x819DB70", VA = "0x18819F370")]
		private int NMMUSBGMRED([In] AvatarSystemUpdateRateState updateRateState)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x819EE10", Offset = "0x819D610", VA = "0x18819EE10")]
		private void NGWPCSLBWQS(AvatarSystemUpdateState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81994F0", Offset = "0x8197CF0", VA = "0x1881994F0")]
		private static void JBMODIZCOGU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8190D80", Offset = "0x818F580", VA = "0x188190D80")]
		private static void BRWHNZTXKSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81A0FC0", Offset = "0x819F7C0", VA = "0x1881A0FC0")]
		private float QKIWKPABZKR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8192750", Offset = "0x8190F50", VA = "0x188192750")]
		private static int CPXXDIGCVLP(BQKOIEMIWRJ a, BQKOIEMIWRJ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x81A8300", Offset = "0x81A6B00", VA = "0x1881A8300", Slot = "42")]
		public AvatarSystemUpdateState ZTYFPDWEEYJ()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x81A5120", Offset = "0x81A3920", VA = "0x1881A5120")]
		private bool UVWBWZUXQWR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x81926D0", Offset = "0x8190ED0", VA = "0x1881926D0")]
		public void CNRXITPBJOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x81A17A0", Offset = "0x819FFA0", VA = "0x1881A17A0")]
		private (bool, bool) RSBTIWHAHBT()
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x81A72F0", Offset = "0x81A5AF0", VA = "0x1881A72F0")]
		private (float, float) YLEEDSENNBM([In] AvatarSystemUpdateState state)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81A34D0", Offset = "0x81A1CD0", VA = "0x1881A34D0")]
		private void UVCOBYTGJLR([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8195F40", Offset = "0x8194740", VA = "0x188195F40")]
		private void HHGPLZENBWR([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x81A1970", Offset = "0x81A0170", VA = "0x1881A1970")]
		private void RSXRXUGKNEA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config, AvatarFootSettings a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x819AF10", Offset = "0x8199710", VA = "0x18819AF10")]
		private float KZFSGCQBUSQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x81A8450", Offset = "0x81A6C50", VA = "0x1881A8450")]
		private void ZUXDIQQFRBO(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8199BB0", Offset = "0x81983B0", VA = "0x188199BB0")]
		private float JSSWVYLXGWF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8191E80", Offset = "0x8190680", VA = "0x188191E80")]
		private void CEFXCZUUZUZ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8196E50", Offset = "0x8195650", VA = "0x188196E50")]
		private void ICZFJESUREN([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x81A2F10", Offset = "0x81A1710", VA = "0x1881A2F10")]
		private void ULZDRVBGSAL([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81919F0", Offset = "0x81901F0", VA = "0x1881919F0")]
		private void BTRZJWHLJWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8199700", Offset = "0x8197F00", VA = "0x188199700")]
		private void JCTWAMKUTNN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x819E460", Offset = "0x819CC60", VA = "0x18819E460")]
		private void NEGUZMRGBRW([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x81A76B0", Offset = "0x81A5EB0", VA = "0x1881A76B0")]
		private void YUIHSBPAMMX(QJNMADAOQZE a, IKSolverVR.Arm b, Transform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x81A13A0", Offset = "0x819FBA0", VA = "0x1881A13A0")]
		private void RDWZFVFCXTS(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x81A3300", Offset = "0x81A1B00", VA = "0x1881A3300")]
		private void UUDRAROMQPB(HandGestureType a, KBLIJBEPRHD b, IKSolverVR.Arm c, float d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x81902D0", Offset = "0x818EAD0", VA = "0x1881902D0")]
		private void AYFPGXDFPQP([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x81905C0", Offset = "0x818EDC0", VA = "0x1881905C0")]
		private void BKMLRDHRSOW([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x819FDA0", Offset = "0x819E5A0", VA = "0x18819FDA0")]
		protected void PCRWCPOTRUA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x81A2BC0", Offset = "0x81A13C0", VA = "0x1881A2BC0")]
		private void UGFUQZOBLKO([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x819ABE0", Offset = "0x81993E0", VA = "0x18819ABE0")]
		protected void KWEDWCPOBHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8199C00", Offset = "0x8198400", VA = "0x188199C00")]
		private void JVMLDEPCTKM([In] AvatarSystemUpdateState state, [In] MovementUpdateMode movementUpdateMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8195510", Offset = "0x8193D10", VA = "0x188195510")]
		private void FYEKFYXVTKL(AvatarSystemUpdateState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x81930D0", Offset = "0x81918D0", VA = "0x1881930D0")]
		private void DZKJCPNDSWS([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81A7A40", Offset = "0x81A6240", VA = "0x1881A7A40")]
		private Vector3 YYVCTYNKCEO([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8193B90", Offset = "0x8192390", VA = "0x188193B90")]
		private void EXHCTYBARKD([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x81A5E20", Offset = "0x81A4620", VA = "0x1881A5E20")]
		private float WGUCFXUJYES(float a, [In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x81A80D0", Offset = "0x81A68D0", VA = "0x1881A80D0")]
		private void ZOKGMXJFBFT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x81A0430", Offset = "0x819EC30", VA = "0x1881A0430")]
		private void QAXYYIKTTUU([In] AvatarSystemUpdateState state, MovementUpdateMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8194710", Offset = "0x8192F10", VA = "0x188194710")]
		private float FMACEZYDEEL([In] AvatarSystemUpdateState systemUpdateState)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8193110", Offset = "0x8191910", VA = "0x188193110")]
		private void EBYNKBQVKQM(AvatarSystemUpdateState a, MovementUpdateMode b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x81A1190", Offset = "0x819F990", VA = "0x1881A1190")]
		private static void QKLVWYGBUGV(Transform a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x81A0160", Offset = "0x819E960", VA = "0x1881A0160")]
		private void PMUHRZWKAXO([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x819E5F0", Offset = "0x819CDF0", VA = "0x18819E5F0")]
		private void NEODGMARVJF([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x81A20F0", Offset = "0x81A08F0", VA = "0x1881A20F0")]
		private void STDFOKJFVUJ(float a, [In] AvatarSystemUpdateState systemUpdateState, float b = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8196690", Offset = "0x8194E90", VA = "0x188196690")]
		private float ICSGRWHOWYQ([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8195C50", Offset = "0x8194450", VA = "0x188195C50")]
		private void GPNZBZFQNCQ([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8193D00", Offset = "0x8192500", VA = "0x188193D00")]
		private void FDODCWVXNYH([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x81A52F0", Offset = "0x81A3AF0", VA = "0x1881A52F0")]
		private void VMGZFMDQTGP([In] AvatarSystemUpdateState systemUpdateState, float a, float b, Vector3 c, float d = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x819D4E0", Offset = "0x819BCE0", VA = "0x18819D4E0")]
		private void LPAITPQQMMR(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8196400", Offset = "0x8194C00", VA = "0x188196400")]
		private void HZKUZISTJFT(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x819CFA0", Offset = "0x819B7A0", VA = "0x18819CFA0")]
		private void LBBBRDWIVHB(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x81A5C60", Offset = "0x81A4460", VA = "0x1881A5C60")]
		public void WFETURNWHJE([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x81A1D90", Offset = "0x81A0590", VA = "0x1881A1D90")]
		public void SOTRGAZRUPA([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x81A5AC0", Offset = "0x81A42C0", VA = "0x1881A5AC0")]
		[CompilerGenerated]
		internal static void VZNEFSHKFRL(Transform a, IKSolverVR.Arm b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x819ED60", Offset = "0x819D560", VA = "0x18819ED60")]
		[CompilerGenerated]
		internal static void NGANUQSOOUG(Vector3 a, Vector3 b, <>c__DisplayClass271_0 c, <>c__DisplayClass271_1 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x81A6FF0", Offset = "0x81A57F0", VA = "0x1881A6FF0")]
		[CompilerGenerated]
		internal static void XCJBAUMXDZB(NOOTBLALJTN a, NOOTBLALJTN b, Vector3 c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x81962F0", Offset = "0x8194AF0", VA = "0x1881962F0")]
		[CompilerGenerated]
		internal static bool HXSKRBSNCOG(IKSolverVR.Arm a, UEMSXUUKLZQ b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x819E020", Offset = "0x819C820", VA = "0x18819E020")]
		[CompilerGenerated]
		internal static float NBHDBRJZRUK(Vector3 a, Vector3 b, Vector3 c, AvatarSystemUpdateState d, AvatarModernBodyConfiguration e, float f)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class AvatarSystemManager : FOJAQAMNEIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Dictionary<string, WXNNQUADKFU> GYWAQUHXCFL;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x81AED50", Offset = "0x81AD550", VA = "0x1881AED50")]
		[SLGIUIECCXF.Root]
		internal static void DLIITDJPXRD(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x81AEB30", Offset = "0x81AD330", VA = "0x1881AEB30", Slot = "4")]
		public WXNNQUADKFU CYLMJRXGXKI(string a, AvatarSystemConfiguration b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x81AEDC0", Offset = "0x81AD5C0", VA = "0x1881AEDC0", Slot = "5")]
		public void NFQLWHZXAMW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x81AF010", Offset = "0x81AD810", VA = "0x1881AF010", Slot = "6")]
		public string ZBXDITTYSMV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x81AEFA0", Offset = "0x81AD7A0", VA = "0x1881AEFA0")]
		private string PWJABFOAJVL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x81AF140", Offset = "0x81AD940", VA = "0x1881AF140")]
		public AvatarSystemManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class XBPZCLJQFXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private Dictionary<string, Transform> QEWRQYDTMGA;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool BFVPHTIGLUI
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x81B7010", Offset = "0x81B5810", VA = "0x1881B7010")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x81B7050", Offset = "0x81B5850", VA = "0x1881B7050")]
			public void NQTEFVTHJAT(VRIK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
			public void WAFEORXAFKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x81B7180", Offset = "0x81B5980", VA = "0x1881B7180")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x81B71D0", Offset = "0x81B59D0", VA = "0x1881B71D0")]
			public XBPZCLJQFXF()
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
		private readonly XBPZCLJQFXF REGXBZETNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private BVYYTMQYWMV URMEFEUBDMO;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x81AF250", Offset = "0x81ADA50", VA = "0x1881AF250")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x81AF1C0", Offset = "0x81AD9C0", VA = "0x1881AF1C0")]
		private bool DXZJUJQEXBZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81AF530", Offset = "0x81ADD30", VA = "0x1881AF530")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x81AF5A0", Offset = "0x81ADDA0", VA = "0x1881AF5A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x81AF540", Offset = "0x81ADD40", VA = "0x1881AF540")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x81AF850", Offset = "0x81AE050", VA = "0x1881AF850")]
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
			[Cpp2IlInjected.Address(RVA = "0x81B0AE0", Offset = "0x81AF2E0", VA = "0x1881B0AE0")]
			public (float, float) AAFYHUHXFYC(float a)
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
			private int GENRETSSVJA;

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
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x81B01E0", Offset = "0x81AE9E0", VA = "0x1881B01E0")]
			public void RUCBQSMBUXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x81B02C0", Offset = "0x81AEAC0", VA = "0x1881B02C0")]
			public (float, float) VWGESVSODNY(Animator a, AnimatorStateInfo b)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int MDKISFULZIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Dictionary<int, HandPoseSetting> MZEUBIPSXBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x81B0660", Offset = "0x81AEE60", VA = "0x1881B0660")]
		public void RUCBQSMBUXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x81B0840", Offset = "0x81AF040", VA = "0x1881B0840")]
		public (float, float) WRDOBWPOFUA(Animator a, AvatarStance b, float c)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x81B0400", Offset = "0x81AEC00", VA = "0x1881B0400")]
		private (float, float) RBZOEHMGICA(Animator a, AnimatorStateInfo b, AvatarStance c, float d)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x81B0AD0", Offset = "0x81AF2D0", VA = "0x1881B0AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81B10C0", Offset = "0x81AF8C0", VA = "0x1881B10C0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x81B1220", Offset = "0x81AFA20", VA = "0x1881B1220")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal abstract class OGDYIZJGSBJ<a, b> : SBFYZLRWHCW<a, b> where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected readonly WTCYPBNJOYZ VXWXZITTUAW;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x59D7140", Offset = "0x59D5940", VA = "0x1859D7140")]
		protected OGDYIZJGSBJ(WTCYPBNJOYZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x59D70A0", Offset = "0x59D58A0", VA = "0x1859D70A0", Slot = "5")]
		public bool PTSAVBKPZVV(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Tested]
	public static class JPJUJJWOXFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly Regex DNXMDUNNDTU;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x81B0D00", Offset = "0x81AF500", VA = "0x1881B0D00")]
		public static PSITMQIRAOM WLCSFWXLRZW(AvatarItemId a, CombinationId b, Guid? c, Color? d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x81B0BA0", Offset = "0x81AF3A0", VA = "0x1881B0BA0")]
		public static AvatarItemDesc UMYVWWVZYAD(PSITMQIRAOM a)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x376AC30", Offset = "0x3769430", VA = "0x18376AC30")]
		internal static a? VQPDBWMUHCZ<a>(string? input, AMKKQASKEAD<a> a, WTCYPBNJOYZ b, InvalidGuidHandling c, a d) where a : struct, EQKNBVNLWCS
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x376A840", Offset = "0x3769040", VA = "0x18376A840")]
		internal static RPKNOQRBLQK GJCRYSYVXZW<b>(string? input, AMKKQASKEAD<b> a, WTCYPBNJOYZ b, InvalidGuidHandling c, b d) where b : struct, EQKNBVNLWCS
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x81B0F00", Offset = "0x81AF700", VA = "0x1881B0F00")]
		internal static List<CustomAvatarItemVisualData> YIHJFWQYJGI(IEnumerable<OutfitSelectionDTO>? selections)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x376B3E0", Offset = "0x3769BE0", VA = "0x18376B3E0")]
		internal static string YDSKCKDKTPX<c>(c a, AMKKQASKEAD<c> b, WTCYPBNJOYZ c) where c : EQKNBVNLWCS
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class ZDJXTMXAQVR : MLIPXYEBJHI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public SBFYZLRWHCW<GBLZIKNPJCA, AvatarData> GWFUHUVQQID
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public SBFYZLRWHCW<OutfitDTO, IBKULMGEALL> VZZBGBDKLXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public SBFYZLRWHCW<OutfitDTO, IBKULMGEALL> SYQXLHDEOZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public JFGJFGGXSYA DQYEBZLJMCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public OCDMSDCCARZ VTEDGMVCZYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x81B9230", Offset = "0x81B7A30", VA = "0x1881B9230")]
		[SLGIUIECCXF.Root.GameOnly]
		[UsedImplicitly]
		internal static void MEHSPUGYGPJ(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x81B92A0", Offset = "0x81B7AA0", VA = "0x1881B92A0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal ZDJXTMXAQVR([Inject("UnitySerialization")] UNAEWBHJPHV jsonSerializationService, [Inject(null)] CCCIDFWITVA runtimeMapperProvider, [Inject(null)] WTCYPBNJOYZ debugLogger)
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
		[Cpp2IlInjected.Address(RVA = "0x81AEAA0", Offset = "0x81AD2A0", VA = "0x1881AEAA0")]
		public AvatarParseException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x81AEB00", Offset = "0x81AD300", VA = "0x1881AEB00")]
		public AvatarParseException(string message, Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x81AEAD0", Offset = "0x81AD2D0", VA = "0x1881AEAD0")]
		public AvatarParseException(AvatarParseErrorCode code, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x81AEA60", Offset = "0x81AD260", VA = "0x1881AEA60")]
		public AvatarParseException(AvatarParseErrorCode code, string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal abstract class XODXRDWXOXI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly UNAEWBHJPHV AZKHDYLBQAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly CCCIDFWITVA UJCKZIDPTTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly WTCYPBNJOYZ VXWXZITTUAW;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x81B49E0", Offset = "0x81B31E0", VA = "0x1881B49E0")]
		protected XODXRDWXOXI(UNAEWBHJPHV a, CCCIDFWITVA b, WTCYPBNJOYZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x81B7D70", Offset = "0x81B6570", VA = "0x1881B7D70")]
		protected string YIHHNJYNZLH(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81B7730", Offset = "0x81B5F30", VA = "0x1881B7730")]
		protected string MNLEZCGAFTN(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x81B7A40", Offset = "0x81B6240", VA = "0x1881B7A40")]
		private AvatarOutfitSelectionData WLCSFWXLRZW(PSITMQIRAOM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x81B7900", Offset = "0x81B6100", VA = "0x1881B7900")]
		private static AvatarCustomizationSettingsData.AnchorParams SYXZBZWZOST(SDZUMEDZFPG? a)
		{
			return default(AvatarCustomizationSettingsData.AnchorParams);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface SBFYZLRWHCW<in a, b> where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PTSAVBKPZVV(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface MLIPXYEBJHI
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		SBFYZLRWHCW<GBLZIKNPJCA, AvatarData> GWFUHUVQQID
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		SBFYZLRWHCW<OutfitDTO, IBKULMGEALL> SYQXLHDEOZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		JFGJFGGXSYA DQYEBZLJMCR
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
	public interface OCDMSDCCARZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyOutfitDataDTO VOPQGDPBGDJ(AvatarData a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface JFGJFGGXSYA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OutfitDTO VOPQGDPBGDJ(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Tested]
	internal class GWFUHUVQQID : OGDYIZJGSBJ<GBLZIKNPJCA, AvatarData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly CCCIDFWITVA UJCKZIDPTTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly VZZBGBDKLXL GFLLZSPXDYJ;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x81B0020", Offset = "0x81AE820", VA = "0x1881B0020")]
		public GWFUHUVQQID(UNAEWBHJPHV a, CCCIDFWITVA b, WTCYPBNJOYZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x81AFD80", Offset = "0x81AE580", VA = "0x1881AFD80", Slot = "6")]
		public override AvatarData Deserialize(GBLZIKNPJCA input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitNewtonsoftJsonSerializer : UNAEWBHJPHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private class YUQVLJMWBRA : JsonConverter<RPKNOQRBLQK>
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x81B9150", Offset = "0x81B7950", VA = "0x1881B9150", Slot = "9")]
			public override void WriteJson(JsonWriter writer, RPKNOQRBLQK? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x81B9040", Offset = "0x81B7840", VA = "0x1881B9040", Slot = "10")]
			public override RPKNOQRBLQK ReadJson(JsonReader reader, Type objectType, RPKNOQRBLQK? existingValue, bool hasExistingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x81B91F0", Offset = "0x81B79F0", VA = "0x1881B91F0")]
			public YUQVLJMWBRA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class XBTFGVWMRWI : JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override bool CanRead
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x81B7600", Offset = "0x81B5E00", VA = "0x1881B7600", Slot = "5")]
			public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x81B7430", Offset = "0x81B5C30", VA = "0x1881B7430", Slot = "6")]
			public override bool CanConvert(Type objectType)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x81B7650", Offset = "0x81B5E50", VA = "0x1881B7650", Slot = "4")]
			public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x81B7250", Offset = "0x81B5A50", VA = "0x1881B7250")]
			private static bool BIJYPCAQIET(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
			public XBTFGVWMRWI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly JsonSerializerSettings HMBJGLXVRBA;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x81B2000", Offset = "0x81B0800", VA = "0x1881B2000")]
		internal OutfitNewtonsoftJsonSerializer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x38EAD10", Offset = "0x38E9510", VA = "0x1838EAD10", Slot = "4")]
		public string OBRHWOBZYVK<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38EABA0", Offset = "0x38E93A0", VA = "0x1838EABA0", Slot = "5")]
		public b NDABBTRWKLX<b>(string a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitUtf8JsonSerializer : UNAEWBHJPHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38EB1F0", Offset = "0x38E99F0", VA = "0x1838EB1F0", Slot = "4")]
		public string OBRHWOBZYVK<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x38EB090", Offset = "0x38E9890", VA = "0x1838EB090", Slot = "5")]
		public b NDABBTRWKLX<b>(string a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public OutfitUtf8JsonSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Tested]
	internal class VZZBGBDKLXL : OGDYIZJGSBJ<OutfitDTO, IBKULMGEALL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private readonly UNAEWBHJPHV AZKHDYLBQAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private readonly CCCIDFWITVA UJCKZIDPTTD;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x81B6EE0", Offset = "0x81B56E0", VA = "0x1881B6EE0")]
		public VZZBGBDKLXL(UNAEWBHJPHV a, CCCIDFWITVA b, WTCYPBNJOYZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x81B5040", Offset = "0x81B3840", VA = "0x1881B5040", Slot = "6")]
		public override IBKULMGEALL Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x81B6D90", Offset = "0x81B5590", VA = "0x1881B6D90")]
		internal void TIDGMLGHWDI(string a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x81B4F80", Offset = "0x81B3780", VA = "0x1881B4F80")]
		public IEnumerable<PSITMQIRAOM> BHKAQJHRWMG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x81B5450", Offset = "0x81B3C50", VA = "0x1881B5450")]
		private IEnumerable<PSITMQIRAOM> EHTENOEZSII(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x81B4B50", Offset = "0x81B3350", VA = "0x1881B4B50")]
		internal IEnumerable<PSITMQIRAOM> ANLADUAXFMM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x81B5E50", Offset = "0x81B4650", VA = "0x1881B5E50")]
		private PSITMQIRAOM IUSRJHVISAG(AvatarOutfitSelectionData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x81B61C0", Offset = "0x81B49C0", VA = "0x1881B61C0")]
		private void JUZRHARSQAG(AvatarCustomizationSettingsData a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x81B5B30", Offset = "0x81B4330", VA = "0x1881B5B30")]
		private PSITMQIRAOM IUSRJHVISAG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x81B5840", Offset = "0x81B4040", VA = "0x1881B5840")]
		internal static (AvatarBodyPart, string, string) ERSVLGGQTVY(string a, WTCYPBNJOYZ b)
		{
			return default((AvatarBodyPart, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x81B6A30", Offset = "0x81B5230", VA = "0x1881B6A30")]
		private HUBJOIYZBOY? PPZVSINZDHM(string? a, Vector2 b, float c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x81B6C30", Offset = "0x81B5430", VA = "0x1881B6C30")]
		private static SDZUMEDZFPG SZQAQCJBAXG(AvatarCustomizationSettingsData.AnchorParams a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Tested]
	internal class VTEDGMVCZYW : XODXRDWXOXI, OCDMSDCCARZ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x81B49E0", Offset = "0x81B31E0", VA = "0x1881B49E0")]
		public VTEDGMVCZYW(UNAEWBHJPHV a, CCCIDFWITVA b, WTCYPBNJOYZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x81B4630", Offset = "0x81B2E30", VA = "0x1881B4630", Slot = "4")]
		public LegacyOutfitDataDTO VOPQGDPBGDJ(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x81B4540", Offset = "0x81B2D40", VA = "0x1881B4540")]
		private string QODKZYHBZEA(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x81B4310", Offset = "0x81B2B10", VA = "0x1881B4310")]
		private string LCUNZTPXJYF(PSITMQIRAOM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Tested]
	internal class SYQXLHDEOZY : OGDYIZJGSBJ<OutfitDTO, IBKULMGEALL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly UNAEWBHJPHV AZKHDYLBQAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly SBFYZLRWHCW<OutfitDTO, IBKULMGEALL> ORYWKTYRBPR;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x81B27F0", Offset = "0x81B0FF0", VA = "0x1881B27F0")]
		public SYQXLHDEOZY(SBFYZLRWHCW<OutfitDTO, IBKULMGEALL> a, WTCYPBNJOYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x81B23E0", Offset = "0x81B0BE0", VA = "0x1881B23E0", Slot = "6")]
		public override IBKULMGEALL Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Tested]
	internal class DQYEBZLJMCR : JFGJFGGXSYA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly UNAEWBHJPHV AZKHDYLBQAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly OCDMSDCCARZ MZKVMKAVRLL;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x81AFCA0", Offset = "0x81AE4A0", VA = "0x1881AFCA0")]
		public DQYEBZLJMCR(OCDMSDCCARZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x81AF920", Offset = "0x81AE120", VA = "0x1881AF920", Slot = "4")]
		public OutfitDTO VOPQGDPBGDJ(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
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
		[Cpp2IlInjected.Address(RVA = "0x81AE160", Offset = "0x81AC960", VA = "0x1881AE160")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
namespace RecRoom.Avatars.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class PUYHNFBMSNU
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x81B2150", Offset = "0x81B0950", VA = "0x1881B2150")]
		public static AvatarItemDesc Deserialize(this OWWWKKCKAUF data)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x81B22C0", Offset = "0x81B0AC0", VA = "0x1881B22C0")]
		public static OWWWKKCKAUF VOPQGDPBGDJ(this AvatarItemDesc a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x81B2260", Offset = "0x81B0A60", VA = "0x1881B2260")]
		public static bool GISVHIQAMBT(this AvatarItemDesc a)
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
			[Cpp2IlInjected.Address(RVA = "0x65238F0", Offset = "0x65220F0", VA = "0x1865238F0")]
			public AnchorParams(Vector2 normalizedPosition, Vector3 hemisphereOffsets, Vector3 hemisphereRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x81AE0B0", Offset = "0x81AC8B0", VA = "0x1881AE0B0")]
			internal SDZUMEDZFPG VOPQGDPBGDJ()
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
		internal static AnchorParams ZRTGWUQGTXM
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x81AE5E0", Offset = "0x81ACDE0", VA = "0x1881AE5E0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x166A6B0", Offset = "0x1668EB0", VA = "0x18166A6B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xBA94B0", Offset = "0xBA7CB0", VA = "0x180BA94B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE25400", Offset = "0xE23C00", VA = "0x180E25400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1113510", Offset = "0x1111D10", VA = "0x181113510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x81AE9D0", Offset = "0x81AD1D0", VA = "0x1881AE9D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAB8F10", Offset = "0xAB7710", VA = "0x180AB8F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAFE390", Offset = "0xAFCB90", VA = "0x180AFE390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1A5CE60", Offset = "0x1A5B660", VA = "0x181A5CE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x28093E0", Offset = "0x2807BE0", VA = "0x1828093E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xD41150", Offset = "0xD3F950", VA = "0x180D41150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x102F140", Offset = "0x102D940", VA = "0x18102F140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1204220", Offset = "0x1202A20", VA = "0x181204220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xAB3270", Offset = "0xAB1A70", VA = "0x180AB3270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xAB3260", Offset = "0xAB1A60", VA = "0x180AB3260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x21D4E60", Offset = "0x21D3660", VA = "0x1821D4E60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xD71B80", Offset = "0xD70380", VA = "0x180D71B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAC7F50", Offset = "0xAC6750", VA = "0x180AC7F50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C50", Offset = "0xAD6450", VA = "0x180AD7C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xABA0A0", Offset = "0xAB88A0", VA = "0x180ABA0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xABA750", Offset = "0xAB8F50", VA = "0x180ABA750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xABA0E0", Offset = "0xAB88E0", VA = "0x180ABA0E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAB9FF0", Offset = "0xAB87F0", VA = "0x180AB9FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xABA6F0", Offset = "0xAB8EF0", VA = "0x180ABA6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xABA0B0", Offset = "0xAB88B0", VA = "0x180ABA0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xADCA40", Offset = "0xADB240", VA = "0x180ADCA40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xD0CB00", Offset = "0xD0B300", VA = "0x180D0CB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xABA0F0", Offset = "0xAB88F0", VA = "0x180ABA0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xABA020", Offset = "0xAB8820", VA = "0x180ABA020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB48810", Offset = "0xB47010", VA = "0x180B48810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xC081D0", Offset = "0xC069D0", VA = "0x180C081D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC190", Offset = "0xAAA990", VA = "0x180AAC190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAC50", VA = "0x180AAC450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xC601C0", Offset = "0xC5E9C0", VA = "0x180C601C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xD61240", Offset = "0xD5FA40", VA = "0x180D61240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC5FEA0", Offset = "0xC5E6A0", VA = "0x180C5FEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC5E030", Offset = "0xC5C830", VA = "0x180C5E030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public HelmetHairState UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xE3E6B0", Offset = "0xE3CEB0", VA = "0x180E3E6B0")]
			get
			{
				return default(HelmetHairState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xE3E6A0", Offset = "0xE3CEA0", VA = "0x180E3E6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xB63C20", Offset = "0xB62420", VA = "0x180B63C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB63F20", Offset = "0xB62720", VA = "0x180B63F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x81AE9F0", Offset = "0x81AD1F0", VA = "0x1881AE9F0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x81AEA10", Offset = "0x81AD210", VA = "0x1881AEA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x81AE680", Offset = "0x81ACE80", VA = "0x1881AE680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		private MaterialCombinationId? XBQFWSIEUKZ;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x81AEA30", Offset = "0x81AD230", VA = "0x1881AEA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
