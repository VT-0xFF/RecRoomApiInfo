using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom.Core.Creation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public global::MHKIEOOGPNK<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JKLKJBKDMKM PEOHPHEJFJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] GLJADHAPFHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] GEIJLEFCHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<JKLKJBKDMKM> MLKFAGMFAIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x665D300", Offset = "0x665C300", VA = "0x18665D300")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x665D3A0", Offset = "0x665C3A0", VA = "0x18665D3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x665CF40", Offset = "0x665BF40", VA = "0x18665CF40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x665D000", Offset = "0x665C000", VA = "0x18665D000")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x665D0B0", Offset = "0x665C0B0", VA = "0x18665D0B0")]
		public void SetIConfigurable(JKLKJBKDMKM PDLMGPDEOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x665CF50", Offset = "0x665BF50", VA = "0x18665CF50")]
		public void ChangeCollidersAndRenderers(Collider[] FDEBEDNDAOG, Renderer[] PBGGELNJDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x665D1F0", Offset = "0x665C1F0", VA = "0x18665D1F0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x665D060", Offset = "0x665C060", VA = "0x18665D060")]
		public void RunConfigurationSpecialActions(JKLKJBKDMKM HMELBNNKDHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x665D280", Offset = "0x665C280", VA = "0x18665D280")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IFGJKBLHIBO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NFICKLBDMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EHJJAMKLBGH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AddIsAnimated(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RemoveIsAnimated(object JAKCBCDLMLB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HEOAKLPFKJD
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece BFGLNIKPIAD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece BFGLNIKPIAD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider MMNMMMMCHOC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPOBCAIOIAI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject OCGHLHMMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid OCGMAIELJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string KOBOGELHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 HFOAEBOMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 INAHNKFEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion CBCKCFLIFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion PHAFEIAABKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float FOMCKPAPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float FKAPONKEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 FEHGLJFCKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 EHAJMNGKPKL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IMECMIJKEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JNIALNACDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JKLKJBKDMKM PEOHPHEJFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DIPBBECAHAC FHHINOOLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KJEPPLEAKOD;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CanUpdateDeformation(Vector3 IOCCMPBEMAO, float MKKAAJNEDMO, float HDEAFDMCNJO);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void UpdateDeformation(Vector3 IOCCMPBEMAO, float MKKAAJNEDMO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CanBeRaycasted(Collider MMNMMMMCHOC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EBGCHNKMNCN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DEONCPGLHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool AIAGJBHIGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 OICOOHNHEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Vector3 EKPNLAKHIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JGBKLKJHHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LEEILEOOBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BGHNNFIGPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KPEPCHEBEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NBFFMKJGOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AIPPDHDMINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnMoveStart();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnDeformed(Vector3 PFBBNMACLGB);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnMoveFinished();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverStart(DCEDAMFEMLE LMJGJGNJJJH, Collider NHBCCIJBNMC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OnHovering(DCEDAMFEMLE LMJGJGNJJJH, Collider NHBCCIJBNMC);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OnHoverFinished(DCEDAMFEMLE LMJGJGNJJJH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Translate(Vector3 ELOPADPCPCH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Rotate(Quaternion NLEALDFANJA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool Scale(float DEGNNNFBBGJ);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface COHCOBLAHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KNFGMGDALPP(in Vector3 ANCODJBIPAB, in Vector3 JLBPNKFCLFO, ref Vector3 DDGIJLNCGHO, ref Vector3 MFJFJLMHLGM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KJMMKMFFHND
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JLNNFJHBOML LKODBMKOIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BIFBANLAIBD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FHEGODJDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GIOOIKALAMH IJNIKCMJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> GFHLLFIHLDD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int NKNOPIDMJOB);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PEOADAHMPGD GetCulprit(JNMBCGMKLBK CMOAPINGCHK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NDIOCMMKINF
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<DNNFDEJPNME.HAAOAMOGLIP> HIBFCMMJMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(DNNFDEJPNME.HAAOAMOGLIP JCBNJOFLIPL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(DNNFDEJPNME.HAAOAMOGLIP JCBNJOFLIPL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EMICHNPLNMI
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CanModifyProperty(string GPBJNICHLBB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IENOLCFFIJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int PNKDAABHNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(DENHGLJDFAP? CLKCOGLLPDH);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(NIHKMKJOMNK? FFHNNFOLDDG);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JNMBCGMKLBK CanBeSelected();

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CanBeSelected(out JNMBCGMKLBK GPPHCPBMODE, out PEOADAHMPGD PEBDMNNJOKI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JPICJAFIBPL
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MLCIMGFFNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CostInfo BNLJIELPFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FJPDPLBEBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AHNLDBLBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool NJFAOHAPONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool JKDEAGFMIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ELKPIIGAMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool OKDKCBHOLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JGKKBIAHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> ABJIHLFCOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BoxCollider JBOAGGBFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool MMPMFGPEIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MFPOLPAAEOC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JNMBCGMKLBK CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo(out Vector3 MIFJBHLKJIN, out Quaternion OLBDAPNGDPL, out float AEIEKJBHCEM, out Vector3 FLILAGFCIGK);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? MIFJBHLKJIN, Quaternion? OLBDAPNGDPL, float? AEIEKJBHCEM, Vector3? FLILAGFCIGK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KLAPBKCKJDB
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	object NNNPLDBHGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Type PFBBEJGBGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Guid PAHOLJMEPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JKLKJBKDMKM
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	IReadOnlyList<MBOCMHHEPBJ> JBDNOHDONHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string KOBOGELHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string MCHCEBCHABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool EMBOEJCGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string> MEFAJJLBEKE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JKLKJBKDMKM> JCDKBOPFIJF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<INCMJNOFFMI, FMLDLKKPHEO> DMMEFPKBAJP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action NEKDFODCDDJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FNLICMOFCLP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DAMBOLAIAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DNNFDEJPNME
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate OBBGEOGBCPK HAAOAMOGLIP();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<HAAOAMOGLIP> EOJIPBEKOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<HAAOAMOGLIP> CIIEGDDMMPD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IEnumerable<HAAOAMOGLIP> OOFCILDJLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x665E5C0", Offset = "0x665D5C0", VA = "0x18665E5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x665E410", Offset = "0x665D410", VA = "0x18665E410")]
	public void GBJBCHALJOG(HAAOAMOGLIP JCBNJOFLIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x665E630", Offset = "0x665D630", VA = "0x18665E630")]
	public bool PMMODKPOELK(HAAOAMOGLIP JCBNJOFLIPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OBBGEOGBCPK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IKFMIHHKLND
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DIPBBECAHAC
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int PMMOHJIJPLI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long NMEDIICFOKE = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private global::HODCJICBJME<Guid, ObscuredLong, ObscuredInt, ObscuredBool> OFLJGCBJJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::EHKHDGABMNF<ObscuredBool, ObscuredInt, ObscuredInt> GKPCLHKAKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun PMIFMNEAFNB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid PCEODNKPJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x665DC00", Offset = "0x665CC00", VA = "0x18665DC00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public long LCPICDGKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x665D440", Offset = "0x665C440", VA = "0x18665D440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AOEOACAGLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x665D590", Offset = "0x665C590", VA = "0x18665D590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MHDLGJMPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x665D4F0", Offset = "0x665C4F0", VA = "0x18665D4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AEJACBOPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x665D790", Offset = "0x665C790", VA = "0x18665D790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int JHELIGEMCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x665D630", Offset = "0x665C630", VA = "0x18665D630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LGIKIIAOJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x665DD60", Offset = "0x665CD60", VA = "0x18665DD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FJEHJJKFJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x665DD20", Offset = "0x665CD20", VA = "0x18665DD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x665E360", Offset = "0x665D360", VA = "0x18665E360")]
	public DIPBBECAHAC(MonoBehaviourPun HIJCHMLKHEM, string EICOEINLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x665E030", Offset = "0x665D030", VA = "0x18665E030")]
	public DIPBBECAHAC(MonoBehaviourPun HIJCHMLKHEM, string EICOEINLNHE, Guid DBAOMOAJEGP, long FIMPEDIPEJC, int LFBDGIAGCON, bool NEHMBDBHKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x665DE00", Offset = "0x665CE00", VA = "0x18665DE00")]
	public void PABGLFBKGJC(PEOADAHMPGD NBONNFAMFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x665D830", Offset = "0x665C830", VA = "0x18665D830")]
	public void HDJMDNMGMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x665D950", Offset = "0x665C950", VA = "0x18665D950")]
	public void JHHOMPLGCBC(Guid PCNOPCBNFNN, long FIMPEDIPEJC, int LFBDGIAGCON, bool NEHMBDBHKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x665DB30", Offset = "0x665CB30", VA = "0x18665DB30")]
	public void JHHOMPLGCBC(DIPBBECAHAC JHMCLPBFJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x665DFC0", Offset = "0x665CFC0", VA = "0x18665DFC0")]
	public void PDCDPKALMJG(ABGJAKPJOFK FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x665DC70", Offset = "0x665CC70", VA = "0x18665DC70")]
	public void MNEIPMKACNH(ABGJAKPJOFK FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x665D6D0", Offset = "0x665C6D0", VA = "0x18665D6D0")]
	public static ABGJAKPJOFK GBNLMDCCMAH(Guid DBAOMOAJEGP, long FIMPEDIPEJC, int AALCLFFIICB, bool NEHMBDBHKBL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x665E770", Offset = "0x665D770", VA = "0x18665E770")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x665E880", Offset = "0x665D880", VA = "0x18665E880")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
