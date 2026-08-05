using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using EasyAntiCheat.Client;
using EasyAntiCheat.Client.ClientAuth;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AntiCheat
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class EACManager : MonoBehaviour, MIAGAOFLCBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ClientAuth NDBMEBFKEIC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PHHNAHNIKAH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCBB0", Offset = "0x6FBB7B0", VA = "0x186FBCBB0")]
		public static string GenerateChallengeResponse(string AEGJDBLBBHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC840", Offset = "0x6FBB440", VA = "0x186FBC840")]
		private static void BDOBPKOAIMB(PHODMKIPCLM.DKBJDDNLPOI MEKBNGFFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCFC0", Offset = "0x6FBBBC0", VA = "0x186FBCFC0")]
		private static bool KOIFGPGJGKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC920", Offset = "0x6FBB520", VA = "0x186FBC920")]
		private static void EGIBEMFBPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCCE0", Offset = "0x6FBB8E0", VA = "0x186FBCCE0")]
		private static void IBBBGANAAOD(object OGOCAPNGILI, LoadProgressEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC9B0", Offset = "0x6FBB5B0", VA = "0x186FBC9B0")]
		private static void GDGNDPLHJKL(object OGOCAPNGILI, LoadCompletedEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FBCE00", Offset = "0x6FBBA00", VA = "0x186FBCE00")]
		private static void IMEKCKGPHLJ(object OGOCAPNGILI, StateChangedEventArgs IKILIENHLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD4B0", Offset = "0x6FBC0B0", VA = "0x186FBD4B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD620", Offset = "0x6FBC220", VA = "0x186FBD620")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD2D0", Offset = "0x6FBBED0", VA = "0x186FBD2D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC920", Offset = "0x6FBB520", VA = "0x186FBC920")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC7F0", Offset = "0x6FBB3F0", VA = "0x186FBC7F0")]
		private void AMNGLBBKFIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD3D0", Offset = "0x6FBBFD0", VA = "0x186FBD3D0", Slot = "4")]
		public void PushNetworkMessage(PHODMKIPCLM.DKBJDDNLPOI MEKBNGFFPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
		public EACManager()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
