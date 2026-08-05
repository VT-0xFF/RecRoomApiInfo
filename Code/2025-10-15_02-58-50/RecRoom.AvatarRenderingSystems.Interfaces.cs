using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Avatars.AvatarEffectsDataTypes;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Consumable.AvatarItemEffects
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface BRMAMXVXTYN : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface SNQPCZRPVWV : BRMAMXVXTYN, IDisposable
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface ZDOAYLMCLZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UpdateController(float deltaTime);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface VOFTTVKCXFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		VYROOIAXTCX DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		VYROOIAXTCX DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		QPOKYBAOXQN.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize([In] AvatarDisplayInitState avatarDisplayInitState);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QJOFQHIWOMQ([In] AvatarDisplaySetupState avatarDisplaySetupState);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetManualLOD(int lod);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetUgcItemVisualOverrides(GYOKTMWUBLO overrideItem, Texture ugcTextureOverride, Color ugcColorOverride);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetWaitForUgcTextureLoads(bool shouldWait);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetUgcTextureParameters(AEJROGESOGJ parameters);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetColor(AvatarColorType colorType, Color? color);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetSkinColors(Color skinColor, Color? skinEmissiveColor, float? skinGlossOverride);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SetTexture(AvatarTextureType textureType, Texture2D texture);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AreMeshesBuilt();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		JFEJQPLKJHX BuildAvatarMeshes(GWZDQZVHJEA avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, GYOKTMWUBLO>, (JFEJQPLKJHX, WCGMKCSPRXW<Dictionary<string, SQZZORITPNB<Texture2D>>>)> getDownloadUgcTexturesPromises);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		JFEJQPLKJHX BuildPotatoAvatar(GWZDQZVHJEA avatarBuildParams, bool isFirstPerson, int[] LODs);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void Teardown();

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool SetBaseSkinCullingMask(QPOKYBAOXQN.SkinCullingMask cullingMask);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ApplyBodyProperties(bool forceUpdate = false);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void ApplyFaceProperties(bool forceUpdate = false);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void ApplyNoseProperties(bool forceUpdate = false);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void SetDeformation(bool deformBody, bool deformHead);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void UpdateFaceAndBodyShapes();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void ApplyHatAdjustments();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SetHatAnchorParams(IKDWWHXHRSU anchorParamsData, bool useHairFitMeshHemisphere);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void UpdateHatPivot([Optional] IKDWWHXHRSU anchorParamsData, [Optional] bool? useHairFitMeshHemisphere);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void HideAvatarMeshes(bool hide);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void UpdateEmissiveEffect(float power, Color color, bool reliable = false);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void UpdateTextureEffect(TextureEffectMaterialProperties effectFloat4Properties, TextureEffectMaterialTextures effectTexture2DProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface GQURVTSAJUV
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		VOFTTVKCXFM WPWRWMJOGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		HIRVRSWRHSJ PALDRCZWSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		YEUBVQTUYOF NBFZZAOEOBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		YEUBVQTUYOF IBUDLDGZAZH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform AMZZYNWPYAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TeardownAvatarDisplaySystem();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CleanupDisplayMeshes();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HIRVRSWRHSJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CHYKNPLVMYJ([In] AvatarFaceDisplayUpdateRenderersState updateState);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UAGHJMRPKDQ(AvatarFaceDisplayUpdateFeatureSelectionState a);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KXLAMMRLHCY([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface YEUBVQTUYOF
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		HandVisualState RBJPPGYCPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		float WXIFYTBZVFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		HandVisualState STQZSEOFOMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool MXDKNVGIMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Vector3 IVDATUJQYXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Quaternion YLUBTBGVBWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LTSLSNGJRHB(HandAnimationOverrideState a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NKQUWGXWYXF();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BAXKRHEAUOZ(int a, float b);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void HMIVULCMWVB();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ULQESUFNVNT(bool a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool UOSFSYKYMXX();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool TKYFCIFECCD();

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void NHKRHDDFQLW(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void QNYIBIJGZWF(Transform a, Vector3 b, Quaternion c);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface RNVGGJTQCLO
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		OutfitType GUAESJIYMGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		IReadOnlyList<OutfitType> MPTFLZKWGCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		IEnumerable<OutfitType> VMGHSVJQICG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		QPOKYBAOXQN.SkinCullingMask ZDKYAJSIYDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		Guid WBRSHDLSFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool FSRFMPRRJZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x82A88C0", Offset = "0x82A76C0", VA = "0x1882A88C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool RGBCOMQBGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x82A8CF0", Offset = "0x82A7AF0", VA = "0x1882A8CF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool BVBLHPNPNWD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x82A8870", Offset = "0x82A7670", VA = "0x1882A8870", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		string XDKBRUDFGEN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool BDKUIHKPEPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool HFNECBVPCAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool MTPNDHKASNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool WWOEYTZAUKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		Color PPSXZNALONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool XDJRLRGZKSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool JRTGLLGUVHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool QTHNWTPAURB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		AdditionalOutfitTypeData DXYVSPVNXQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		AdditionalHatData OWIDFSJHHNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		HairData VEZTJZVGFKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		HelmetHairMode JKPRKXBDSVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x82A8910", Offset = "0x82A7710", VA = "0x1882A8910", Slot = "21")]
			get
			{
				return default(HelmetHairMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool ZEJRHMWKFEK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x82A8C50", Offset = "0x82A7A50", VA = "0x1882A8C50", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool UHXTBRCJWPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		AnchorParamsRestrictions LMZNGBTGXEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82A89B0", Offset = "0x82A77B0", VA = "0x1882A89B0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool CTSVKMYEWLF(AvatarItemBodyType a);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool BXWKIRMBBDY(bool a = true);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82A8A50", Offset = "0x82A7850", VA = "0x1882A8A50", Slot = "27")]
		Color? OQQQVCIZKBO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IVRNQUOQCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RNVGGJTQCLO BBONGHPGWBR(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DHGOXNICFVY(GYOKTMWUBLO a, RNVGGJTQCLO b, AvatarItemBodyType c);
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
