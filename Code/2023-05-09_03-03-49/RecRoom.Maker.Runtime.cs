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
		public global::IINGBGFGMKE<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HOKNNLILNNH GDAHLEJCIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] JPMHJLFHCEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] ENMJLOBAKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<HOKNNLILNNH> CEFMGMMMFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6AB6CF0", Offset = "0x6AB56F0", VA = "0x186AB6CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6AB6D90", Offset = "0x6AB5790", VA = "0x186AB6D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6930", Offset = "0x6AB5330", VA = "0x186AB6930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AB69F0", Offset = "0x6AB53F0", VA = "0x186AB69F0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6AA0", Offset = "0x6AB54A0", VA = "0x186AB6AA0")]
		public void SetIConfigurable(HOKNNLILNNH EIBHCMMONLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6940", Offset = "0x6AB5340", VA = "0x186AB6940")]
		public void ChangeCollidersAndRenderers(Collider[] CFOPBHGDMJA, Renderer[] ECCMBEPNJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6BE0", Offset = "0x6AB55E0", VA = "0x186AB6BE0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6A50", Offset = "0x6AB5450", VA = "0x186AB6A50")]
		public void RunConfigurationSpecialActions(HOKNNLILNNH AOJEJBIGPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6C70", Offset = "0x6AB5670", VA = "0x186AB6C70")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MMGAEBFFEOK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BBFEPDGHBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action FLPLFHCCIDD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AddIsAnimated(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RemoveIsAnimated(object HMAOAMDKNDD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OPKPNNGHJNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece JABGNMOMDBN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece JABGNMOMDBN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider JFHMOLIAPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EIGCPMNHHBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject KLFJADJOODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid MKMIMABKHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string KPDCCEJPHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string ILEMILELHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 FCOKJGLMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 ICHCLDFIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion GNHNFAGLCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion MKBNFPHEILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float JLDIPJBLGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float NFBPMPNKKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 KGOENIIPAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 JMNELHBPGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IEECJKAIDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DDJHGAEHBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HOKNNLILNNH GDAHLEJCIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NCDEPAEENDN LOLBNOEDECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AEDDGIFFOHP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CanUpdateDeformation(Vector3 JCHOHLKMMHG, float BHBFMHKHOBJ, float IHBMMNIKIFF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void UpdateDeformation(Vector3 JCHOHLKMMHG, float BHBFMHKHOBJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CanBeRaycasted(Collider JFHMOLIAPLD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LHOBOCFHLIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MPBPFBAMFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JEKCPLPIDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 MEECEEAFLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Vector3 EGENCIPJHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HDCAPNACBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AOFELKOHMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EJMDLDGOKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NPMFOKNBFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PFPFBLNBBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EHPHGBLMLOE
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
	void OnDeformed(Vector3 ODPLEPBIIEJ);

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
	void OnHoverStart(NEBPKIKKIKD JILGEOMCFKO, Collider GDHALFKGBEP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OnHovering(NEBPKIKKIKD JILGEOMCFKO, Collider GDHALFKGBEP);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OnHoverFinished(NEBPKIKKIKD JILGEOMCFKO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Translate(Vector3 GKKENEDFBNK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Rotate(Quaternion OEBGHMFFGAK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool Scale(float HEPLPCOEDGD);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MAEOAAGLKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCMGPMDMPGF(in Vector3 OCNOPGJFBCJ, in Vector3 GNIANLFIOCO, ref Vector3 JNIKFJBCLEM, ref Vector3 DGILHLOCJDI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KKDEDBMBFHK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MLJMKOJHCLB FMAAEJBNEGK
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
public interface IGKNKCMHAKL
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MDJPMKOHJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LDMJCDHPEBD GFAHNAPKIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> HOKKINOMPFM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int GGHCPJALOBK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NDONKNPHCBK GetCulprit(LLDGHDBANCC NDIGAFELADA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBDCCIPGOGA
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<DHELGMNNHMI.GHHNJJFJNHL> PDPEFMIPJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(DHELGMNNHMI.GHHNJJFJNHL JEJGJHBBAED);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(DHELGMNNHMI.GHHNJJFJNHL JEJGJHBBAED);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NMCGACJBIEG
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CanModifyProperty(string IDLOFIFEDHN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NMELDDBNLAA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FHNHPFIBKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LNJGBHGLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ADBAFICGFIL
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int IOIAAAGNKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(JLAKINKJOFH? JDMDCLLKILA);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(IIFCEINCIPN? BLBGFDOJDFM);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LLDGHDBANCC CanBeSelected();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CanBeSelected(out LLDGHDBANCC MIMDGHHHHPD, out NDONKNPHCBK PLPJLIMLJMN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGGKOCLNCCM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FPKFMKAGCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo LLAGDJMFHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MPFICAPBPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NBGECMHEAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool AKFOJLBCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IKEAGLKGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FFPFHIEIJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool CODBCFFNAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool FMEJGFMKKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IEnumerable<Collider> NFNPABINOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool PEPNNNIFLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GENGFMEFAMO
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLDGHDBANCC CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo(out Vector3 LHCEFCJDGIJ, out Quaternion FDBNIAOOEMB, out float BDEINNLJOOB, out Vector3 CHBFBAMNMPA);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? LHCEFCJDGIJ, Quaternion? FDBNIAOOEMB, float? BDEINNLJOOB, Vector3? CHBFBAMNMPA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KILCJNADALO
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object MPJDKHCHCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type GJGJABKJGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid GKLHMIMONKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HOKNNLILNNH
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<JEBJICFMBLC> NPKEPMBCPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string ILEMILELHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string FNAKFFCJIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GGNGOEANAEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string> LNDPGMNCFMM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<HOKNNLILNNH> KACMDFNCGFO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<PGAPKOLEJAP, LJENCAPCAMI> EKKBEFCPDFB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action NIKAPMBJAIF;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IDPNPNECJON
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool LKJOJHPABFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DHELGMNNHMI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate PNAPKBPLCNA GHHNJJFJNHL();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<GHHNJJFJNHL> BOAFCBFNPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<GHHNJJFJNHL> ODAEHEIJPOI;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<GHHNJJFJNHL> JCGFFDKMEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7040", Offset = "0x6AB5A40", VA = "0x186AB7040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6E90", Offset = "0x6AB5890", VA = "0x186AB6E90")]
	public void IFPOOIAJHAI(GHHNJJFJNHL JEJGJHBBAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6E30", Offset = "0x6AB5830", VA = "0x186AB6E30")]
	public bool HEOHJOBENDL(GHHNJJFJNHL JEJGJHBBAED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum PNAPKBPLCNA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BDKIAOGGAKK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NCDEPAEENDN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int KGIADCPPLEK = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long JOELEBFNGNN = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private global::PPNHNIHBJIM<Guid, ObscuredLong, ObscuredInt, ObscuredBool> KGNKEHKHOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::NKJEKLKPDHK<ObscuredBool, ObscuredInt, ObscuredInt> EPGHFNHBJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun KEHJLNIPGPM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid IDCANLLEONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7600", Offset = "0x6AB6000", VA = "0x186AB7600")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long CCDKBGBFHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7BC0", Offset = "0x6AB65C0", VA = "0x186AB7BC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int LEIACPLFOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7C70", Offset = "0x6AB6670", VA = "0x186AB7C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CAAHMEEHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB73A0", Offset = "0x6AB5DA0", VA = "0x186AB73A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PAEGEOIPOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7B20", Offset = "0x6AB6520", VA = "0x186AB7B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MADCEFKBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7300", Offset = "0x6AB5D00", VA = "0x186AB7300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int MEINAPJMEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7440", Offset = "0x6AB5E40", VA = "0x186AB7440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MKGDEJKKJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7830", Offset = "0x6AB6230", VA = "0x186AB7830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7D80", Offset = "0x6AB6780", VA = "0x186AB7D80")]
	public NCDEPAEENDN(MonoBehaviourPun CBDPEODDCLL, string IJNLCOPLAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7E30", Offset = "0x6AB6830", VA = "0x186AB7E30")]
	public NCDEPAEENDN(MonoBehaviourPun CBDPEODDCLL, string IJNLCOPLAGG, Guid IBODBDNLJAH, long EACCBOLAMEL, int HEIEJJOOOKO, bool CJDHMNEGJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7670", Offset = "0x6AB6070", VA = "0x186AB7670")]
	public void IGJJPLMHNDA(NDONKNPHCBK MJIJOMNHFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB74E0", Offset = "0x6AB5EE0", VA = "0x186AB74E0")]
	public void HDHEKNFEBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7940", Offset = "0x6AB6340", VA = "0x186AB7940")]
	public void NCBKDFJCMBF(Guid ICGJCJACCHL, long EACCBOLAMEL, int HEIEJJOOOKO, bool CJDHMNEGJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7870", Offset = "0x6AB6270", VA = "0x186AB7870")]
	public void NCBKDFJCMBF(NCDEPAEENDN EHBPAFKHADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7D10", Offset = "0x6AB6710", VA = "0x186AB7D10")]
	public void PPIKMAKJCLK(KJNMBLEKJKE MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7250", Offset = "0x6AB5C50", VA = "0x186AB7250")]
	public void CKBPLEEALPG(KJNMBLEKJKE MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7190", Offset = "0x6AB5B90", VA = "0x186AB7190")]
	public static KJNMBLEKJKE CCLLAPOGCFA(Guid IBODBDNLJAH, long EACCBOLAMEL, int HFBFBGKLOOC, bool CJDHMNEGJDB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8160", Offset = "0x6AB6B60", VA = "0x186AB8160")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8270", Offset = "0x6AB6C70", VA = "0x186AB8270")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
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
