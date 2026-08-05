using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OEEJCCGGNDK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F13E0", Offset = "0x6F03E0", VA = "0x1806F13E0")]
	public OEEJCCGGNDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5116220", Offset = "0x5115220", VA = "0x185116220")]
	public byte[] DNEIANGALGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void HPCCNGPAEEH(IncrementalHash PBKICKIDADF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD62E50", Offset = "0xD61E50", VA = "0x180D62E50")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[MJJJBFPBFCK]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[HideInInspector]
	[MJJJBFPBFCK]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x511A950", Offset = "0x5119950", VA = "0x18511A950")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x511A910", Offset = "0x5119910", VA = "0x18511A910")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x511A990", Offset = "0x5119990", VA = "0x18511A990")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x511ABA0", Offset = "0x5119BA0", VA = "0x18511ABA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x511AB10", Offset = "0x5119B10", VA = "0x18511AB10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11753D0", Offset = "0x11743D0", VA = "0x1811753D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1146760", Offset = "0x1145760", VA = "0x181146760")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x511A8D0", Offset = "0x51198D0", VA = "0x18511A8D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x511AA80", Offset = "0x5119A80", VA = "0x18511AA80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x511A3C0", Offset = "0x51193C0", VA = "0x18511A3C0")]
	public void CopyBounds(SavedExtents GOAJJPLEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x511A840", Offset = "0x5119840", VA = "0x18511A840")]
	public void SetLocalSpaceBounds(Bounds EGAAHINJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8A4390", Offset = "0x8A3390", VA = "0x1808A4390")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x511A830", Offset = "0x5119830", VA = "0x18511A830")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x511A3F0", Offset = "0x51193F0", VA = "0x18511A3F0")]
	private void NIFMINDJJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x511A600", Offset = "0x5119600", VA = "0x18511A600")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5119E00", Offset = "0x5118E00", VA = "0x185119E00")]
	public static void CalculateLocalBoundsFor(GameObject CPHKFFAMPLG, out Bounds EGAAHINJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5119D40", Offset = "0x5118D40", VA = "0x185119D40")]
	private static void COPIFNKJPFP(Bounds BMEGDOGJIKK, Color HEMCNHOJBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x511A860", Offset = "0x5119860", VA = "0x18511A860")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x58DEE0", Offset = "0x58CEE0", VA = "0x18058DEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "4")]
	public virtual void HEJDOENKMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[OEEJCCGGNDK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2989A10", Offset = "0x2988A10", VA = "0x182989A10", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2989550", Offset = "0x2988550", VA = "0x182989550", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x298A010", Offset = "0x2989010", VA = "0x18298A010")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NMBLNOFPFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public NMBLNOFPFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EBAFC0", Offset = "0x3EB9FC0", VA = "0x183EBAFC0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[OEEJCCGGNDK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5290", Offset = "0x3EB4290", VA = "0x183EB5290", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB52C0", Offset = "0x3EB42C0", VA = "0x183EB52C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB51E0", Offset = "0x3EB41E0", VA = "0x183EB51E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey GLMMMFPEBHE]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5210", Offset = "0x3EB4210", VA = "0x183EB5210", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EB50E0", Offset = "0x3EB40E0", VA = "0x183EB50E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4940", Offset = "0x3EB3940", VA = "0x183EB4940", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EB42B0", Offset = "0x3EB32B0", VA = "0x183EB42B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3F10", Offset = "0x3EB2F10", VA = "0x183EB3F10", Slot = "14")]
	protected virtual string KBIMDGKCELG(TKeyVal ABPGGOFICFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3A34250", Offset = "0x3A33250", VA = "0x183A34250", Slot = "4")]
	public bool ContainsKey(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EB4FD0", Offset = "0x3EB3FD0", VA = "0x183EB4FD0", Slot = "5")]
	public bool TryGetValue(TKey GLMMMFPEBHE, out TVal GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3E20", Offset = "0x3EB2E20", VA = "0x183EB3E20", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EB3E20", Offset = "0x3EB2E20", VA = "0x183EB3E20", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3EB5000", Offset = "0x3EB4000", VA = "0x183EB5000")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BKKFPADEDCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NMDLCMLKHME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public NMDLCMLKHME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37CA3D0", Offset = "0x37C93D0", VA = "0x1837CA3D0")]
		internal bool <GetSamples>b__0(global::IGNDLNHHCFB<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float BJAOFLLOBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float AGPIKMHOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::IGNDLNHHCFB<float, T>> HEJMCCGGHNM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int NMDCGGMIAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37BBC40", Offset = "0x37BAC40", VA = "0x1837BBC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x37BC720", Offset = "0x37BB720", VA = "0x1837BC720")]
	public BKKFPADEDCA(float ENDELMNIOJP, float GPLBDIJLNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37BBE20", Offset = "0x37BAE20", VA = "0x1837BBE20")]
	public bool LOCGGJECGPJ(float OKBEGMNFMFA, T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37BC600", Offset = "0x37BB600", VA = "0x1837BC600")]
	public int OJDMEBNABHI(float OKBEGMNFMFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x37BC2C0", Offset = "0x37BB2C0", VA = "0x1837BC2C0")]
	public IEnumerable<T> MIJMKOGEOGK(float OKBEGMNFMFA, [Optional] float? MNBPIFDLKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x37BBB90", Offset = "0x37BAB90", VA = "0x1837BBB90")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x37BC660", Offset = "0x37BB660", VA = "0x1837BC660")]
	private void PAJEFMLGPOK(float OKBEGMNFMFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class CMCIOLEHOMM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DCOFMGBHADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T PDFBALCEGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float IBKBOPHOPNA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float CMEIPFKEMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> DLKKADCDKKL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int HPJOCKMBAPG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private DCOFMGBHADL[] FOHKJBHGAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int LMLJLDJKONA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float PEPIMPOLAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xFD0640", Offset = "0xFCF640", VA = "0x180FD0640")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDE8C50", Offset = "0xDE7C50", VA = "0x180DE8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B124A0", Offset = "0x3B114A0", VA = "0x183B124A0")]
	public CMCIOLEHOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B124D0", Offset = "0x3B114D0", VA = "0x183B124D0")]
	public CMCIOLEHOMM(int GGOGIDMAHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B11500", Offset = "0x3B10500", VA = "0x183B11500")]
	public void CGEJAMCGIKA(float OKBEGMNFMFA, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B110C0", Offset = "0x3B100C0", VA = "0x183B110C0")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B11E90", Offset = "0x3B10E90", VA = "0x183B11E90")]
	public bool PIBKLEFFFMO(float FEDDNKDGEDC, float JGAJFPKNPBC, out T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B11B70", Offset = "0x3B10B70", VA = "0x183B11B70")]
	public bool LADONPNEGON(float FEDDNKDGEDC, float JGAJFPKNPBC, out T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B11740", Offset = "0x3B10740", VA = "0x183B11740")]
	public void EGNMDNJKMAG(float FEDDNKDGEDC, float JGAJFPKNPBC, List<T> NMENBHGBOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B12420", Offset = "0x3B11420", VA = "0x183B12420")]
	private int PJMDGJODDBA(int LEMDGOBJLMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B119D0", Offset = "0x3B109D0", VA = "0x183B119D0")]
	private void KMPJDLOPIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ADNNPOOJJKM();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LLEIPPBJBNG(T KAGKGBBFFFK, T DIPABAFKBMG, float FHAKMOPLLAA);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HEIICGCDHDE(T GGAFBKIEDPG, float FHAKMOPLLAA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GLPIABHDBKL(T KAGKGBBFFFK, T DIPABAFKBMG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MMJBFNEOMFL(T KAGKGBBFFFK, T DIPABAFKBMG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OPPIPNGMKBE : global::CMCIOLEHOMM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5119110", Offset = "0x5118110", VA = "0x185119110", Slot = "4")]
	protected override Vector3 ADNNPOOJJKM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x51192D0", Offset = "0x51182D0", VA = "0x1851192D0", Slot = "5")]
	protected override Vector3 LLEIPPBJBNG(Vector3 KAGKGBBFFFK, Vector3 DIPABAFKBMG, float FHAKMOPLLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5119230", Offset = "0x5118230", VA = "0x185119230", Slot = "6")]
	protected override Vector3 HEIICGCDHDE(Vector3 GGAFBKIEDPG, float FHAKMOPLLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5119180", Offset = "0x5118180", VA = "0x185119180", Slot = "7")]
	protected override Vector3 GLPIABHDBKL(Vector3 KAGKGBBFFFK, Vector3 DIPABAFKBMG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5119390", Offset = "0x5118390", VA = "0x185119390", Slot = "8")]
	protected override Vector3 MMJBFNEOMFL(Vector3 KAGKGBBFFFK, Vector3 DIPABAFKBMG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5119400", Offset = "0x5118400", VA = "0x185119400")]
	public OPPIPNGMKBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JFMKMMLDFEK : global::CMCIOLEHOMM<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5116B00", Offset = "0x5115B00", VA = "0x185116B00")]
	public JFMKMMLDFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5116A90", Offset = "0x5115A90", VA = "0x185116A90")]
	public JFMKMMLDFEK(int GGOGIDMAHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xF18840", Offset = "0xF17840", VA = "0x180F18840", Slot = "4")]
	protected override float ADNNPOOJJKM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5116A00", Offset = "0x5115A00", VA = "0x185116A00", Slot = "5")]
	protected override float LLEIPPBJBNG(float KAGKGBBFFFK, float DIPABAFKBMG, float FHAKMOPLLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x417C550", Offset = "0x417B550", VA = "0x18417C550", Slot = "6")]
	protected override float HEIICGCDHDE(float GGAFBKIEDPG, float FHAKMOPLLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2568F00", Offset = "0x2567F00", VA = "0x182568F00", Slot = "7")]
	protected override float GLPIABHDBKL(float KAGKGBBFFFK, float DIPABAFKBMG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5116A80", Offset = "0x5115A80", VA = "0x185116A80", Slot = "8")]
	protected override float MMJBFNEOMFL(float KAGKGBBFFFK, float DIPABAFKBMG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MCDFJFDFGEM
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2200", Offset = "0x1FE1200", VA = "0x181FE2200")]
	public static global::JIJHEEPCGON<T1> NPKHJENBLIG<T1>(T1 PEDKNEIMBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x210EFE0", Offset = "0x210DFE0", VA = "0x18210EFE0")]
	public static global::IGNDLNHHCFB<T1, T2> NPKHJENBLIG<T1, T2>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1F50", Offset = "0x1FE0F50", VA = "0x181FE1F50")]
	public static global::OBHFJFHKFBH<T1, T2, T3> NPKHJENBLIG<T1, T2, T3>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC090", Offset = "0x1FDB090", VA = "0x181FDC090")]
	public static global::FIPDDBOMFME<T1, T2, T3, T4> NPKHJENBLIG<T1, T2, T3, T4>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2160", Offset = "0x1FE1160", VA = "0x181FE2160")]
	public static global::NOOLENMGPLP<T1, T2, T3, T4, T5> NPKHJENBLIG<T1, T2, T3, T4, T5>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FE20B0", Offset = "0x1FE10B0", VA = "0x181FE20B0")]
	public static global::PFGKGKFPBGK<T1, T2, T3, T4, T5, T6> NPKHJENBLIG<T1, T2, T3, T4, T5, T6>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC, T6 EOGOIKKBHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2358660", Offset = "0x2357660", VA = "0x182358660")]
	public static global::CCJKEEOINPI<T1, T2, T3, T4, T5, T6, T7> NPKHJENBLIG<T1, T2, T3, T4, T5, T6, T7>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC, T6 EOGOIKKBHOJ, T7 AKNFJGBGFOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FE1FE0", Offset = "0x1FE0FE0", VA = "0x181FE1FE0")]
	public static global::NIACIMBDFNE<T1, T2, T3, T4, T5, T6, T7, T8> NPKHJENBLIG<T1, T2, T3, T4, T5, T6, T7, T8>(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC, T6 EOGOIKKBHOJ, T7 AKNFJGBGFOK, T8 PEIIHKIIJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1AABE60", Offset = "0x1AAAE60", VA = "0x181AABE60")]
	[IteratorStateMachine(typeof(ECOKIOPBIKB))]
	public static IEnumerable<global::IGNDLNHHCFB<T1, T2>> EJMNMHIKJNN<T1, T2>(IEnumerable<T1> INIPPOEHOLP, IEnumerable<T2> BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1AADF40", Offset = "0x1AACF40", VA = "0x181AADF40")]
	[IteratorStateMachine(typeof(KHMJLNBMLKL))]
	public static IEnumerable<global::OBHFJFHKFBH<T1, T2, T3>> EJMNMHIKJNN<T1, T2, T3>(IEnumerable<T1> INIPPOEHOLP, IEnumerable<T2> BMEGDOGJIKK, IEnumerable<T3> HEMCNHOJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2734FB0", Offset = "0x2733FB0", VA = "0x182734FB0")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3E08670", Offset = "0x3E07670", VA = "0x183E08670")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN, int AHHFMILLCNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3E08680", Offset = "0x3E07680", VA = "0x183E08680")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN, int AHHFMILLCNC, int FHOMDOAJPHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5118950", Offset = "0x5117950", VA = "0x185118950")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN, int AHHFMILLCNC, int FHOMDOAJPHB, int JKALCHPLEMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5118970", Offset = "0x5117970", VA = "0x185118970")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN, int AHHFMILLCNC, int FHOMDOAJPHB, int JKALCHPLEMK, int HMMJALCMAED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5118990", Offset = "0x5117990", VA = "0x185118990")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN, int AHHFMILLCNC, int FHOMDOAJPHB, int JKALCHPLEMK, int HMMJALCMAED, int LFICFLMEFAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5118920", Offset = "0x5117920", VA = "0x185118920")]
	internal static int JNPIPHGMABO(int NJNIGDPKLME, int GKBOIMAKAMN, int AHHFMILLCNC, int FHOMDOAJPHB, int JKALCHPLEMK, int HMMJALCMAED, int LFICFLMEFAJ, int PPJMKHBLFDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JIJHEEPCGON<T1> : IComparable<global::JIJHEEPCGON<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2512C30", Offset = "0x2511C30", VA = "0x182512C30")]
	public JIJHEEPCGON(T1 PEDKNEIMBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x31B8CB0", Offset = "0x31B7CB0", VA = "0x1831B8CB0", Slot = "4")]
	public int CompareTo(global::JIJHEEPCGON<T1> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x31B8D20", Offset = "0x31B7D20", VA = "0x1831B8D20", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x896E50", Offset = "0x895E50", VA = "0x180896E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x31B8DC0", Offset = "0x31B7DC0", VA = "0x1831B8DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IGNDLNHHCFB<T1, T2> : IComparable<global::IGNDLNHHCFB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2199100", Offset = "0x2198100", VA = "0x182199100")]
	public IGNDLNHHCFB(T1 PEDKNEIMBNH, T2 CICLHGDOLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2197600", Offset = "0x2196600", VA = "0x182197600", Slot = "4")]
	public int CompareTo(global::IGNDLNHHCFB<T1, T2> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2198070", Offset = "0x2197070", VA = "0x182198070", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2198450", Offset = "0x2197450", VA = "0x182198450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2198A60", Offset = "0x2197A60", VA = "0x182198A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OBHFJFHKFBH<T1, T2, T3> : IComparable<global::OBHFJFHKFBH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 PKEHBLPMGJP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46E2B90", Offset = "0x46E1B90", VA = "0x1846E2B90")]
	public OBHFJFHKFBH(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46E24B0", Offset = "0x46E14B0", VA = "0x1846E24B0", Slot = "4")]
	public int CompareTo(global::OBHFJFHKFBH<T1, T2, T3> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46E25B0", Offset = "0x46E15B0", VA = "0x1846E25B0", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x46E2810", Offset = "0x46E1810", VA = "0x1846E2810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x46E2A00", Offset = "0x46E1A00", VA = "0x1846E2A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FIPDDBOMFME<T1, T2, T3, T4> : IComparable<global::FIPDDBOMFME<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 PKEHBLPMGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 MLOOJLKACKB;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x230CD70", Offset = "0x230BD70", VA = "0x18230CD70")]
	public FIPDDBOMFME(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2312440", Offset = "0x2311440", VA = "0x182312440", Slot = "4")]
	public int CompareTo(global::FIPDDBOMFME<T1, T2, T3, T4> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2312580", Offset = "0x2311580", VA = "0x182312580", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x23126A0", Offset = "0x23116A0", VA = "0x1823126A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2312760", Offset = "0x2311760", VA = "0x182312760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NOOLENMGPLP<T1, T2, T3, T4, T5> : IComparable<global::NOOLENMGPLP<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 PKEHBLPMGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 MLOOJLKACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 AECOKIAOOCM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D14EC0", Offset = "0x2D13EC0", VA = "0x182D14EC0")]
	public NOOLENMGPLP(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2D149D0", Offset = "0x2D139D0", VA = "0x182D149D0", Slot = "4")]
	public int CompareTo(global::NOOLENMGPLP<T1, T2, T3, T4, T5> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D14B50", Offset = "0x2D13B50", VA = "0x182D14B50", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D14C90", Offset = "0x2D13C90", VA = "0x182D14C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D14D90", Offset = "0x2D13D90", VA = "0x182D14D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PFGKGKFPBGK<T1, T2, T3, T4, T5, T6> : IComparable<global::PFGKGKFPBGK<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 PKEHBLPMGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 MLOOJLKACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 AECOKIAOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 LMGKPGALKDH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3177640", Offset = "0x3176640", VA = "0x183177640")]
	public PFGKGKFPBGK(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC, T6 EOGOIKKBHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31770A0", Offset = "0x31760A0", VA = "0x1831770A0", Slot = "4")]
	public int CompareTo(global::PFGKGKFPBGK<T1, T2, T3, T4, T5, T6> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3177260", Offset = "0x3176260", VA = "0x183177260", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x31773D0", Offset = "0x31763D0", VA = "0x1831773D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x31774F0", Offset = "0x31764F0", VA = "0x1831774F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CCJKEEOINPI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CCJKEEOINPI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 PKEHBLPMGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 MLOOJLKACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 AECOKIAOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 LMGKPGALKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 MJMCOHHEKLP;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x391B760", Offset = "0x391A760", VA = "0x18391B760")]
	public CCJKEEOINPI(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC, T6 EOGOIKKBHOJ, T7 AKNFJGBGFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x391B100", Offset = "0x391A100", VA = "0x18391B100", Slot = "4")]
	public int CompareTo(global::CCJKEEOINPI<T1, T2, T3, T4, T5, T6, T7> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x391B300", Offset = "0x391A300", VA = "0x18391B300", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x391B4A0", Offset = "0x391A4A0", VA = "0x18391B4A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x391B5F0", Offset = "0x391A5F0", VA = "0x18391B5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NIACIMBDFNE<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::NIACIMBDFNE<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 FPCAAGCDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 PBDBHNBANON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 PKEHBLPMGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 MLOOJLKACKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 AECOKIAOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 LMGKPGALKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 MJMCOHHEKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 MMIHIGBIFLN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D12A60", Offset = "0x2D11A60", VA = "0x182D12A60")]
	public NIACIMBDFNE(T1 PEDKNEIMBNH, T2 CICLHGDOLKB, T3 KFBMHPPDIAF, T4 CBPBFCHNDBE, T5 JIICJANAKCC, T6 EOGOIKKBHOJ, T7 AKNFJGBGFOK, T8 PEIIHKIIJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D12350", Offset = "0x2D11350", VA = "0x182D12350", Slot = "4")]
	public int CompareTo(global::NIACIMBDFNE<T1, T2, T3, T4, T5, T6, T7, T8> GOAJJPLEOBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D125A0", Offset = "0x2D115A0", VA = "0x182D125A0", Slot = "0")]
	public override bool Equals(object GOAJJPLEOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D12760", Offset = "0x2D11760", VA = "0x182D12760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2D128D0", Offset = "0x2D118D0", VA = "0x182D128D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float DIICEIFNLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x11211D0", Offset = "0x11201D0", VA = "0x1811211D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F59020", Offset = "0x3F58020", VA = "0x183F59020")]
	public T FNDPPCAMDME(float FHAKMOPLLAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F59200", Offset = "0x3F58200", VA = "0x183F59200")]
	public T OAOFBBFDCLD(float FHAKMOPLLAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LLEIPPBJBNG(T KAGKGBBFFFK, T DIPABAFKBMG, float FHAKMOPLLAA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x51156C0", Offset = "0x51146C0", VA = "0x1851156C0", Slot = "4")]
	protected override float LLEIPPBJBNG(float KAGKGBBFFFK, float DIPABAFKBMG, float FHAKMOPLLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5115740", Offset = "0x5114740", VA = "0x185115740")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x511BB00", Offset = "0x511AB00", VA = "0x18511BB00", Slot = "4")]
	protected override Vector3 LLEIPPBJBNG(Vector3 KAGKGBBFFFK, Vector3 DIPABAFKBMG, float FHAKMOPLLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x511BBC0", Offset = "0x511ABC0", VA = "0x18511BBC0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5114E60", Offset = "0x5113E60", VA = "0x185114E60", Slot = "4")]
	protected override Color LLEIPPBJBNG(Color KAGKGBBFFFK, Color DIPABAFKBMG, float FHAKMOPLLAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5114EB0", Offset = "0x5113EB0", VA = "0x185114EB0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FDFMICDIBPJ : global::IDKNOAOOJGH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5115260", Offset = "0x5114260", VA = "0x185115260")]
	public FDFMICDIBPJ(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x51152B0", Offset = "0x51142B0", VA = "0x1851152B0")]
	public FDFMICDIBPJ(JMJEPBNGPKL[] BCMOOGJJBNH, bool FCADBFBOAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51151F0", Offset = "0x51141F0", VA = "0x1851151F0", Slot = "6")]
	protected override uint PAKKNAOPPCN(uint PBKICKIDADF, string GGAFBKIEDPG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BNMGLLCGCCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IDisposable AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public BNMGLLCGCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DebuggerTypeProxy(typeof(global::ADPFACJIDPD<>.GBMFAGMJJAB))]
[DefaultMember("Item")]
public sealed class ADPFACJIDPD<T> : IDisposable, global::NDCMCJKMJOI<T>, OICFNCNNGKE, global::GJNILINCLMB<T, global::ADPFACJIDPD<T>.CLMGJPPPDIG>, global::FJAPCJKFAFD<T>, global::LAHMDLIOOMH<T, global::ADPFACJIDPD<T>.CLMGJPPPDIG>, global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, global::ADPFACJIDPD<T>.CLMGJPPPDIG>, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct CLMGJPPPDIG : OICFNCNNGKE, global::APIBCHMGLDE<T>, global::CGCGKCKEBCO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly global::ADPFACJIDPD<T> FHMJCGCJJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int ODHBMAPOBFB;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MMNJCBPCOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E830", Offset = "0x1E0D830", VA = "0x181E0E830", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T CNDEAJHHNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x356C970", Offset = "0x356B970", VA = "0x18356C970", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private T MIPCONBEDFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x356C060", Offset = "0x356B060", VA = "0x18356C060", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x356C3C0", Offset = "0x356B3C0", VA = "0x18356C3C0", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x356C520", Offset = "0x356B520", VA = "0x18356C520", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x356C810", Offset = "0x356B810", VA = "0x18356C810")]
		private CLMGJPPPDIG(global::ADPFACJIDPD<T> CKPEPLIGOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2312CD0", Offset = "0x2311CD0", VA = "0x182312CD0")]
		public static CLMGJPPPDIG JAJKAINKHFL(global::ADPFACJIDPD<T> CKPEPLIGOCA)
		{
			return default(CLMGJPPPDIG);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x356C240", Offset = "0x356B240", VA = "0x18356C240", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2312F20", Offset = "0x2311F20", VA = "0x182312F20", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class GBMFAGMJJAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly global::ADPFACJIDPD<T> FHMJCGCJJEH;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int MMNJCBPCOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x2185A40", Offset = "0x2184A40", VA = "0x182185A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T[] BBBOEANMIKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x356CA80", Offset = "0x356BA80", VA = "0x18356CA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool CKFMKJJBGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x356C9C0", Offset = "0x356B9C0", VA = "0x18356C9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2512C30", Offset = "0x2511C30", VA = "0x182512C30")]
		public GBMFAGMJJAB(global::ADPFACJIDPD<T> CKPEPLIGOCA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly GBIFLMBJKEL GIJACOEHOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private T[] CAOAECDDGAH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x58DCD0", Offset = "0x58CCD0", VA = "0x18058DCD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60EA10", Offset = "0x60DA10", VA = "0x18060EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Span<T> BBBOEANMIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3569E90", Offset = "0x3568E90", VA = "0x183569E90")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T BDHHAKHBMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3569380", Offset = "0x3568380", VA = "0x183569380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T KCGMMFLMJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3569380", Offset = "0x3568380", VA = "0x183569380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public T PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3569660", Offset = "0x3568660", VA = "0x183569660")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3569720", Offset = "0x3568720", VA = "0x183569720")]
	public static global::ADPFACJIDPD<T> JAJKAINKHFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x35694A0", Offset = "0x35684A0", VA = "0x1835694A0")]
	public static global::ADPFACJIDPD<T> HKGNPKBBJFL(int PGIGOJJPHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x356B490", Offset = "0x356A490", VA = "0x18356B490")]
	internal ADPFACJIDPD(T[] OBAIDLPIHKE, int GLCMJLMDOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3C30", Offset = "0x2CD2C30", VA = "0x182CD3C30", Slot = "5")]
	public T BFKDJLNGOIL(int FBIMLOLEMBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3568330", Offset = "0x3567330", VA = "0x183568330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3567D60", Offset = "0x3566D60", VA = "0x183567D60")]
	public void CGEJAMCGIKA(in T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3568EC0", Offset = "0x3567EC0", VA = "0x183568EC0")]
	public void GFECPOHOPOO(int GPNCGBOOKKF, in T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x356B3F0", Offset = "0x356A3F0", VA = "0x18356B3F0")]
	public void POJCEAPHLKE(int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x356AEB0", Offset = "0x3569EB0", VA = "0x18356AEB0")]
	public void LMHNKOBCFIN(int GGOGIDMAHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3569860", Offset = "0x3568860", VA = "0x183569860")]
	private void JNJBENCJMKC(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3567D30", Offset = "0x3566D30", VA = "0x183567D30")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3568720", Offset = "0x3567720", VA = "0x183568720")]
	public global::ADPFACJIDPD<T> FJKLBILFPGB(global::GIOKDKCNFMK<T, T> ILAACKLDJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x35693E0", Offset = "0x35683E0", VA = "0x1835693E0", Slot = "11")]
	public CLMGJPPPDIG GetEnumerator()
	{
		return default(CLMGJPPPDIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3569420", Offset = "0x3568420", VA = "0x183569420", Slot = "8")]
	private global::APIBCHMGLDE<T> HFIKKCMMPOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3569420", Offset = "0x3568420", VA = "0x183569420", Slot = "10")]
	private global::CGCGKCKEBCO<T> LOJLECAFMNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3569420", Offset = "0x3568420", VA = "0x183569420", Slot = "12")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3569420", Offset = "0x3568420", VA = "0x183569420", Slot = "13")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FIBNHIFEHAD
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x233EB60", Offset = "0x233DB60", VA = "0x18233EB60")]
	public static bool BDNIEJLJCGA<T>(this global::ADPFACJIDPD<T> CKPEPLIGOCA, in T GGAFBKIEDPG) where T : global::LMGPICICJNP<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BJAHEDKKPAL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MDNNOIALANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<GGOCMJFKKGA> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public MDNNOIALANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x51189C0", Offset = "0x51179C0", VA = "0x1851189C0")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<GGOCMJFKKGA>> DLFACHLJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int AEJMFDJFMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int OFKIBPNHGCL;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x99A6E0", Offset = "0x9996E0", VA = "0x18099A6E0")]
	private BJAHEDKKPAL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<GGOCMJFKKGA>> GCEMPDKCKCO, int AJJDCHOFLPF, int PLGIOFIFKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5114C00", Offset = "0x5113C00", VA = "0x185114C00")]
	public static BJAHEDKKPAL JAJKAINKHFL()
	{
		return default(BJAHEDKKPAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x51148B0", Offset = "0x51138B0", VA = "0x1851148B0")]
	public (int, int, Task) HOFJIAELIKB(int NOMLJBFLBIA, [Optional] CancellationToken MCLPFBCBLEM)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5114800", Offset = "0x5113800", VA = "0x185114800")]
	public void DLJMGDHFHBJ(int NOMLJBFLBIA, int PLGIOFIFKAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class LAFKGKPJGKJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<TKey, TVal> KLINMHHBDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<TVal, TKey> DNKGJBFHEIP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2185A40", Offset = "0x2184A40", VA = "0x182185A40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PJKCBAHKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ICollection<TKey> KCPKGPGJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2975F10", Offset = "0x2974F10", VA = "0x182975F10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ICollection<TVal> OHKCEIBNBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2195EB0", Offset = "0x2194EB0", VA = "0x182195EB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public TVal PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x22EE5E0", Offset = "0x22ED5E0", VA = "0x1822EE5E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x36FDC00", Offset = "0x36FCC00", VA = "0x1836FDC00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public TKey PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x36FD550", Offset = "0x36FC550", VA = "0x1836FD550")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x36FD200", Offset = "0x36FC200", VA = "0x1836FD200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x36FD110", Offset = "0x36FC110", VA = "0x1836FD110", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x36FDAA0", Offset = "0x36FCAA0", VA = "0x1836FDAA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3389C80", Offset = "0x3388C80", VA = "0x183389C80", Slot = "9")]
	public void Add(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x36FCFC0", Offset = "0x36FBFC0", VA = "0x1836FCFC0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DOBBOGAJKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x30AADF0", Offset = "0x30A9DF0", VA = "0x1830AADF0", Slot = "8")]
	public bool ContainsKey(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2195610", Offset = "0x2194610", VA = "0x182195610", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x36FDA20", Offset = "0x36FCA20", VA = "0x1836FDA20", Slot = "10")]
	public bool Remove(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x36FDA20", Offset = "0x36FCA20", VA = "0x1836FDA20", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x36FDAF0", Offset = "0x36FCAF0", VA = "0x1836FDAF0", Slot = "11")]
	public bool TryGetValue(TKey GLMMMFPEBHE, out TVal GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x36FD4D0", Offset = "0x36FC4D0", VA = "0x1836FD4D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x36FD1A0", Offset = "0x36FC1A0", VA = "0x1836FD1A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FOHKJBHGAHL, int HNFMGALMLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x36FD030", Offset = "0x36FC030", VA = "0x1836FD030")]
	public void CGEJAMCGIKA(TVal LBEFLEJKHJN, TKey GLMMMFPEBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x36FCFF0", Offset = "0x36FBFF0", VA = "0x1836FCFF0")]
	public void CGEJAMCGIKA(KeyValuePair<TVal, TKey> DOBBOGAJKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x36FD0E0", Offset = "0x36FC0E0", VA = "0x1836FD0E0")]
	public bool CHPHJBEFLLE(TVal GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x28725E0", Offset = "0x28715E0", VA = "0x1828725E0")]
	public bool FDJOBPPDLBD(KeyValuePair<TVal, TKey> DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE6B0", Offset = "0x2BFD6B0", VA = "0x182BFE6B0")]
	public bool IDBFDJDECBI(TVal GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE6B0", Offset = "0x2BFD6B0", VA = "0x182BFE6B0")]
	public bool IDBFDJDECBI(KeyValuePair<TVal, TKey> DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x36FD6C0", Offset = "0x36FC6C0", VA = "0x1836FD6C0")]
	public bool NHHHDIDPJMI(TVal GLMMMFPEBHE, out TKey GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x36FD3C0", Offset = "0x36FC3C0", VA = "0x1836FD3C0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> GBJGIHLIPMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x36FD310", Offset = "0x36FC310", VA = "0x1836FD310")]
	private void EMMMJHKPNCA(TKey GLMMMFPEBHE, TVal LBEFLEJKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x36FD640", Offset = "0x36FC640", VA = "0x1836FD640")]
	private void MEJKOFIKBGN(TKey GLMMMFPEBHE, TVal LBEFLEJKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x36FD7B0", Offset = "0x36FC7B0", VA = "0x1836FD7B0")]
	private bool PMNGOMLLIOM(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x36FD6F0", Offset = "0x36FC6F0", VA = "0x1836FD6F0")]
	private bool PMNGOMLLIOM(TVal LBEFLEJKHJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x36FDB20", Offset = "0x36FCB20", VA = "0x1836FDB20")]
	public LAFKGKPJGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class JKBIJBDOPHA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private global::JKBIJBDOPHA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xFD0640", Offset = "0xFCF640", VA = "0x180FD0640", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x3B4B9F0", Offset = "0x3B4A9F0", VA = "0x183B4B9F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x3B4BE30", Offset = "0x3B4AE30", VA = "0x183B4BE30")]
		public Enumerator(global::JKBIJBDOPHA<T> NMENBHGBOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B3B0", Offset = "0x3B4A3B0", VA = "0x183B4B3B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B7A0", Offset = "0x3B4A7A0", VA = "0x183B4B7A0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B070", Offset = "0x3B4A070", VA = "0x183B4B070")]
		private void GPDAMIJEPHJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private T[] ABADPJGEKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private int EEMJGKOCJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int CNMAMPILMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int MHHPMGFBNFK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3B4E6C0", Offset = "0x3B4D6C0", VA = "0x183B4E6C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3B4DE90", Offset = "0x3B4CE90", VA = "0x183B4DE90")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3B4DBF0", Offset = "0x3B4CBF0", VA = "0x183B4DBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F510", Offset = "0x3B4E510", VA = "0x183B4F510")]
	public JKBIJBDOPHA(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DA80", Offset = "0x3B4CA80", VA = "0x183B4DA80")]
	public void CGEJAMCGIKA(T FHAKMOPLLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B4ED20", Offset = "0x3B4DD20", VA = "0x183B4ED20")]
	public void PEEKPNKCNEO(IEnumerable<T> MMNAKGFLJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D490", Offset = "0x3B4C490", VA = "0x183B4D490")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DF90", Offset = "0x3B4CF90", VA = "0x183B4DF90")]
	public void JLKDCFBPCFD(int GLCMJLMDOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D870", Offset = "0x3B4C870", VA = "0x183B4D870")]
	public void BKJHKLHCFFI(int GLCMJLMDOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E170", Offset = "0x3B4D170", VA = "0x183B4E170")]
	public void LLLCHFDPIGP(T[] FOHKJBHGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E5E0", Offset = "0x3B4D5E0", VA = "0x183B4E5E0")]
	public Enumerator LNOKBJIIFFP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F320", Offset = "0x3B4E320", VA = "0x183B4F320", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F320", Offset = "0x3B4E320", VA = "0x183B4F320", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D4B0", Offset = "0x3B4C4B0", VA = "0x183B4D4B0")]
	private int ADLNMGMAPFF(int GPNCGBOOKKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DDE0", Offset = "0x3B4CDE0", VA = "0x183B4DDE0")]
	private int GBLPCEGAIBP(int GPNCGBOOKKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HGFEOHCEDEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDisposable[] CAOAECDDGAH;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD170", VA = "0x1806CE170")]
	public HGFEOHCEDEO(params IDisposable[] OBAIDLPIHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xDBF010", Offset = "0xDBE010", VA = "0x180DBF010")]
	public static HGFEOHCEDEO JAJKAINKHFL(params IDisposable[] OBAIDLPIHKE)
	{
		return default(HGFEOHCEDEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5115DB0", Offset = "0x5114DB0", VA = "0x185115DB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DMEECFIABBG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly IDisposable JFOENPCMFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public T PDFBALCEGGK;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB180", Offset = "0x2BFA180", VA = "0x182BFB180")]
	public DMEECFIABBG(IDisposable FIPJKEDOGKB, in T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x27A9E40", Offset = "0x27A8E40", VA = "0x1827A9E40")]
	public static global::DMEECFIABBG<U> APIEIEPAHLH<U>(in global::DMEECFIABBG<T> FIPJKEDOGKB, in U GGAFBKIEDPG)
	{
		return default(global::DMEECFIABBG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x210E8E0", Offset = "0x210D8E0", VA = "0x18210E8E0")]
	public global::DMEECFIABBG<U> EMDHJCMPLAL<U>(in U GGAFBKIEDPG)
	{
		return default(global::DMEECFIABBG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x27A9E80", Offset = "0x27A8E80", VA = "0x1827A9E80")]
	public static global::DMEECFIABBG<(T, U)> IFMCJLLCDPL<U>(in global::DMEECFIABBG<T> INIPPOEHOLP, in global::DMEECFIABBG<U> BMEGDOGJIKK)
	{
		return default(global::DMEECFIABBG<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3CAC160", Offset = "0x3CAB160", VA = "0x183CAC160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EMOFMIJKBNA
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x27AA120", Offset = "0x27A9120", VA = "0x1827AA120")]
	public static global::DMEECFIABBG<T> JAJKAINKHFL<T>(IDisposable FIPJKEDOGKB, in T GGAFBKIEDPG)
	{
		return default(global::DMEECFIABBG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x210E8E0", Offset = "0x210D8E0", VA = "0x18210E8E0")]
	public static global::DMEECFIABBG<U> APIEIEPAHLH<U, T>(in global::DMEECFIABBG<T> ENOLLOPFFGK, in U GGAFBKIEDPG)
	{
		return default(global::DMEECFIABBG<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x210E960", Offset = "0x210D960", VA = "0x18210E960")]
	public static global::DMEECFIABBG<(T, U)> IFMCJLLCDPL<T, U>(in global::DMEECFIABBG<T> INIPPOEHOLP, in global::DMEECFIABBG<U> BMEGDOGJIKK)
	{
		return default(global::DMEECFIABBG<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GBIFLMBJKEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0")]
	public static GBIFLMBJKEL AKMFFMJHGLE<T>([Optional] string FHFCKKDBJHO, [Optional] string EHBNBCECIKO, bool PDEDGNCGGHN = false)
	{
		return default(GBIFLMBJKEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public readonly struct EGPNFCGNBBH<T> : global::LAHMDLIOOMH<T, global::EGPNFCGNBBH<T>.IPJKKIFHGOF>, global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, global::EGPNFCGNBBH<T>.IPJKKIFHGOF>, IEnumerable<T>, IEnumerable, global::NDCMCJKMJOI<T>, OICFNCNNGKE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct IPJKKIFHGOF : OICFNCNNGKE, global::CGCGKCKEBCO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly T[] FHMJCGCJJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int ODHBMAPOBFB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int MMNJCBPCOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x23CDA20", Offset = "0x23CCA20", VA = "0x1823CDA20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T CNDEAJHHNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x31D7C80", Offset = "0x31D6C80", VA = "0x1831D7C80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x31D7C30", Offset = "0x31D6C30", VA = "0x1831D7C30", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x31D7C30", Offset = "0x31D6C30", VA = "0x1831D7C30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9CE790", Offset = "0x9CD790", VA = "0x1809CE790")]
		private IPJKKIFHGOF(T[] CKPEPLIGOCA, int GPNCGBOOKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2312CD0", Offset = "0x2311CD0", VA = "0x182312CD0")]
		public static IPJKKIFHGOF JAJKAINKHFL(T[] CKPEPLIGOCA)
		{
			return default(IPJKKIFHGOF);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x31D7C00", Offset = "0x31D6C00", VA = "0x1831D7C00", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2312F20", Offset = "0x2311F20", VA = "0x182312F20", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly T[] IBCIDPMLEAC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int EMPOCCIPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x23CDA20", Offset = "0x23CCA20", VA = "0x1823CDA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x31D0440", Offset = "0x31CF440", VA = "0x1831D0440", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F6E0", Offset = "0x2D0E6E0", VA = "0x182D0F6E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD170", VA = "0x1806CE170")]
	internal EGPNFCGNBBH(T[] FOHKJBHGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x31D0480", Offset = "0x31CF480", VA = "0x1831D0480")]
	public static global::EGPNFCGNBBH<T> NJGNJIEBDOK()
	{
		return default(global::EGPNFCGNBBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x31D0240", Offset = "0x31CF240", VA = "0x1831D0240", Slot = "9")]
	public T BFKDJLNGOIL(int GPNCGBOOKKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x31D02A0", Offset = "0x31CF2A0", VA = "0x1831D02A0", Slot = "6")]
	public IPJKKIFHGOF GetEnumerator()
	{
		return default(IPJKKIFHGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x31D0340", Offset = "0x31CF340", VA = "0x1831D0340", Slot = "5")]
	private global::CGCGKCKEBCO<T> LOJLECAFMNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x31D0340", Offset = "0x31CF340", VA = "0x1831D0340", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x31D0340", Offset = "0x31CF340", VA = "0x1831D0340", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AINHOOIAFKE
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4100", Offset = "0x1FD3100", VA = "0x181FD4100")]
	public static global::EGPNFCGNBBH<T> JAJKAINKHFL<T>(T[] FOHKJBHGAHL)
	{
		return default(global::EGPNFCGNBBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x17D0840", Offset = "0x17CF840", VA = "0x1817D0840")]
	public static global::EGPNFCGNBBH<T> EGCNFIKMHKH<T>(this T[] CKPEPLIGOCA)
	{
		return default(global::EGPNFCGNBBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD40D0", Offset = "0x1FD30D0", VA = "0x181FD40D0")]
	public static global::EGPNFCGNBBH<T>.IPJKKIFHGOF BOCKAGMLNHN<T>(this T[] CKPEPLIGOCA)
	{
		return default(global::EGPNFCGNBBH<T>.IPJKKIFHGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x17D0840", Offset = "0x17CF840", VA = "0x1817D0840")]
	public static global::EGPNFCGNBBH<T> JKMBPIFFHII<T>(this T[] CKPEPLIGOCA)
	{
		return default(global::EGPNFCGNBBH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct LMCIDCLDNDG<T, U> : global::LAHMDLIOOMH<T, U>, global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, U>, IEnumerable<T>, IEnumerable where U : global::CGCGKCKEBCO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly U IDFLAKCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2C02D00", Offset = "0x2C01D00", VA = "0x182C02D00")]
	internal LMCIDCLDNDG(in U BLDBIJHEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7630E0", Offset = "0x7620E0", VA = "0x1807630E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "5")]
	private global::CGCGKCKEBCO<T> LOJLECAFMNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "7")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NOJILOGNPAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4680", Offset = "0x1FD3680", VA = "0x181FD4680")]
	public static global::LMCIDCLDNDG<T, U> JAJKAINKHFL<U>(in U BLDBIJHEJFJ) where U : global::CGCGKCKEBCO<T>
	{
		return default(global::LMCIDCLDNDG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GNFNEFHGMPA<TResult, TResultEnumerator> where TResultEnumerator : global::CGCGKCKEBCO<TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1EDE7B0", Offset = "0x1EDD7B0", VA = "0x181EDE7B0")]
	public static global::AMKAFBPFFFE<TSourceEnumerator, TResultEnumerator, TResult> ANIDDDHJFNG<TSourceEnumerator>(in TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : IEnumerator<TResultEnumerator>
	{
		return default(global::AMKAFBPFFFE<TSourceEnumerator, TResultEnumerator, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct AMKAFBPFFFE<TSourceEnumerator, TResultEnumerator, TResult> : global::CGCGKCKEBCO<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IEnumerator<TResultEnumerator> where TResultEnumerator : global::CGCGKCKEBCO<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private TSourceEnumerator FHMJCGCJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private TResultEnumerator BDMFFEABAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool GIMNKDHAFNB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public TResult CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x43A18C0", Offset = "0x43A08C0", VA = "0x1843A18C0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x43A1820", Offset = "0x43A0820", VA = "0x1843A1820", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x43A1820", Offset = "0x43A0820", VA = "0x1843A1820", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x43A1870", Offset = "0x43A0870", VA = "0x1843A1870")]
	internal AMKAFBPFFFE(in TSourceEnumerator CKPEPLIGOCA, in TResultEnumerator KJNIKKIKCIM, bool IOIHMHDDFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x43A16A0", Offset = "0x43A06A0", VA = "0x1843A16A0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x43A17D0", Offset = "0x43A07D0", VA = "0x1843A17D0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x43A1650", Offset = "0x43A0650", VA = "0x1843A1650", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MFFABLOPFLC<TSourceEnumerator, TSource, TResult> : OICFNCNNGKE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OICFNCNNGKE, global::CGCGKCKEBCO<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private TSourceEnumerator FHMJCGCJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly global::GIOKDKCNFMK<TSource, TResult> NGGOLEAPJOK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3187C00", Offset = "0x3186C00", VA = "0x183187C00", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TResult CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3188330", Offset = "0x3187330", VA = "0x183188330", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x31881F0", Offset = "0x31871F0", VA = "0x1831881F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x23C28B0", Offset = "0x23C18B0", VA = "0x1823C28B0")]
	internal MFFABLOPFLC(in TSourceEnumerator CKPEPLIGOCA, global::GIOKDKCNFMK<TSource, TResult> MNPGBOJMBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3187E90", Offset = "0x3186E90", VA = "0x183187E90", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x31880C0", Offset = "0x31870C0", VA = "0x1831880C0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3187890", Offset = "0x3186890", VA = "0x183187890", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BFKPMOEMKNI<TSourceEnumerator, TSource, TResultEnumerator, TResult> : global::CGCGKCKEBCO<TResult>, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : global::CGCGKCKEBCO<TSource> where TResultEnumerator : global::CGCGKCKEBCO<TResult>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private TSourceEnumerator FHMJCGCJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private TResultEnumerator BDMFFEABAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly global::GIOKDKCNFMK<TSource, TResultEnumerator> NGGOLEAPJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool GIMNKDHAFNB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TResult CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x37BAEB0", Offset = "0x37B9EB0", VA = "0x1837BAEB0", Slot = "4")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	TResult IEnumerator<TResult>.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x37BADC0", Offset = "0x37B9DC0", VA = "0x1837BADC0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x37BADC0", Offset = "0x37B9DC0", VA = "0x1837BADC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x37BAE50", Offset = "0x37B9E50", VA = "0x1837BAE50")]
	internal BFKPMOEMKNI(in TSourceEnumerator CKPEPLIGOCA, in TResultEnumerator KJNIKKIKCIM, global::GIOKDKCNFMK<TSource, TResultEnumerator> MNPGBOJMBLJ, bool IOIHMHDDFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x37BABE0", Offset = "0x37B9BE0", VA = "0x1837BABE0", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x37BAD70", Offset = "0x37B9D70", VA = "0x1837BAD70", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x37BAB90", Offset = "0x37B9B90", VA = "0x1837BAB90", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NICIPBGHEDK<TSource1Enumerator, TSource1, TSource2Enumerator, TSource2> : OICFNCNNGKE, IEnumerator<(TSource1, TSource2)>, IEnumerator, IDisposable where TSource1Enumerator : OICFNCNNGKE, global::CGCGKCKEBCO<TSource1> where TSource2Enumerator : OICFNCNNGKE, global::CGCGKCKEBCO<TSource2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private TSource1Enumerator HJJDJLCJOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private TSource2Enumerator BABEAIFPJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2D12B90", Offset = "0x2D11B90", VA = "0x182D12B90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public (TSource1, TSource2) CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2D12DB0", Offset = "0x2D11DB0", VA = "0x182D12DB0", Slot = "5")]
		get
		{
			return default((TSource1, TSource2));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2D12D10", Offset = "0x2D11D10", VA = "0x182D12D10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x268DDB0", Offset = "0x268CDB0", VA = "0x18268DDB0")]
	internal NICIPBGHEDK(in TSource1Enumerator FFBADIBHIMC, in TSource2Enumerator EIHGJONLDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2D12C30", Offset = "0x2D11C30", VA = "0x182D12C30", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2D12CA0", Offset = "0x2D11CA0", VA = "0x182D12CA0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2D12B30", Offset = "0x2D11B30", VA = "0x182D12B30", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct JJIGNGFEJJE<T, U> : global::KFCPKIBNDDO<T, U>, IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly U IDFLAKCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D470", Offset = "0x3B4C470", VA = "0x183B4D470")]
	internal JJIGNGFEJJE(in U BLDBIJHEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x23C32B0", Offset = "0x23C22B0", VA = "0x1823C32B0", Slot = "4")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D3E0", Offset = "0x3B4C3E0", VA = "0x183B4D3E0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D3E0", Offset = "0x3B4C3E0", VA = "0x183B4D3E0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class EPKJLOPJCLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4630", Offset = "0x1FD3630", VA = "0x181FD4630")]
	public static global::JJIGNGFEJJE<T, U> JAJKAINKHFL<U>(in U BLDBIJHEJFJ) where U : IEnumerator<T>
	{
		return default(global::JJIGNGFEJJE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct DCMAHGNCJMI<TSourceEnumerator, TSource, TResult> : OICFNCNNGKE, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : OICFNCNNGKE, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private TSourceEnumerator FHMJCGCJJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Func<TSource, TResult> NGGOLEAPJOK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3A1E9B0", Offset = "0x3A1D9B0", VA = "0x183A1E9B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public TResult CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3188680", Offset = "0x3187680", VA = "0x183188680", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x31882B0", Offset = "0x31872B0", VA = "0x1831882B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x31882F0", Offset = "0x31872F0", VA = "0x1831882F0")]
	internal DCMAHGNCJMI(in TSourceEnumerator CKPEPLIGOCA, Func<TSource, TResult> MNPGBOJMBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3A1EA00", Offset = "0x3A1DA00", VA = "0x183A1EA00", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3A1EA50", Offset = "0x3A1DA50", VA = "0x183A1EA50", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3A1E960", Offset = "0x3A1D960", VA = "0x183A1E960", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OHNPIEMIMAA
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x26D6580", Offset = "0x26D5580", VA = "0x1826D6580")]
	public static bool ICFNPNEDOKD<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator CKPEPLIGOCA, in TArgs LMJLMIIJEAB, in global::HBLACCDDAHH<TArgs, TSource, bool> KDCNDMMHAPG) where TSourceEnumerator : global::CGCGKCKEBCO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2012AC0", Offset = "0x2011AC0", VA = "0x182012AC0")]
	public static int BFHDLHBOCAM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator CKPEPLIGOCA, in TArgs LMJLMIIJEAB, global::HBLACCDDAHH<TArgs, TSource, bool> KDCNDMMHAPG) where TSourceEnumerator : global::CGCGKCKEBCO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x26D64A0", Offset = "0x26D54A0", VA = "0x1826D64A0")]
	public static bool DAMJMGLAHAO<TSourceEnumerator, TSource>(this TSourceEnumerator CKPEPLIGOCA, in TSource DOBBOGAJKHF) where TSourceEnumerator : global::CGCGKCKEBCO<TSource> where TSource : global::LMGPICICJNP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2012DB0", Offset = "0x2011DB0", VA = "0x182012DB0")]
	public static int CBADHLNKGDL<TSourceEnumerator, TSource>(this TSourceEnumerator CKPEPLIGOCA, in TSource GGAFBKIEDPG) where TSourceEnumerator : global::CGCGKCKEBCO<TSource> where TSource : global::LMGPICICJNP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5680", Offset = "0x1FE4680", VA = "0x181FE5680")]
	public static global::MFFABLOPFLC<TSourceEnumerator, TSource, TResult> DACMKLBBOGE<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CKPEPLIGOCA, global::GIOKDKCNFMK<TSource, TResult> MNPGBOJMBLJ) where TSourceEnumerator : OICFNCNNGKE, global::CGCGKCKEBCO<TSource>
	{
		return default(global::MFFABLOPFLC<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1FE56D0", Offset = "0x1FE46D0", VA = "0x181FE56D0")]
	public static global::DCMAHGNCJMI<TSourceEnumerator, TSource, TResult> NDGLALMLLCJ<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator CKPEPLIGOCA, Func<TSource, TResult> MNPGBOJMBLJ) where TSourceEnumerator : OICFNCNNGKE, IEnumerator<TSource>
	{
		return default(global::DCMAHGNCJMI<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OICINPCIEBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x26D6990", Offset = "0x26D5990", VA = "0x1826D6990")]
	public static bool JJNONIDEEEH<TSourceEnumerator>(TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x17D56B0", Offset = "0x17D46B0", VA = "0x1817D56B0")]
	public static T BOPDLLBDGPM<TSourceEnumerator>(TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : global::CGCGKCKEBCO<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x235A7B0", Offset = "0x23597B0", VA = "0x18235A7B0")]
	public static global::BFKPMOEMKNI<TSourceEnumerator, TSource, TResultEnumerator, T> BGGCLLLDIFP<TSourceEnumerator, TSource, TResultEnumerator>(in TSourceEnumerator CKPEPLIGOCA, global::GIOKDKCNFMK<TSource, TResultEnumerator> MNPGBOJMBLJ) where TSourceEnumerator : global::CGCGKCKEBCO<TSource> where TResultEnumerator : global::CGCGKCKEBCO<T>
	{
		return default(global::BFKPMOEMKNI<TSourceEnumerator, TSource, TResultEnumerator, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x36DF150", Offset = "0x36DE150", VA = "0x1836DF150")]
	public static string BKMCCJIBFGO<TSourceEnumerator>(TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2F5C3A0", Offset = "0x2F5B3A0", VA = "0x182F5C3A0")]
	public static T[] FFKAHDBLBBD<TSourceEnumerator>(TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : OICFNCNNGKE, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1F71540", Offset = "0x1F70540", VA = "0x181F71540")]
	public static T GOPCFOBNLMG<TSourceEnumerator>(TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x26D6860", Offset = "0x26D5860", VA = "0x1826D6860")]
	public static bool DODMDHNDCHH<TSourceEnumerator>(TSourceEnumerator CKPEPLIGOCA) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GBDPIDOHPPP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5B50", Offset = "0x1FD4B50", VA = "0x181FD5B50")]
	public static global::NICIPBGHEDK<TSource1Enumerator, T, TSource2Enumerator, U> KLHBNHGLOID<TSource1Enumerator, TSource2Enumerator>(in TSource1Enumerator FFBADIBHIMC, in TSource2Enumerator EIHGJONLDBD) where TSource1Enumerator : OICFNCNNGKE, global::CGCGKCKEBCO<T> where TSource2Enumerator : OICFNCNNGKE, global::CGCGKCKEBCO<U>
	{
		return default(global::NICIPBGHEDK<TSource1Enumerator, T, TSource2Enumerator, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PAMFOELBBOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CGCGKCKEBCO<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LAHMDLIOOMH<T, TEnumerator> : global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::CGCGKCKEBCO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface CGCGKCKEBCO<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	T CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface NDCMCJKMJOI<T> : OICFNCNNGKE
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T BFKDJLNGOIL(int FBIMLOLEMBB);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KFCPKIBNDDO<T, TEnumerator> : IEnumerable<T>, IEnumerable where TEnumerator : IEnumerator<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface OICFNCNNGKE
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LMGPICICJNP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMJIBFIFLBB(in T GOAJJPLEOBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface FJAPCJKFAFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::APIBCHMGLDE<T> GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GJNILINCLMB<T, TEnumerator> : global::FJAPCJKFAFD<T>, global::LAHMDLIOOMH<T, TEnumerator>, global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, TEnumerator>, IEnumerable<T>, IEnumerable where TEnumerator : global::APIBCHMGLDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	new TEnumerator GetEnumerator();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface APIBCHMGLDE<T> : global::CGCGKCKEBCO<T>, IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	new T CNDEAJHHNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public delegate void OKDCNHGJNIO<T>(in T NPOOFIGPHFP);
[Cpp2IlInjected.Token(Token = "0x200004A")]
public delegate void PCDACLDJDIE<T1, T2>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG);
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class MKFHLENIMHP
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x26D0520", Offset = "0x26CF520", VA = "0x1826D0520")]
	public static bool IMGOIGPLJED<T, U>(this T CKPEPLIGOCA, in U NHBCHHMAJOK) where T : global::LMGPICICJNP<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public delegate TResult GIOKDKCNFMK<T, out TResult>(in T NPOOFIGPHFP);
[Cpp2IlInjected.Token(Token = "0x200004D")]
public delegate TResult HBLACCDDAHH<T1, T2, out TResult>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG);
[Cpp2IlInjected.Token(Token = "0x200004E")]
public delegate TResult KJFKBNDOEKA<T1, T2, T3, out TResult>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG, in T3 KNBANGHBPDO);
[Cpp2IlInjected.Token(Token = "0x200004F")]
public delegate TResult NBOGHBPEGNB<T1, T2, T3, T4, out TResult>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG, in T3 KNBANGHBPDO, in T4 IAKJENCNKHP);
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate TResult BADHAJAFGJC<T1, T2, T3, T4, T5, out TResult>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG, in T3 KNBANGHBPDO, in T4 IAKJENCNKHP, in T5 ADNNJNBFJLE);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate TResult GOOIMILNNOP<T, TResult>(in T NPOOFIGPHFP);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate TResult LNPAGJICLNE<T1, T2, TResult>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG);
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate TResult FOPGOJGBCLF<T1, T2, T3, TResult>(in T1 OPPIKHJGJLI, in T2 NBKBMBIBKGG, in T3 KNBANGHBPDO);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public struct JMOJADJBJIC<T> : global::GJNILINCLMB<T, global::JMOJADJBJIC<T>.AOGNGGOKEEN>, global::FJAPCJKFAFD<T>, global::LAHMDLIOOMH<T, global::JMOJADJBJIC<T>.AOGNGGOKEEN>, global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, global::JMOJADJBJIC<T>.AOGNGGOKEEN>, IEnumerable<T>, IEnumerable, global::NDCMCJKMJOI<T>, OICFNCNNGKE
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct AOGNGGOKEEN : OICFNCNNGKE, global::APIBCHMGLDE<T>, global::CGCGKCKEBCO<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T[] FHMJCGCJJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int ODHBMAPOBFB;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int MMNJCBPCOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x23CDA20", Offset = "0x23CCA20", VA = "0x1823CDA20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public T CNDEAJHHNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x31D7C80", Offset = "0x31D6C80", VA = "0x1831D7C80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private T MIPCONBEDFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3B48160", Offset = "0x3B47160", VA = "0x183B48160", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x31D7C30", Offset = "0x31D6C30", VA = "0x1831D7C30", Slot = "7")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x31D7C30", Offset = "0x31D6C30", VA = "0x1831D7C30", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9CE790", Offset = "0x9CD790", VA = "0x1809CE790")]
		private AOGNGGOKEEN(T[] CKPEPLIGOCA, int GPNCGBOOKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2312CD0", Offset = "0x2311CD0", VA = "0x182312CD0")]
		public static AOGNGGOKEEN JAJKAINKHFL(T[] CKPEPLIGOCA)
		{
			return default(AOGNGGOKEEN);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x31D7C00", Offset = "0x31D6C00", VA = "0x1831D7C00", Slot = "9")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2312F20", Offset = "0x2311F20", VA = "0x182312F20", Slot = "11")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "8")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private T[] IBCIDPMLEAC;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int EMPOCCIPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x23CDA20", Offset = "0x23CCA20", VA = "0x1823CDA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x31D0440", Offset = "0x31CF440", VA = "0x1831D0440", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D0F6E0", Offset = "0x2D0E6E0", VA = "0x182D0F6E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD170", VA = "0x1806CE170")]
	internal JMOJADJBJIC(T[] FOHKJBHGAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x31D0480", Offset = "0x31CF480", VA = "0x1831D0480")]
	public static global::JMOJADJBJIC<T> NJGNJIEBDOK()
	{
		return default(global::JMOJADJBJIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x31D0240", Offset = "0x31CF240", VA = "0x1831D0240", Slot = "11")]
	public T BFKDJLNGOIL(int GPNCGBOOKKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3B520C0", Offset = "0x3B510C0", VA = "0x183B520C0")]
	public global::EGPNFCGNBBH<T> LPGLGOEDCDK()
	{
		return default(global::EGPNFCGNBBH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B51F20", Offset = "0x3B50F20", VA = "0x183B51F20", Slot = "8")]
	public AOGNGGOKEEN GetEnumerator()
	{
		return default(AOGNGGOKEEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B51FC0", Offset = "0x3B50FC0", VA = "0x183B51FC0", Slot = "5")]
	private global::APIBCHMGLDE<T> HFIKKCMMPOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B51FC0", Offset = "0x3B50FC0", VA = "0x183B51FC0", Slot = "7")]
	private global::CGCGKCKEBCO<T> LOJLECAFMNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B51FC0", Offset = "0x3B50FC0", VA = "0x183B51FC0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B51FC0", Offset = "0x3B50FC0", VA = "0x183B51FC0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class EADMBAHAENE
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4100", Offset = "0x1FD3100", VA = "0x181FD4100")]
	public static global::JMOJADJBJIC<T> JAJKAINKHFL<T>(T[] FOHKJBHGAHL)
	{
		return default(global::JMOJADJBJIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x17D0840", Offset = "0x17CF840", VA = "0x1817D0840")]
	public static global::JMOJADJBJIC<T> GDDNEJJLDHL<T>(this T[] CKPEPLIGOCA)
	{
		return default(global::JMOJADJBJIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FD40D0", Offset = "0x1FD30D0", VA = "0x181FD40D0")]
	public static global::JMOJADJBJIC<T>.AOGNGGOKEEN HLMMEDFPPBL<T>(this T[] CKPEPLIGOCA)
	{
		return default(global::JMOJADJBJIC<T>.AOGNGGOKEEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x17D0840", Offset = "0x17CF840", VA = "0x1817D0840")]
	public static global::JMOJADJBJIC<T> GGIPEMLGOBA<T>(this T[] CKPEPLIGOCA)
	{
		return default(global::JMOJADJBJIC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct DFDMDJAEMHJ<T, U> : global::GJNILINCLMB<T, U>, global::FJAPCJKFAFD<T>, global::LAHMDLIOOMH<T, U>, global::PAMFOELBBOE<T>, global::KFCPKIBNDDO<T, U>, IEnumerable<T>, IEnumerable where U : global::APIBCHMGLDE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly U IDFLAKCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C02D00", Offset = "0x2C01D00", VA = "0x182C02D00")]
	internal DFDMDJAEMHJ(in U BLDBIJHEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7630E0", Offset = "0x7620E0", VA = "0x1807630E0", Slot = "8")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "5")]
	private global::APIBCHMGLDE<T> HFIKKCMMPOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "7")]
	private global::CGCGKCKEBCO<T> LOJLECAFMNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "9")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C02CD0", Offset = "0x2C01CD0", VA = "0x182C02CD0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IAPPCHONHLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4680", Offset = "0x1FD3680", VA = "0x181FD4680")]
	public static global::DFDMDJAEMHJ<T, U> JAJKAINKHFL<U>(in U BLDBIJHEJFJ) where U : global::APIBCHMGLDE<T>
	{
		return default(global::DFDMDJAEMHJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class NGGMOFLEBHO<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<Internal, External> AFKIJCJGDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<External, Internal> MJIEBJMOPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IList<Internal> BDIENPOHAGP;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IList<Internal> LLGBHGHBMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D70", Offset = "0x5B6D70", VA = "0x1805B7D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool PJKCBAHKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x60E990", Offset = "0x60D990", VA = "0x18060E990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE80", Offset = "0x9DAE80", VA = "0x1809DBE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public External PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D680", Offset = "0x2D0C680", VA = "0x182D0D680", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D720", Offset = "0x2D0C720", VA = "0x182D0D720", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D0D620", Offset = "0x2D0C620", VA = "0x182D0D620", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D590", Offset = "0x2D0C590", VA = "0x182D0D590")]
	public NGGMOFLEBHO(Func<Internal, External> AFKIJCJGDGB, Func<External, Internal> MJIEBJMOPJM, bool KMNLKECENLE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D2A0", Offset = "0x2D0C2A0", VA = "0x182D0D2A0", Slot = "6")]
	public int IndexOf(External DOBBOGAJKHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CEC0", Offset = "0x2D0BEC0", VA = "0x182D0CEC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CF20", Offset = "0x2D0BF20", VA = "0x182D0CF20", Slot = "13")]
	public bool Contains(External DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CFB0", Offset = "0x2D0BFB0", VA = "0x182D0CFB0", Slot = "14")]
	public void CopyTo(External[] FOHKJBHGAHL, int HNFMGALMLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CDD0", Offset = "0x2D0BDD0", VA = "0x182D0CDD0", Slot = "11")]
	public void Add(External DOBBOGAJKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D390", Offset = "0x2D0C390", VA = "0x182D0D390", Slot = "7")]
	public void Insert(int GPNCGBOOKKF, External DOBBOGAJKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D500", Offset = "0x2D0C500", VA = "0x182D0D500", Slot = "15")]
	public bool Remove(External DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D430", Offset = "0x2D0C430", VA = "0x182D0D430", Slot = "8")]
	public void RemoveAt(int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D0D1D0", Offset = "0x2D0C1D0", VA = "0x182D0D1D0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x201C3B0", Offset = "0x201B3B0", VA = "0x18201C3B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DefaultMember("Item")]
public class GOBNFEOAILF<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Func<Internal, External> AFKIJCJGDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> BDIENPOHAGP;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IReadOnlyList<Internal> LLGBHGHBMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool PJKCBAHKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x58DFE0", Offset = "0x58CFE0", VA = "0x18058DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public External PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x251B7C0", Offset = "0x251A7C0", VA = "0x18251B7C0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x251B760", Offset = "0x251A760", VA = "0x18251B760", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2512C30", Offset = "0x2511C30", VA = "0x182512C30")]
	public GOBNFEOAILF(Func<Internal, External> AFKIJCJGDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x251B710", Offset = "0x251A710", VA = "0x18251B710")]
	public GOBNFEOAILF(IReadOnlyList<Internal> BDIENPOHAGP, Func<Internal, External> AFKIJCJGDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x251B4F0", Offset = "0x251A4F0", VA = "0x18251B4F0")]
	public void LLLCHFDPIGP(External[] FOHKJBHGAHL, int HNFMGALMLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x251B480", Offset = "0x251A480", VA = "0x18251B480", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D16C30", Offset = "0x1D15C30", VA = "0x181D16C30", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DefaultMember("Item")]
public class LFAHLHDHKCL<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private IReadOnlyList<Internal> BDIENPOHAGP;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public IReadOnlyList<Internal> LLGBHGHBMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool PJKCBAHKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x58DFE0", Offset = "0x58CFE0", VA = "0x18058DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public External PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3693220", Offset = "0x3692220", VA = "0x183693220", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x36931C0", Offset = "0x36921C0", VA = "0x1836931C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2512C30", Offset = "0x2511C30", VA = "0x182512C30")]
	public LFAHLHDHKCL(IReadOnlyList<Internal> BDIENPOHAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3692E80", Offset = "0x3691E80", VA = "0x183692E80")]
	public bool FDJOBPPDLBD(External DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3692F90", Offset = "0x3691F90", VA = "0x183692F90")]
	public void LLLCHFDPIGP(External[] FOHKJBHGAHL, int HNFMGALMLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3692F20", Offset = "0x3691F20", VA = "0x183692F20", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x201C3B0", Offset = "0x201B3B0", VA = "0x18201C3B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class HDFDPBDBLJL
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JAFADGPIDFF(object[] LMJLMIIJEAB);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	protected HDFDPBDBLJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class HHJBMJMCHDM<T> : HDFDPBDBLJL
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	protected struct MIPEEDCCGGF
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public enum OCIIJIIEFAF
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public OCIIJIIEFAF JFEPPDBLNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public T HCHPGKLEJDC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int DAOECDDDCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool KBLDDLDPOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly bool CAJHOAIOFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	protected List<T> GJAFCFKDGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private List<MIPEEDCCGGF> MCLGLMKLFIE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool FLGIKJBAMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2879D50", Offset = "0x2878D50", VA = "0x182879D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x287A180", Offset = "0x2879180", VA = "0x18287A180")]
	protected HHJBMJMCHDM(bool CAJHOAIOFKI, bool KBLDDLDPOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2879CB0", Offset = "0x2878CB0", VA = "0x182879CB0")]
	protected bool HIPCEBKPJAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x287A0A0", Offset = "0x28790A0", VA = "0x18287A0A0")]
	protected void LBEDCMOCFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2879EF0", Offset = "0x2878EF0", VA = "0x182879EF0")]
	protected void KCLMAIFDNIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x288D9B0", Offset = "0x288C9B0", VA = "0x18288D9B0")]
	private static void HIMCKKMLLPM<U>(ref List<U> BDIENPOHAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2879B30", Offset = "0x2878B30", VA = "0x182879B30", Slot = "5")]
	public void CGEJAMCGIKA(T HCHPGKLEJDC, bool HNBMHCIFLCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2879D90", Offset = "0x2878D90", VA = "0x182879D90", Slot = "6")]
	public void IDBFDJDECBI(T HCHPGKLEJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2879A00", Offset = "0x2878A00", VA = "0x182879A00")]
	public void ABPOABCICEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface NMABCJKEPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class KADOKFFMEKA : global::HHJBMJMCHDM<Action>, NMABCJKEPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5116E60", Offset = "0x5115E60", VA = "0x185116E60")]
	public KADOKFFMEKA(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5116BC0", Offset = "0x5115BC0", VA = "0x185116BC0")]
	public void HDDFKICIMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5116DE0", Offset = "0x5115DE0", VA = "0x185116DE0", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5116D80", Offset = "0x5115D80", VA = "0x185116D80")]
	public static KADOKFFMEKA IBMLGIDJCMG(KADOKFFMEKA GNLBDFJMGNO, Action HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5116B60", Offset = "0x5115B60", VA = "0x185116B60")]
	public static KADOKFFMEKA BDHINGPKEHO(KADOKFFMEKA GNLBDFJMGNO, Action HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface PGJFONBDPGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action<T> HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action<T> HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public sealed class CFEBOBEGIDP<T> : global::HHJBMJMCHDM<Action<T>>, global::PGJFONBDPGK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x230F210", Offset = "0x230E210", VA = "0x18230F210")]
	public CFEBOBEGIDP(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x33E0470", Offset = "0x33DF470", VA = "0x1833E0470")]
	public void HDDFKICIMIC(T FHAKMOPLLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x391D000", Offset = "0x391C000", VA = "0x18391D000", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x33E1490", Offset = "0x33E0490", VA = "0x1833E1490")]
	public static global::CFEBOBEGIDP<T> IBMLGIDJCMG(global::CFEBOBEGIDP<T> GNLBDFJMGNO, Action<T> HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x33DF610", Offset = "0x33DE610", VA = "0x1833DF610")]
	public static global::CFEBOBEGIDP<T> BDHINGPKEHO(global::CFEBOBEGIDP<T> GNLBDFJMGNO, Action<T> HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface CHDEAIGHJFP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action<T, U> HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action<T, U> HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class KDGBKMKFAME<T, U> : global::HHJBMJMCHDM<Action<T, U>>, global::CHDEAIGHJFP<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x230F210", Offset = "0x230E210", VA = "0x18230F210")]
	public KDGBKMKFAME(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x39AE520", Offset = "0x39AD520", VA = "0x1839AE520")]
	public void HDDFKICIMIC(T FHAKMOPLLAA, U IGDIPGPIIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x39B2410", Offset = "0x39B1410", VA = "0x1839B2410", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x39B0E20", Offset = "0x39AFE20", VA = "0x1839B0E20")]
	public static global::KDGBKMKFAME<T, U> IBMLGIDJCMG(global::KDGBKMKFAME<T, U> GNLBDFJMGNO, Action<T, U> HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x39ACD10", Offset = "0x39ABD10", VA = "0x1839ACD10")]
	public static global::KDGBKMKFAME<T, U> BDHINGPKEHO(global::KDGBKMKFAME<T, U> GNLBDFJMGNO, Action<T, U> HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OJOPJHOMIIC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action<T, U, V> HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action<T, U, V> HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class EMNICDOEOCB<T, U, V> : global::HHJBMJMCHDM<Action<T, U, V>>, global::OJOPJHOMIIC<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x230F210", Offset = "0x230E210", VA = "0x18230F210")]
	public EMNICDOEOCB(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F720", Offset = "0x3D2E720", VA = "0x183D2F720")]
	public void HDDFKICIMIC(T FHAKMOPLLAA, U IGDIPGPIIPJ, V KJGFEKLHDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3D31080", Offset = "0x3D30080", VA = "0x183D31080", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F9A0", Offset = "0x3D2E9A0", VA = "0x183D2F9A0")]
	public static global::EMNICDOEOCB<T, U, V> IBMLGIDJCMG(global::EMNICDOEOCB<T, U, V> GNLBDFJMGNO, Action<T, U, V> HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3D2D740", Offset = "0x3D2C740", VA = "0x183D2D740")]
	public static global::EMNICDOEOCB<T, U, V> BDHINGPKEHO(global::EMNICDOEOCB<T, U, V> GNLBDFJMGNO, Action<T, U, V> HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public interface PDNJNCFGACM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action<T, U, V, W> HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action<T, U, V, W> HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class LJCIPMFBEKF<T, U, V, W> : global::HHJBMJMCHDM<Action<T, U, V, W>>, global::PDNJNCFGACM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x230F210", Offset = "0x230E210", VA = "0x18230F210")]
	public LJCIPMFBEKF(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB790", Offset = "0x2BFA790", VA = "0x182BFB790")]
	public void HDDFKICIMIC(T FHAKMOPLLAA, U IGDIPGPIIPJ, V KJGFEKLHDPF, W OBDHDNFKOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCD90", Offset = "0x2BFBD90", VA = "0x182BFCD90", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2BFCA90", Offset = "0x2BFBA90", VA = "0x182BFCA90")]
	public static global::LJCIPMFBEKF<T, U, V, W> IBMLGIDJCMG(global::LJCIPMFBEKF<T, U, V, W> GNLBDFJMGNO, Action<T, U, V, W> HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB1C0", Offset = "0x2BFA1C0", VA = "0x182BFB1C0")]
	public static global::LJCIPMFBEKF<T, U, V, W> BDHINGPKEHO(global::LJCIPMFBEKF<T, U, V, W> GNLBDFJMGNO, Action<T, U, V, W> HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface PKMCJLBHJOB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action<T, U, V, W, X> HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action<T, U, V, W, X> HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class DJIGIKPAJKC<T, U, V, W, X> : global::HHJBMJMCHDM<Action<T, U, V, W, X>>, global::PKMCJLBHJOB<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x230F210", Offset = "0x230E210", VA = "0x18230F210")]
	public DJIGIKPAJKC(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3CA90B0", Offset = "0x3CA80B0", VA = "0x183CA90B0")]
	public void HDDFKICIMIC(T FHAKMOPLLAA, U IGDIPGPIIPJ, V KJGFEKLHDPF, W OBDHDNFKOBC, X BIBNBCIJJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA9A20", Offset = "0x3CA8A20", VA = "0x183CA9A20", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA9660", Offset = "0x3CA8660", VA = "0x183CA9660")]
	public static global::DJIGIKPAJKC<T, U, V, W, X> IBMLGIDJCMG(global::DJIGIKPAJKC<T, U, V, W, X> GNLBDFJMGNO, Action<T, U, V, W, X> HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA9010", Offset = "0x3CA8010", VA = "0x183CA9010")]
	public static global::DJIGIKPAJKC<T, U, V, W, X> BDHINGPKEHO(global::DJIGIKPAJKC<T, U, V, W, X> GNLBDFJMGNO, Action<T, U, V, W, X> HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface OPEGFBJJOKP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGEJAMCGIKA(Action<T, U, V, W, X, Y> HCHPGKLEJDC, bool HNBMHCIFLCB = false);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IDBFDJDECBI(Action<T, U, V, W, X, Y> HCHPGKLEJDC);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public sealed class LCLPLPAGGJA<T, U, V, W, X, Y> : global::HHJBMJMCHDM<Action<T, U, V, W, X, Y>>, global::OPEGFBJJOKP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x230F210", Offset = "0x230E210", VA = "0x18230F210")]
	public LCLPLPAGGJA(bool CAJHOAIOFKI = false, bool KBLDDLDPOOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x368EF70", Offset = "0x368DF70", VA = "0x18368EF70")]
	public void HDDFKICIMIC(T FHAKMOPLLAA, U IGDIPGPIIPJ, V KJGFEKLHDPF, W OBDHDNFKOBC, X BIBNBCIJJEK, Y AIHGENMJNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x368F8E0", Offset = "0x368E8E0", VA = "0x18368F8E0", Slot = "4")]
	public override void JAFADGPIDFF(object[] LMJLMIIJEAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x368F4F0", Offset = "0x368E4F0", VA = "0x18368F4F0")]
	public static global::LCLPLPAGGJA<T, U, V, W, X, Y> IBMLGIDJCMG(global::LCLPLPAGGJA<T, U, V, W, X, Y> GNLBDFJMGNO, Action<T, U, V, W, X, Y> HCHPGKLEJDC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x368EBC0", Offset = "0x368DBC0", VA = "0x18368EBC0")]
	public static global::LCLPLPAGGJA<T, U, V, W, X, Y> BDHINGPKEHO(global::LCLPLPAGGJA<T, U, V, W, X, Y> GNLBDFJMGNO, Action<T, U, V, W, X, Y> HCHPGKLEJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class DJNBAKFAKKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct EFLJBHKDONO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly global::DJNBAKFAKKE<T> APAECFPGDFH;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public T PDFBALCEGGK
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x3CAF320", Offset = "0x3CAE320", VA = "0x183CAF320")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF340", Offset = "0x3CAE340", VA = "0x183CAF340", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6CE170", Offset = "0x6CD170", VA = "0x1806CE170")]
		public EFLJBHKDONO(global::DJNBAKFAKKE<T> APAECFPGDFH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct AAPJHJLAIBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<EFLJBHKDONO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::DJNBAKFAKKE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5C20", Offset = "0x3CA4C20", VA = "0x183CA5C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2303290", Offset = "0x2302290", VA = "0x182303290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct PAFCMKLAPOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder<EFLJBHKDONO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::DJNBAKFAKKE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5580", Offset = "0x3CB4580", VA = "0x183CB5580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2303290", Offset = "0x2302290", VA = "0x182303290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly SemaphoreSlim IIGLKHNNKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private T BDELGAHBACM;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int BFAJBPNJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3CAA7E0", Offset = "0x3CA97E0", VA = "0x183CAA7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA920", Offset = "0x3CA9920", VA = "0x183CAA920")]
	public DJNBAKFAKKE(in T BDELGAHBACM, int CFMIHMAEFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2687D90", Offset = "0x2686D90", VA = "0x182687D90")]
	public DJNBAKFAKKE(in T BDELGAHBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA840", Offset = "0x3CA9840", VA = "0x183CAA840")]
	public EFLJBHKDONO LDACHDBKPCF()
	{
		return default(EFLJBHKDONO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA800", Offset = "0x3CA9800", VA = "0x183CAA800")]
	public EFLJBHKDONO LDACHDBKPCF(CancellationToken MCLPFBCBLEM)
	{
		return default(EFLJBHKDONO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA220", Offset = "0x3CA9220", VA = "0x183CAA220")]
	[AsyncStateMachine(typeof(global::DJNBAKFAKKE<>.AAPJHJLAIBJ))]
	public Task<EFLJBHKDONO> BMDLNOHOIJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3CAA660", Offset = "0x3CA9660", VA = "0x183CAA660")]
	[AsyncStateMachine(typeof(global::DJNBAKFAKKE<>.PAFCMKLAPOK))]
	public Task<EFLJBHKDONO> BMDLNOHOIJE(CancellationToken MCLPFBCBLEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class HIKIEHLNMDH
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x51161C0", Offset = "0x51151C0", VA = "0x1851161C0")]
	public static global::DJNBAKFAKKE<GGOCMJFKKGA> JAJKAINKHFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5116150", Offset = "0x5115150", VA = "0x185116150")]
	public static global::DJNBAKFAKKE<GGOCMJFKKGA> JAJKAINKHFL(int CFMIHMAEFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2200", Offset = "0x1FE1200", VA = "0x181FE2200")]
	public static global::DJNBAKFAKKE<T> JAJKAINKHFL<T>(in T BDELGAHBACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBF90", Offset = "0x1FDAF90", VA = "0x181FDBF90")]
	public static global::DJNBAKFAKKE<T> JAJKAINKHFL<T>(in T BDELGAHBACM, int CFMIHMAEFOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JILMBFKBKAB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public delegate bool EGMJKMFGION(global::JILMBFKBKAB<T> ENBCMIAMCNO);

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class LKFDIHKJOBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public global::JILMBFKBKAB<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public LKFDIHKJOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x31BBD80", Offset = "0x31BAD80", VA = "0x1831BBD80")]
		internal bool <FindNode>b__0(global::JILMBFKBKAB<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public T EGDCLLDLHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public LinkedList<global::JILMBFKBKAB<T>> LCIOEAPOKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public global::JILMBFKBKAB<T> INPCPGBPGNK;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public global::JILMBFKBKAB<T> IEJNLKPMFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5E0130", Offset = "0x5DF130", VA = "0x1805E0130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x31B90C0", Offset = "0x31B80C0", VA = "0x1831B90C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MIBPFPIGLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x31B91A0", Offset = "0x31B81A0", VA = "0x1831B91A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool IBFDLNFPDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x31B9400", Offset = "0x31B8400", VA = "0x1831B9400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public global::JILMBFKBKAB<T> EFDCOHOBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x31BA160", Offset = "0x31B9160", VA = "0x1831BA160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x31BA1E0", Offset = "0x31B91E0", VA = "0x1831BA1E0")]
	public JILMBFKBKAB(T DKIMJFNBKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x31B92E0", Offset = "0x31B82E0", VA = "0x1831B92E0")]
	public global::JILMBFKBKAB<T> FENNPKKNDOA(T ABGFGABPHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x31B9F90", Offset = "0x31B8F90", VA = "0x1831B9F90")]
	public global::JILMBFKBKAB<T> KOPJGCPINED(T AGGOHNAEPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x31B9780", Offset = "0x31B8780", VA = "0x1831B9780")]
	public global::JILMBFKBKAB<T> IDBFDJDECBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x31B8E60", Offset = "0x31B7E60", VA = "0x1831B8E60")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x31B91D0", Offset = "0x31B81D0", VA = "0x1831B91D0")]
	public global::JILMBFKBKAB<T> DKGJJFMLDEN(T OAKDFCNFIGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x31B9440", Offset = "0x31B8440", VA = "0x1831B9440")]
	public static void FOIAIIJIMEI(global::JILMBFKBKAB<T> DHADIADJMBK, EGMJKMFGION ELLLHHPLHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x2895E10", Offset = "0x2894E10", VA = "0x182895E10")]
	public static void FOIAIIJIMEI<A>(global::JILMBFKBKAB<T> DHADIADJMBK, Func<global::JILMBFKBKAB<T>, A, bool> ELLLHHPLHII, A NPOOFIGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x31B9830", Offset = "0x31B8830", VA = "0x1831B9830")]
	public static string IDBPDJEFLDC(global::JILMBFKBKAB<T> DHADIADJMBK, int HJCLNPMNHLH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x31B9D70", Offset = "0x31B8D70", VA = "0x1831B9D70")]
	public static global::JILMBFKBKAB<T> IHONHIKMNDF(global::JILMBFKBKAB<T> DHADIADJMBK, T HKLOGHMOCKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class JMEKAPCCHLG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public delegate Task<TResult> KEOHBLCFIMO(TRequest NAIKMNKJIDN, CancellationToken MCLPFBCBLEM);

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum BMBPBFNEKHP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class KBAOJECBJKF
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private const float PHGGNJNAIFC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TimeSpan JDOBOENGLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int FLEEOBOCGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public BMBPBFNEKHP FKODGJIALPG;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static readonly KBAOJECBJKF DDKLLKCKOJH;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float LIDDLILHIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x3B5E680", Offset = "0x3B5D680", VA = "0x183B5E680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public TimeSpan FPDGLMEPLEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3B5E840", Offset = "0x3B5D840", VA = "0x183B5E840")]
		public KBAOJECBJKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private readonly struct FJHIJCLOADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly TRequest NAIKMNKJIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly CancellationToken MCLPFBCBLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly TaskCompletionSource<TResult> PCFIHJJEBPI;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3B4BE80", Offset = "0x3B4AE80", VA = "0x183B4BE80")]
		public FJHIJCLOADM(TRequest NAIKMNKJIDN, TaskCompletionSource<TResult> PCFIHJJEBPI, CancellationToken MCLPFBCBLEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class DBEKADNKANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public DBEKADNKANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2185A40", Offset = "0x2184A40", VA = "0x182185A40")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct NPNLMIOFNJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public global::JMEKAPCCHLG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FC50", Offset = "0x3B5EC50", VA = "0x183B5FC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7EEFE0", Offset = "0x7EDFE0", VA = "0x1807EEFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class AAAIEFPGGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public FJHIJCLOADM req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::JMEKAPCCHLG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public AAAIEFPGGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3B47BD0", Offset = "0x3B46BD0", VA = "0x183B47BD0")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly CancellationTokenSource PANGMEKKLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<FJHIJCLOADM> PHLGEOBJBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly KBAOJECBJKF PPDKMJLBMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly KEOHBLCFIMO KJHCPGHHCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Task FPICABNDOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int FOLFGLMOIDN;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3B51A10", Offset = "0x3B50A10", VA = "0x183B51A10")]
	public JMEKAPCCHLG(KEOHBLCFIMO KJHCPGHHCNL, [Optional] KBAOJECBJKF PPDKMJLBMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3B50770", Offset = "0x3B4F770", VA = "0x183B50770")]
	public Task<TResult> EJGAEKMGMKM(TRequest NAIKMNKJIDN, CancellationToken MCLPFBCBLEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3B50150", Offset = "0x3B4F150", VA = "0x183B50150")]
	private void CHHNCKOGEPJ(FJHIJCLOADM LJMCODLHHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3B50BF0", Offset = "0x3B4FBF0", VA = "0x183B50BF0")]
	[AsyncStateMachine(typeof(global::JMEKAPCCHLG<, >.NPNLMIOFNJB))]
	private Task IMLIFNGONAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3B511E0", Offset = "0x3B501E0", VA = "0x183B511E0")]
	private FJHIJCLOADM JMKPGIGGFIL()
	{
		return default(FJHIJCLOADM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3B51440", Offset = "0x3B50440", VA = "0x183B51440")]
	private void NIILECCMMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3B50270", Offset = "0x3B4F270", VA = "0x183B50270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GDGNLDDMEII<TKey, TVal> : global::JCCGGGLGHFE<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private int IOHHBNOANGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal Dictionary<TKey, (TVal value, int size)> OJJCEEANEAG;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	internal override int FCIILIIOPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3B7B7A0", Offset = "0x3B7A7A0", VA = "0x183B7B7A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal int GCGKLCFFNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3B7BB10", Offset = "0x3B7AB10", VA = "0x183B7BB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public override int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3B7BA00", Offset = "0x3B7AA00", VA = "0x183B7BA00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BC50", Offset = "0x3B7AC50", VA = "0x183B7BC50")]
	public GDGNLDDMEII(int PGIGOJJPHFM, [Optional] EFHAENDGJHI CDOKBPDELKH, [Optional] IEqualityComparer<TKey> ENOOOKBJFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B700", Offset = "0x3B7A700", VA = "0x183B7B700")]
	public void HKLAKABEHFD(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG, bool ILBOLKMPJLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B680", Offset = "0x3B7A680", VA = "0x183B7B680")]
	public bool FMDHEICADGP(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BA60", Offset = "0x3B7AA60", VA = "0x183B7BA60", Slot = "6")]
	public override bool NHHHDIDPJMI(TKey GHCNHPEPIGG, out TVal GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B7D0", Offset = "0x3B7A7D0", VA = "0x183B7B7D0")]
	public bool LCGPCKJBJJP(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BB40", Offset = "0x3B7AB40", VA = "0x183B7BB40")]
	public bool PMEOCFAPPDC(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B570", Offset = "0x3B7A570", VA = "0x183B7B570", Slot = "7")]
	public override void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B5E0", Offset = "0x3B7A5E0", VA = "0x183B7B5E0")]
	private bool BNPNODJFHHN(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DefaultMember("Item")]
public class JCCGGGLGHFE<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public delegate int EFHAENDGJHI(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG);

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class ODFOJFGPMKC
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public TKey GDIPAGHFDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public TVal PDFBALCEGGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x6BBC80", Offset = "0x6BAC80", VA = "0x1806BBC80")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x7619D0", Offset = "0x7609D0", VA = "0x1807619D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int ECIOENCFCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x6DF5D0", Offset = "0x6DE5D0", VA = "0x1806DF5D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF600", Offset = "0x6DE600", VA = "0x1806DF600")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public DateTime KJGAGOCPDPH
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xFA6490", Offset = "0xFA5490", VA = "0x180FA6490")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x26988D0", Offset = "0x26978D0", VA = "0x1826988D0")]
		public ODFOJFGPMKC(TKey GLMMMFPEBHE, TVal LBEFLEJKHJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const int JLLOBFEMEPB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<TKey, LinkedListNode<ODFOJFGPMKC>> NKLPAKCKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly LinkedList<ODFOJFGPMKC> BFEGNIOIDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly EFHAENDGJHI CDOKBPDELKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly TimeSpan NNIPBHBLFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly CENPMCFONFM NFHFPPBCFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int BCLHMBKMMLJ;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int FDDMGOMOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6E89D0", Offset = "0x6E79D0", VA = "0x1806E89D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private bool BONGOAIKEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x26915A0", Offset = "0x26905A0", VA = "0x1826915A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	internal virtual int FCIILIIOPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6E89E0", Offset = "0x6E79E0", VA = "0x1806E89E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private int GLCMJLMDOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x22DC560", Offset = "0x22DB560", VA = "0x1822DC560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public virtual int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1D16830", Offset = "0x1D15830", VA = "0x181D16830", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IEnumerable<TKey> KCPKGPGJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2691380", Offset = "0x2690380", VA = "0x182691380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public TVal PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2691630", Offset = "0x2690630", VA = "0x182691630")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2691350", Offset = "0x2690350", VA = "0x182691350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2692B20", Offset = "0x2691B20", VA = "0x182692B20")]
	public JCCGGGLGHFE(int PGIGOJJPHFM, [Optional] EFHAENDGJHI CDOKBPDELKH, [Optional] IEqualityComparer<TKey> ENOOOKBJFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2692AD0", Offset = "0x2691AD0", VA = "0x182692AD0")]
	public JCCGGGLGHFE(TimeSpan NNIPBHBLFOO, [Optional] IEqualityComparer<TKey> ENOOOKBJFDO, [Optional] CENPMCFONFM NFHFPPBCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2692A80", Offset = "0x2691A80", VA = "0x182692A80")]
	public JCCGGGLGHFE(int PGIGOJJPHFM, TimeSpan NNIPBHBLFOO, [Optional] IEqualityComparer<TKey> ENOOOKBJFDO, [Optional] CENPMCFONFM NFHFPPBCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2692830", Offset = "0x2691830", VA = "0x182692830")]
	public JCCGGGLGHFE(int PGIGOJJPHFM, EFHAENDGJHI CDOKBPDELKH, TimeSpan NNIPBHBLFOO, [Optional] IEqualityComparer<TKey> ENOOOKBJFDO, [Optional] CENPMCFONFM NFHFPPBCFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2691F10", Offset = "0x2690F10", VA = "0x182691F10")]
	public void MHNIAGBGGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2691880", Offset = "0x2690880", VA = "0x182691880")]
	public void IDLFALJALGN(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2691660", Offset = "0x2690660", VA = "0x182691660")]
	public bool IDBFDJDECBI(TKey GLMMMFPEBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2692330", Offset = "0x2691330", VA = "0x182692330")]
	private TVal PKIGOCNNHDN(TKey GHCNHPEPIGG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2692080", Offset = "0x2691080", VA = "0x182692080", Slot = "6")]
	public virtual bool NHHHDIDPJMI(TKey GHCNHPEPIGG, out TVal GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2690FA0", Offset = "0x268FFA0", VA = "0x182690FA0", Slot = "7")]
	public virtual void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2691940", Offset = "0x2690940", VA = "0x182691940")]
	private bool KHCIOOOGOAF(ODFOJFGPMKC DGFCCMOCDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2691CE0", Offset = "0x2690CE0", VA = "0x182691CE0")]
	private void LDAFIPBBHBN(LinkedListNode<ODFOJFGPMKC> BJBPPHHFFIH, TVal NJODPDEEDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2692660", Offset = "0x2691660", VA = "0x182692660")]
	private void PNPEIPPMCOG(TKey GLMMMFPEBHE, TVal GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x26911B0", Offset = "0x26901B0", VA = "0x1826911B0")]
	private void DNIGOAOJMPJ(ODFOJFGPMKC DGFCCMOCDLB, TVal NJODPDEEDCG, int HPDMAEHINLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DefaultMember("Item")]
public class PNAANNCPPLN<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<T> BDIENPOHAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private HashSet<T> JMHECELGEEL;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2185A40", Offset = "0x2184A40", VA = "0x182185A40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool PJKCBAHKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x33F1FD0", Offset = "0x33F0FD0", VA = "0x1833F1FD0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x41D34B0", Offset = "0x41D24B0", VA = "0x1841D34B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2878D70", Offset = "0x2877D70", VA = "0x182878D70", Slot = "11")]
	public void Add(T DOBBOGAJKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x41D2EC0", Offset = "0x41D1EC0", VA = "0x1841D2EC0")]
	public bool DDECLGPGGGI(T DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x41D3350", Offset = "0x41D2350", VA = "0x1841D3350", Slot = "15")]
	public bool Remove(T DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x37B6720", Offset = "0x37B5720", VA = "0x1837B6720", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2014350", Offset = "0x2013350", VA = "0x182014350", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x41D2DB0", Offset = "0x41D1DB0", VA = "0x1841D2DB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x219CE30", Offset = "0x219BE30", VA = "0x18219CE30", Slot = "13")]
	public bool Contains(T DOBBOGAJKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3CA9DD0", Offset = "0x3CA8DD0", VA = "0x183CA9DD0", Slot = "14")]
	public void CopyTo(T[] FOHKJBHGAHL, int HNFMGALMLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x22EE5E0", Offset = "0x22ED5E0", VA = "0x1822EE5E0", Slot = "6")]
	public int IndexOf(T DOBBOGAJKHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x41D3030", Offset = "0x41D2030", VA = "0x1841D3030", Slot = "7")]
	public void Insert(int GPNCGBOOKKF, T DOBBOGAJKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x41D3120", Offset = "0x41D2120", VA = "0x1841D3120", Slot = "8")]
	public void RemoveAt(int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x41D2CE0", Offset = "0x41D1CE0", VA = "0x1841D2CE0")]
	public void BBLKBIPABIF(Predicate<T> JKOIKJBBJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x41D30F0", Offset = "0x41D20F0", VA = "0x1841D30F0")]
	public void LJFDDMAEOOP(Comparison<T> ENCGFHDLBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x41D33D0", Offset = "0x41D23D0", VA = "0x1841D33D0")]
	public PNAANNCPPLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class FIPKKGEDLIF
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5115430", Offset = "0x5114430", VA = "0x185115430")]
	public static Vector3 JIBGDPOGGDC(this GameObject CPHKFFAMPLG, float MIFGBKGKIEK)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x205B770", Offset = "0x205A770", VA = "0x18205B770")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x511B0E0", Offset = "0x511A0E0", VA = "0x18511B0E0")]
		public SerializedGuid(in Guid EMEFDKEMECG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x511AC30", Offset = "0x5119C30", VA = "0x18511AC30")]
		public static SerializedGuid AJHMHEIJPCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x511AEF0", Offset = "0x5119EF0", VA = "0x18511AEF0")]
		public static SerializedGuid FNCHKLDNHNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x511AE60", Offset = "0x5119E60", VA = "0x18511AE60")]
		public bool FFLPFCKNADJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x511B0B0", Offset = "0x511A0B0", VA = "0x18511B0B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x511B010", Offset = "0x511A010", VA = "0x18511B010", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x511AF80", Offset = "0x5119F80", VA = "0x18511AF80")]
		public bool KOOAEOKKCJO(in Guid EMEFDKEMECG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x511ACE0", Offset = "0x5119CE0", VA = "0x18511ACE0", Slot = "7")]
		public bool Equals(SerializedGuid GOAJJPLEOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x511AD80", Offset = "0x5119D80", VA = "0x18511AD80", Slot = "0")]
		public override bool Equals(object NHBCHHMAJOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x511AF70", Offset = "0x5119F70", VA = "0x18511AF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x511ACB0", Offset = "0x5119CB0", VA = "0x18511ACB0", Slot = "6")]
		public int CompareTo(SerializedGuid GOAJJPLEOBJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class KGFFMIENNLK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public readonly Type MOLHOKEOECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public readonly string MDBFKKDJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly bool NCINDCBNMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly bool DJPKIDEAAGP;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5117930", Offset = "0x5116930", VA = "0x185117930")]
	public KGFFMIENNLK(Type GAFNGMJNPKC, string AECFDKBMBFA, bool KDMBHGDEIOH = false, bool BJAIJCHPNEO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public interface HPODCAFHLNJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface PNBILBLNMKE<T> : HPODCAFHLNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	T PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	bool LIMLFJLPNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string PAHBFCGBCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PNBILBLNMKE<T> CJECHJDODMH(Action<T> KKFNKMKGMCP);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PNBILBLNMKE<T> HIEAEKLJDFB(Action<T> KKFNKMKGMCP);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::PNBILBLNMKE<T> NJNNCMPHCFF(Action<T, T> NKGGFLGJLGH);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::PNBILBLNMKE<T> NACDPOHOPPG(Action<T, T> NKGGFLGJLGH);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::PNBILBLNMKE<T> PDNFEIPGPOJ(Action<string> BNFBKBCLANE);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::PNBILBLNMKE<T> DPJINLMOMJA(Action<string> BNFBKBCLANE);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class JHFKDBLENFE<T> : global::PNBILBLNMKE<T>, HPODCAFHLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private global::KDGBKMKFAME<T, T> NENOKGGFLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private global::CFEBOBEGIDP<T> OEPLIONKFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private global::CFEBOBEGIDP<string> LAOAAOOIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private string BCELONFJGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T CLNIDHLHIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool AJMLPLHIDIE;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2847D20", Offset = "0x2846D20", VA = "0x182847D20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool LIMLFJLPNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x60F8B0", Offset = "0x60E8B0", VA = "0x18060F8B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public string PAHBFCGBCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2A623D0", Offset = "0x2A613D0", VA = "0x182A623D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x31B6B30", Offset = "0x31B5B30", VA = "0x1831B6B30")]
	private void PJFMLIGJLCI(T HPEACFNBKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x31B6BD0", Offset = "0x31B5BD0", VA = "0x1831B6BD0")]
	private void PPAOPFBPHPP(string ADIELDAOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x31B6950", Offset = "0x31B5950", VA = "0x1831B6950")]
	public void MIGBKHAMFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x31B6A50", Offset = "0x31B5A50", VA = "0x1831B6A50", Slot = "6")]
	public global::PNBILBLNMKE<T> NJNNCMPHCFF(Action<T, T> NKGGFLGJLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x31B6A00", Offset = "0x31B5A00", VA = "0x1831B6A00", Slot = "7")]
	public global::PNBILBLNMKE<T> NACDPOHOPPG(Action<T, T> NKGGFLGJLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x31B6800", Offset = "0x31B5800", VA = "0x1831B6800", Slot = "4")]
	public global::PNBILBLNMKE<T> CJECHJDODMH(Action<T> NKGGFLGJLGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x31B6900", Offset = "0x31B5900", VA = "0x1831B6900", Slot = "5")]
	public global::PNBILBLNMKE<T> HIEAEKLJDFB(Action<T> KKFNKMKGMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x31B6AA0", Offset = "0x31B5AA0", VA = "0x1831B6AA0", Slot = "8")]
	public global::PNBILBLNMKE<T> PDNFEIPGPOJ(Action<string> BNFBKBCLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x31B6890", Offset = "0x31B5890", VA = "0x1831B6890", Slot = "9")]
	public global::PNBILBLNMKE<T> DPJINLMOMJA(Action<string> BNFBKBCLANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x31B6C70", Offset = "0x31B5C70", VA = "0x1831B6C70")]
	public JHFKDBLENFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class ICGGMADHCMK
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class PCGAEFPAOAJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public global::PNBILBLNMKE<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::ADIAEJHDLBD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public PCGAEFPAOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x219AEA0", Offset = "0x2199EA0", VA = "0x18219AEA0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1EDE8C0", Offset = "0x1EDD8C0", VA = "0x181EDE8C0")]
	public static global::BDGKEGGAANF<T> PEOIAIJJCKH<T>(this global::PNBILBLNMKE<T> EBENIIECDAN, Action<T> ONMGDGLPLME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class IKBIJKLPGMJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct OBOJJEBNICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly long PAJBPLFEEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly long BDBLDNPNDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int BJDLJGFMKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int HKEOCHLJKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly bool NNIAKEDPEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly string CBIHENJOGIB;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x30153C0", Offset = "0x30143C0", VA = "0x1830153C0")]
		public OBOJJEBNICC(long PAJBPLFEEAH, int BJDLJGFMKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x3015390", Offset = "0x3014390", VA = "0x183015390")]
		public OBOJJEBNICC(long PAJBPLFEEAH, long BDBLDNPNDHP, int BJDLJGFMKPI, int HKEOCHLJKPO, bool NNIAKEDPEOB, string CBIHENJOGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3015320", Offset = "0x3014320", VA = "0x183015320")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PKIEOHELNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x3015240", Offset = "0x3014240", VA = "0x183015240")]
		public int HKIDCHJGKJH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3015290", Offset = "0x3014290", VA = "0x183015290")]
		public int JKEECBCHNBA(int GBCNNNPDOKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x30152B0", Offset = "0x30142B0", VA = "0x1830152B0")]
		public double PKCMHEKDEJO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x3015180", Offset = "0x3014180", VA = "0x183015180")]
		public OBOJJEBNICC EDBKBJNKBOJ(long BDBLDNPNDHP, int HKEOCHLJKPO)
		{
			return default(OBOJJEBNICC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public class IDCNIFDHJNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly TKey GDIPAGHFDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly global::IKBIJKLPGMJ<TKey> COCHHMDLDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private List<IDCNIFDHJNO> NIGPMINMNID;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public string JHHMJDKKBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x1E0DCA0", Offset = "0x1E0CCA0", VA = "0x181E0DCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x300DCB0", Offset = "0x300CCB0", VA = "0x18300DCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public IEnumerable<IDCNIFDHJNO> LCIOEAPOKFN
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x300D890", Offset = "0x300C890", VA = "0x18300D890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public OBOJJEBNICC KDAFOGGNHHE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x1057990", Offset = "0x1056990", VA = "0x181057990")]
			[CompilerGenerated]
			get
			{
				return default(OBOJJEBNICC);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x300DB80", Offset = "0x300CB80", VA = "0x18300DB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x300DCE0", Offset = "0x300CCE0", VA = "0x18300DCE0")]
		internal IDCNIFDHJNO(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP, TKey GLMMMFPEBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x300D8B0", Offset = "0x300C8B0", VA = "0x18300D8B0")]
		public IDCNIFDHJNO BONDABOFJJA(TKey GLMMMFPEBHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x300DBB0", Offset = "0x300CBB0", VA = "0x18300DBB0")]
		public void ENOAPLNANGI(TKey GLMMMFPEBHE, Action<IDCNIFDHJNO> HCHPGKLEJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x20ACF80", Offset = "0x20ABF80", VA = "0x1820ACF80")]
		public T ENOAPLNANGI<T>(TKey GLMMMFPEBHE, Func<IDCNIFDHJNO, T> CHPMNENLADO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FF19A0", Offset = "0x1FF09A0", VA = "0x181FF19A0")]
		[AsyncStateMachine(typeof(HNGFFLHPIFL))]
		public Task<T> LLPKLCEGDMP<T>(TKey GLMMMFPEBHE, Func<IDCNIFDHJNO, Task<T>> CHPMNENLADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x300D9C0", Offset = "0x300C9C0", VA = "0x18300D9C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class BNAGIJOCHEE : IEnumerable<(TKey, List<TKey>, OBOJJEBNICC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OBOJJEBNICC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private (TKey key, List<TKey> path, OBOJJEBNICC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public global::IKBIJKLPGMJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private IEnumerator<(TKey key, List<TKey> path, OBOJJEBNICC timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private (TKey, List<TKey>, OBOJJEBNICC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x3005DE0", Offset = "0x3004DE0", VA = "0x183005DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OBOJJEBNICC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x30063F0", Offset = "0x30053F0", VA = "0x1830063F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x3006030", Offset = "0x3005030", VA = "0x183006030")]
		[DebuggerHidden]
		public BNAGIJOCHEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x3006450", Offset = "0x3005450", VA = "0x183006450", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x3006070", Offset = "0x3005070", VA = "0x183006070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x30064D0", Offset = "0x30054D0", VA = "0x1830064D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x30063A0", Offset = "0x30053A0", VA = "0x1830063A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x30062E0", Offset = "0x30052E0", VA = "0x1830062E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OBOJJEBNICC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x20210A0", Offset = "0x20200A0", VA = "0x1820210A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class AGBJHOCJCBM : IEnumerable<(TKey, List<TKey>, OBOJJEBNICC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OBOJJEBNICC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, OBOJJEBNICC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private IDCNIFDHJNO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IDCNIFDHJNO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public global::IKBIJKLPGMJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private IEnumerator<IDCNIFDHJNO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private IEnumerator<(TKey key, List<TKey> path, OBOJJEBNICC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		private (TKey, List<TKey>, OBOJJEBNICC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x3005DE0", Offset = "0x3004DE0", VA = "0x183005DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OBOJJEBNICC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x3005E60", Offset = "0x3004E60", VA = "0x183005E60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x3006030", Offset = "0x3005030", VA = "0x183006030")]
		[DebuggerHidden]
		public AGBJHOCJCBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x3005EC0", Offset = "0x3004EC0", VA = "0x183005EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x30057D0", Offset = "0x30047D0", VA = "0x1830057D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x3005F90", Offset = "0x3004F90", VA = "0x183005F90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x3005FE0", Offset = "0x3004FE0", VA = "0x183005FE0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x3005E10", Offset = "0x3004E10", VA = "0x183005E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x3005D10", Offset = "0x3004D10", VA = "0x183005D10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OBOJJEBNICC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x22EF2D0", Offset = "0x22EE2D0", VA = "0x1822EF2D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Action<TKey, OBOJJEBNICC> OBDJKGFDFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Action<TKey, OBOJJEBNICC> MHDJENJNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<global::IKBIJKLPGMJ<TKey>> BBONBICFLFH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private const string ODHFBLMIMAP = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly IDCNIFDHJNO NHENABGAPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool CKJDBNBCJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int NCGKEKCLMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stopwatch LHDIJKGNNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly int HCNAPENJOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string ICFEHBAOCCB;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IDCNIFDHJNO BDCPHABFGJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B60C0", Offset = "0x5B50C0", VA = "0x1805B60C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	[NotNull]
	public string JHHMJDKKBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E0130", Offset = "0x5DF130", VA = "0x1805E0130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x300E5F0", Offset = "0x300D5F0", VA = "0x18300E5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long DLBLALBJCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x300E4F0", Offset = "0x300D4F0", VA = "0x18300E4F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int BDKAIHMGBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x300E5A0", Offset = "0x300D5A0", VA = "0x18300E5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x300E650", Offset = "0x300D650", VA = "0x18300E650")]
	public IKBIJKLPGMJ(TKey JAKOMHEKEAL, [Optional] int? BJDLJGFMKPI, [Optional][CanBeNull] Stopwatch LHDIJKGNNGF, [Optional] Action<TKey, OBOJJEBNICC> OBDJKGFDFEG, [Optional] Action<TKey, OBOJJEBNICC> MHDJENJNDBN, [Optional] Action<global::IKBIJKLPGMJ<TKey>> BBONBICFLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x300E510", Offset = "0x300D510", VA = "0x18300E510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x300E4D0", Offset = "0x300D4D0", VA = "0x18300E4D0")]
	public void DCEAMMEMNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x300E5D0", Offset = "0x300D5D0", VA = "0x18300E5D0")]
	public void PCFLFPLICNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x300E370", Offset = "0x300D370", VA = "0x18300E370")]
	[IteratorStateMachine(typeof(global::IKBIJKLPGMJ<>.BNAGIJOCHEE))]
	public IEnumerable<(TKey, List<TKey>, OBOJJEBNICC)> CJMEOBEOPKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x300E400", Offset = "0x300D400", VA = "0x18300E400")]
	[IteratorStateMachine(typeof(global::IKBIJKLPGMJ<>.AGBJHOCJCBM))]
	private IEnumerable<(TKey, List<TKey>, OBOJJEBNICC)> CJMEOBEOPKD(List<TKey> CKHPGJEOEJJ, IDCNIFDHJNO CJCDFPPMJNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x300E2E0", Offset = "0x300D2E0", VA = "0x18300E2E0")]
	private (long, int) BFNCGNHAKCH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class IAHBGHNDJOO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PPMAOFPIFLK(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
	protected IAHBGHNDJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class BKPMDMEALGB<TKey> : global::IAHBGHNDJOO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public delegate string HDJGDMMHPHO(TKey GLMMMFPEBHE);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x37BC7D0", Offset = "0x37BB7D0", VA = "0x1837BC7D0")]
	protected string LIEMMDOALOA(double LMNKJKEHMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x37BC870", Offset = "0x37BB870", VA = "0x1837BC870")]
	protected string NBFGLIHILCH(int FJAJDHJICIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x37BC830", Offset = "0x37BB830", VA = "0x1837BC830")]
	private static string MMJGFGIEBFL(TKey GLMMMFPEBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x37BC8C0", Offset = "0x37BB8C0", VA = "0x1837BC8C0", Slot = "4")]
	public override string PPMAOFPIFLK(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x37BC970", Offset = "0x37BB970", VA = "0x1837BC970")]
	public string PPMAOFPIFLK(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP, [NotNull] HDJGDMMHPHO BJBNDBAIMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EOLOOFIPNLE(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP, [NotNull] HDJGDMMHPHO BJBNDBAIMAH);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x201C3B0", Offset = "0x201B3B0", VA = "0x18201C3B0")]
	protected BKPMDMEALGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class ILEMFKHPADK<TKey> : global::IAHBGHNDJOO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public delegate string JIHDEGCAIHG(TKey GLMMMFPEBHE);

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CCGJMIKINKN = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string NKLCHGBHDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly double IPAJODJHDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly bool OEBGLDCCGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly int BJIAFIAPODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly ISet<string> PIHDEOBDHGE;

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x300EC70", Offset = "0x300DC70", VA = "0x18300EC70")]
	private static string MMJGFGIEBFL(TKey GLMMMFPEBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x300F220", Offset = "0x300E220", VA = "0x18300F220")]
	public ILEMFKHPADK(string NKLCHGBHDBD = "F2", double IPAJODJHDMJ = double.MaxValue, bool OEBGLDCCGEN = false, int BJIAFIAPODL = int.MaxValue, [Optional] ISet<string> PIHDEOBDHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x300F170", Offset = "0x300E170", VA = "0x18300F170", Slot = "4")]
	public override Dictionary<string, string> PPMAOFPIFLK(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x300E880", Offset = "0x300D880", VA = "0x18300E880")]
	private bool FJOJBJMBKIL(string KCMOMMKBKON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x300ECB0", Offset = "0x300DCB0", VA = "0x18300ECB0")]
	public Dictionary<string, string> PPMAOFPIFLK(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP, JIHDEGCAIHG BJBNDBAIMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x300E960", Offset = "0x300D960", VA = "0x18300E960")]
	private string HFHFKBIJICA(StringBuilder FOCMNOPGCII, List<TKey> NMCPLKJLFCM, JIHDEGCAIHG BJBNDBAIMAH, bool PFJKLHFEDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x300EB10", Offset = "0x300DB10", VA = "0x18300EB10")]
	private static void JJNCCMIHKFE(StringBuilder JHDLBNOAPPC, string CNAEGABLFKF, bool GNIJNDEHECC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class IFAPFHJLPGF<TKey> : global::BKPMDMEALGB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct GDEPCGCABHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public HDJGDMMHPHO keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public static global::IFAPFHJLPGF<TKey> AOMOPIPEMFB;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int JGLAMLFMCFG = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly string[] IMOHGHPNGOP;

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2194980", Offset = "0x2193980", VA = "0x182194980")]
	private IFAPFHJLPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x21938D0", Offset = "0x21928D0", VA = "0x1821938D0", Slot = "5")]
	protected override string EOLOOFIPNLE(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP, HDJGDMMHPHO BJBNDBAIMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x21947A0", Offset = "0x21937A0", VA = "0x1821947A0")]
	[CompilerGenerated]
	internal static string IDEBEMNOFFM(string HAMPJDNBOHI, TKey GLMMMFPEBHE, ref GDEPCGCABHP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class IOEEHAOOOLC<TKey> : global::BKPMDMEALGB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class JAJAAIOCCHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public HDJGDMMHPHO keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public JAJAAIOCCHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2185BB0", Offset = "0x2184BB0", VA = "0x182185BB0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2687DC0", Offset = "0x2686DC0", VA = "0x182687DC0", Slot = "5")]
	protected override string EOLOOFIPNLE(global::IKBIJKLPGMJ<TKey> COCHHMDLDJP, HDJGDMMHPHO BJBNDBAIMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2688560", Offset = "0x2687560", VA = "0x182688560")]
	public IOEEHAOOOLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public sealed class LDJIKGGGFHP : global::IKBIJKLPGMJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class AFJMGMHEFLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action<LDJIKGGGFHP> callback;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public AFJMGMHEFLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5114510", Offset = "0x5113510", VA = "0x185114510")]
		internal void <Wrap>b__0(global::IKBIJKLPGMJ<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5117AE0", Offset = "0x5116AE0", VA = "0x185117AE0")]
	public LDJIKGGGFHP([Optional] string KIKAHFAHOPP, [Optional] int? BJDLJGFMKPI, [Optional] Stopwatch LHDIJKGNNGF, [Optional] Action<string, OBOJJEBNICC> OBDJKGFDFEG, [Optional] Action<string, OBOJJEBNICC> MHDJENJNDBN, [Optional] Action<LDJIKGGGFHP> BBONBICFLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5117A20", Offset = "0x5116A20", VA = "0x185117A20")]
	private static Action<global::IKBIJKLPGMJ<string>> ENOAPLNANGI(Action<LDJIKGGGFHP> ONMGDGLPLME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public abstract class CENPMCFONFM
{
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private class EFGMLNIJAAA : CENPMCFONFM
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public static CENPMCFONFM AOMOPIPEMFB
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5115090", Offset = "0x5114090", VA = "0x185115090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public override DateTime BHOGCMEBHAL
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x5115040", Offset = "0x5114040", VA = "0x185115040", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public override float DLCLKNAIKHN
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x5115030", Offset = "0x5114030", VA = "0x185115030", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5115190", Offset = "0x5114190", VA = "0x185115190")]
		public EFGMLNIJAAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static CENPMCFONFM ONMPCKGBBDF;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public static CENPMCFONFM DDKLLKCKOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5114CE0", Offset = "0x5113CE0", VA = "0x185114CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract DateTime BHOGCMEBHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public abstract float DLCLKNAIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	protected CENPMCFONFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FGJCBIHCGCF : global::FCFBMNKEPFH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x51153F0", Offset = "0x51143F0", VA = "0x1851153F0")]
	public FGJCBIHCGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class FCFBMNKEPFH<T> : global::HBBFIHNFHKG<T>, HFGPJJNNMDK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Task<T> NLHMFKEKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Task PPABGEELLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x1D25150", Offset = "0x1D24150", VA = "0x181D25150", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public global::BDGKEGGAANF<T> JAMONHLICMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private GNLNKOKJLFP DHJNLCIKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x1E10230", Offset = "0x1E0F230", VA = "0x181E10230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x230A930", Offset = "0x2309930", VA = "0x18230A930")]
	public FCFBMNKEPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class DPNIDHPBDIM : global::BMGLBPONNMA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5114FE0", Offset = "0x5113FE0", VA = "0x185114FE0")]
	public DPNIDHPBDIM(Exception MMICFFPKPAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class BMGLBPONNMA<T> : global::HBBFIHNFHKG<T>, HFGPJJNNMDK, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Task<T> NLHMFKEKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private Task PPABGEELLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1D25150", Offset = "0x1D24150", VA = "0x181D25150", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public global::BDGKEGGAANF<T> JAMONHLICMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private GNLNKOKJLFP DHJNLCIKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1E10230", Offset = "0x1E0F230", VA = "0x181E10230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4418D90", Offset = "0x4417D90", VA = "0x184418D90")]
	public BMGLBPONNMA(Exception MMICFFPKPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface HFGPJJNNMDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	[NotNull]
	Task NLHMFKEKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	[NotNull]
	GNLNKOKJLFP JAMONHLICMM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface HBBFIHNFHKG<T> : HFGPJJNNMDK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	[NotNull]
	new Task<T> NLHMFKEKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	[NotNull]
	new global::BDGKEGGAANF<T> JAMONHLICMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public abstract class MDHEGDKBKPB<TTask, T> : global::HBBFIHNFHKG<T>, HFGPJJNNMDK, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class GFKEOLHNGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public global::MDHEGDKBKPB<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public GFKEOLHNGOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static bool CCOJALEDGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Task<T> IEGFKOJFDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	protected readonly CancellationTokenSource OMCJPMALCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private bool CKJDBNBCJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private SynchronizationContext JIDCJHJFMKM;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Task<T> NLHMFKEKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Task PPABGEELLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public global::BDGKEGGAANF<T> JAMONHLICMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private GNLNKOKJLFP DHJNLCIKAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x20196A0", Offset = "0x20186A0", VA = "0x1820196A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CKFMKJJBGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x60E990", Offset = "0x60D990", VA = "0x18060E990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3182BB0", Offset = "0x3181BB0", VA = "0x183182BB0")]
	static MDHEGDKBKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x3182ED0", Offset = "0x3181ED0", VA = "0x183182ED0")]
	protected MDHEGDKBKPB(TTask IEGFKOJFDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x31828B0", Offset = "0x31818B0", VA = "0x1831828B0", Slot = "1")]
	~MDHEGDKBKPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x3182880", Offset = "0x3181880", VA = "0x183182880", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x3182710", Offset = "0x3181710", VA = "0x183182710")]
	private void ALEEKPJPLFM(bool OAJBFCLLCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T ILCBKKKKAKE(TTask BHOGNAMIOFB);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PMGCMIPGIIK();

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x31829F0", Offset = "0x31819F0", VA = "0x1831829F0")]
	[CompilerGenerated]
	private void NOFLKMHDBIA(object BGAPAAKHGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public interface PKIJPGAACND
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	float ABHMJDPFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KLNLAKNKGGJ NOPKIMPCJLE;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class KFIMMFJNHBI : PKIJPGAACND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public readonly struct MHMPHEIBJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly float MKFJPMDAPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly float KIIJCBFDKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal readonly bool CIGLGAOEIMC;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float ECIOENCFCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x5118A10", Offset = "0x5117A10", VA = "0x185118A10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5118B80", Offset = "0x5117B80", VA = "0x185118B80")]
		public MHMPHEIBJFB(float DBHBFIKBLHB, float OENKNOGFNFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5118A20", Offset = "0x5117A20", VA = "0x185118A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class MMNOKAGMDIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public KFIMMFJNHBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public MMNOKAGMDIN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly int PGIGOJJPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private int JLKBBPONBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly PKIJPGAACND[] IGICPGAABOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly KLNLAKNKGGJ[] NIFJNHPKINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly MHMPHEIBJFB[] ICFCBKMOPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private MHMPHEIBJFB EPBLICIGPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly AINDHOAKGJE IFIMFHOOAOL;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public MHMPHEIBJFB IPMHICGICOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x32C6250", Offset = "0x32C5250", VA = "0x1832C6250")]
		get
		{
			return default(MHMPHEIBJFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float ABHMJDPFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x51177D0", Offset = "0x51167D0", VA = "0x1851177D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KLNLAKNKGGJ NOPKIMPCJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x5117710", Offset = "0x5116710", VA = "0x185117710", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x5117580", Offset = "0x5116580", VA = "0x185117580", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x51177F0", Offset = "0x51167F0", VA = "0x1851177F0")]
	public KFIMMFJNHBI(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5117640", Offset = "0x5116640", VA = "0x185117640")]
	public AINDHOAKGJE GLAGFKBEMBO(MHMPHEIBJFB MMNAKGFLJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x51171A0", Offset = "0x51161A0", VA = "0x1851171A0")]
	public void FPPBJDGNLMG(PKIJPGAACND MDHNINDHEIO, [Optional] MHMPHEIBJFB NBEIBHODCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x51176C0", Offset = "0x51166C0", VA = "0x1851176C0")]
	internal int HBFJCLNILFO(PKIJPGAACND BOCMJNNGDLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5116FC0", Offset = "0x5115FC0", VA = "0x185116FC0")]
	internal MHMPHEIBJFB BKOIGJOJEEE(int GPNCGBOOKKF)
	{
		return default(MHMPHEIBJFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x5117010", Offset = "0x5116010", VA = "0x185117010", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate void KLNLAKNKGGJ(float MMDJDIHBFJJ);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal static class KOMGAJJINDF
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	internal const float EAIEANALBLP = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class GNOHHLGJCHO
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class FFGFEMCPCMK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly PKIJPGAACND BOCMJNNGDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly KLNLAKNKGGJ ONMGDGLPLME;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5115360", Offset = "0x5114360", VA = "0x185115360")]
		public FFGFEMCPCMK(PKIJPGAACND BOCMJNNGDLF, KLNLAKNKGGJ ONMGDGLPLME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5115310", Offset = "0x5114310", VA = "0x185115310", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5115D30", Offset = "0x5114D30", VA = "0x185115D30")]
	internal static bool PJKPKIDBPBJ(float INIPPOEHOLP, float BMEGDOGJIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3D1FDF0", Offset = "0x3D1EDF0", VA = "0x183D1FDF0")]
	internal static float ICBOMGGPPLD(float INIPPOEHOLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5115C70", Offset = "0x5114C70", VA = "0x185115C70")]
	public static IDisposable FPPOBADALAB(this PKIJPGAACND BOCMJNNGDLF, KLNLAKNKGGJ ONMGDGLPLME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class AINDHOAKGJE : PKIJPGAACND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private float MMDJDIHBFJJ;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public float ABHMJDPFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x11753D0", Offset = "0x11743D0", VA = "0x1811753D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x51146D0", Offset = "0x51136D0", VA = "0x1851146D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KLNLAKNKGGJ NOPKIMPCJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5114630", Offset = "0x5113630", VA = "0x185114630", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5114590", Offset = "0x5113590", VA = "0x185114590", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public AINDHOAKGJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class ICMACPIIFCL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public readonly Type MOLHOKEOECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public readonly string MDBFKKDJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public readonly bool NCINDCBNMPC;

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5116300", Offset = "0x5115300", VA = "0x185116300")]
	public ICMACPIIFCL(Type GAFNGMJNPKC, string AECFDKBMBFA, bool KDMBHGDEIOH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class DJFNKGPMMFJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5114EF0", Offset = "0x5113EF0", VA = "0x185114EF0")]
	public DJFNKGPMMFJ(string ADIELDAOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5114F60", Offset = "0x5113F60", VA = "0x185114F60")]
	public DJFNKGPMMFJ(string ADIELDAOJPG, Exception DIICGEDPOOL)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x58DED0", Offset = "0x58CED0", VA = "0x18058DED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x5B1710", Offset = "0x5B0710", VA = "0x1805B1710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public T this[int FBIMLOLEMBB, int PGLDCIKBEBM]
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E330", Offset = "0x1E0D330", VA = "0x181E0E330")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E3D0", Offset = "0x1E0D3D0", VA = "0x181E0E3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E2A0", Offset = "0x1E0D2A0", VA = "0x181E0E2A0")]
		public Array2D(uint PONIFNELPFK, uint GIGPIDHIFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E220", Offset = "0x1E0D220", VA = "0x181E0E220")]
		public void ABPOABCICEP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x51147A0", Offset = "0x51137A0", VA = "0x1851147A0")]
		public Array2DVector3(uint PONIFNELPFK, uint GIGPIDHIFMI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class FHKOADDGGLB
{
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public const int OECNMAHNKCH = -1;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public const int FIIKPFCBPDF = 0;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DefaultMember("Item")]
public class LJENNEAPDNP<THandle, TValue> : IDisposable where THandle : struct, JKOGMDEMBMB where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<THandle> DAHCEAEIBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly List<TValue> JPEDBNEBJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Func<TValue> EBODDGNPIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Action<TValue> MHHMIDIOMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private int GPPGACANMAF;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TValue PCOPJNFJBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE6B0", Offset = "0x2BFD6B0", VA = "0x182BFE6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEE50", Offset = "0x2BFDE50", VA = "0x182BFEE50")]
	public LJENNEAPDNP(Action<TValue> MHHMIDIOMFL, [Optional] Func<TValue> EBODDGNPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE350", Offset = "0x2BFD350", VA = "0x182BFE350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEBB0", Offset = "0x2BFDBB0", VA = "0x182BFEBB0")]
	public THandle NPKHJENBLIG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE280", Offset = "0x2BFD280", VA = "0x182BFE280")]
	public THandle CGEJAMCGIKA(TValue GGAFBKIEDPG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE6F0", Offset = "0x2BFD6F0", VA = "0x182BFE6F0")]
	public bool IDBFDJDECBI(THandle OCDKENKCLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE5D0", Offset = "0x2BFD5D0", VA = "0x182BFE5D0")]
	public bool GOILIEOHABH(THandle OCDKENKCLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE410", Offset = "0x2BFD410", VA = "0x182BFE410")]
	public bool FMFCOGJONGA(THandle OCDKENKCLFI, out TValue GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEE00", Offset = "0x2BFDE00", VA = "0x182BFEE00")]
	public TValue PKIGOCNNHDN(THandle OCDKENKCLFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE9F0", Offset = "0x2BFD9F0", VA = "0x182BFE9F0")]
	public bool MOEJJIDPMEJ(THandle OCDKENKCLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE870", Offset = "0x2BFD870", VA = "0x182BFE870")]
	private THandle JELPNPOPDPL(int GPNCGBOOKKF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2BFED90", Offset = "0x2BFDD90", VA = "0x182BFED90")]
	private TValue PEOIAIJJCKH(int GPNCGBOOKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE3D0", Offset = "0x2BFD3D0", VA = "0x182BFE3D0")]
	private void EDLNNODBEKA(int GPNCGBOOKKF, in THandle OCDKENKCLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEDC0", Offset = "0x2BFDDC0", VA = "0x182BFEDC0")]
	private void PJFMLIGJLCI(int GPNCGBOOKKF, in TValue GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2BFEAA0", Offset = "0x2BFDAA0", VA = "0x182BFEAA0")]
	private THandle NOGJPPKBCKM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE8A0", Offset = "0x2BFD8A0", VA = "0x182BFE8A0")]
	private void JKJFKPALPFB(THandle OCDKENKCLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE9E0", Offset = "0x2BFD9E0", VA = "0x182BFE9E0")]
	private int KELHPKDCKHI(int MHHPMGFBNFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE6E0", Offset = "0x2BFD6E0", VA = "0x182BFE6E0")]
	private bool HPBCDNMMALA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9A0", Offset = "0x5DD9A0", VA = "0x1805DE9A0")]
	private void NHFEJAIMENE(THandle OCDKENKCLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE960", Offset = "0x2BFD960", VA = "0x182BFE960")]
	private bool JOAJDEOCKLG(out THandle OCDKENKCLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE7A0", Offset = "0x2BFD7A0", VA = "0x182BFE7A0")]
	private bool IILHJEIBFFC(out THandle OCDKENKCLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE2F0", Offset = "0x2BFD2F0", VA = "0x182BFE2F0")]
	private void DFBDFGGNGBL(THandle OCDKENKCLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE4B0", Offset = "0x2BFD4B0", VA = "0x182BFE4B0")]
	private void GDPKOPEHOMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public interface JKOGMDEMBMB
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int LDLBNOKJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int HAAADPKHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public interface GPCILPKKCNI<T> : JKOGMDEMBMB, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class CMABPEKMPCH
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x233A400", Offset = "0x2339400", VA = "0x18233A400")]
	public static bool CIGLGAOEIMC<T>(this T OCDKENKCLFI) where T : struct, JKOGMDEMBMB
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public class ACCHIEDIFOH
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private enum IJKFIOACBMF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int PBKICKIDADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool DPIKBFBPMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private IJKFIOACBMF GEGGAMIGIHO;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool NJGNJIEBDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5113F10", Offset = "0x5112F10", VA = "0x185113F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LKGCAKADGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x51144D0", Offset = "0x51134D0", VA = "0x1851144D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x51144E0", Offset = "0x51134E0", VA = "0x1851144E0")]
	public ACCHIEDIFOH(bool DPIKBFBPMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5113F20", Offset = "0x5112F20", VA = "0x185113F20")]
	public void LLMLCPFCDIE(object NHBCHHMAJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5113E60", Offset = "0x5112E60", VA = "0x185113E60")]
	public void LFNMHANPGIL(int GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5113A20", Offset = "0x5112A20", VA = "0x185113A20")]
	public void GLLKGECPMAD(uint CECAANGFJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5114440", Offset = "0x5113440", VA = "0x185114440")]
	public void PBLFLHGBFOG(bool LCJHNJHGLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5113970", Offset = "0x5112970", VA = "0x185113970")]
	public void CJFGKDMNBGM(long ONODPIHIGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5113710", Offset = "0x5112710", VA = "0x185113710")]
	public void AHBMKOLEPIO(ulong PHFBCPLFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5113A30", Offset = "0x5112A30", VA = "0x185113A30")]
	public void HDFBGACKGHL(string KCCHPAJODNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x51137C0", Offset = "0x51127C0", VA = "0x1851137C0")]
	public void BMBIDEOILIJ(Enum MMICFFPKPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5113850", Offset = "0x5112850", VA = "0x185113850")]
	public void BMDBNBOADKG(IList BDIENPOHAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6C30", Offset = "0x1FE5C30", VA = "0x181FE6C30")]
	public void GDEIJIIIGJB<T, U>(Dictionary<T, U> MBKPPAKLMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5113AA0", Offset = "0x5112AA0", VA = "0x185113AA0")]
	private void IGOENAOCFHG(IDictionary MBKPPAKLMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5113750", Offset = "0x5112750", VA = "0x185113750")]
	public int BJFGFEOLLFJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5114460", Offset = "0x5113460", VA = "0x185114460")]
	public short PHPCADKIOFM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5113700", Offset = "0x5112700", VA = "0x185113700")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x51139B0", Offset = "0x51129B0", VA = "0x1851139B0")]
	private void DCIDMAIAFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class OBIHPFPLCDC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class FNCGEIDMIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public TNode CKPEPLIGOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public TNode NKNFLMKNNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CGAPFCPGKBI FIPJKEDOGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public List<CGAPFCPGKBI> ILBIHJJCOGM;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public FNCGEIDMIMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	internal struct CGAPFCPGKBI : IComparable<CGAPFCPGKBI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int CADNKICEOGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TClaimant MAGHOBEGAKI;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x595CF0", Offset = "0x594CF0", VA = "0x180595CF0")]
		public CGAPFCPGKBI(int CADNKICEOGM, TClaimant MAGHOBEGAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x46D9290", Offset = "0x46D8290", VA = "0x1846D9290")]
		public bool LKOIPNNDNLE(in CGAPFCPGKBI GOAJJPLEOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x46D9280", Offset = "0x46D8280", VA = "0x1846D9280")]
		public bool EFDMJDAMHAM(in CGAPFCPGKBI GOAJJPLEOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x46D9270", Offset = "0x46D8270", VA = "0x1846D9270", Slot = "4")]
		public int CompareTo(CGAPFCPGKBI GOAJJPLEOBJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x46D92F0", Offset = "0x46D82F0", VA = "0x1846D92F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum JCFLIOIKAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class KADAIPLKGDN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public global::OBIHPFPLCDC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x22EB760", Offset = "0x22EA760", VA = "0x1822EB760")]
		[DebuggerHidden]
		public KADAIPLKGDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x46E1EB0", Offset = "0x46E0EB0", VA = "0x1846E1EB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x46E2070", Offset = "0x46E1070", VA = "0x1846E2070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x46E1F90", Offset = "0x46E0F90", VA = "0x1846E1F90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D1FFA0", Offset = "0x1D1EFA0", VA = "0x181D1FFA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly global::HLPAPAFHAHA<FNCGEIDMIMI> JLILNDJOMHE;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly global::HLPAPAFHAHA<List<CGAPFCPGKBI>> KPJMCJAPJIF;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int EKOCCNECJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	internal readonly Dictionary<TClaimant, TNode> OJOLENANHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	internal readonly Dictionary<TNode, FNCGEIDMIMI> KPDKOHOOJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private JCFLIOIKAHJ PAMKEOLBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool OPPEGHNMEKD;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PMNINMBCDLI(TNode ENBCMIAMCNO);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AFFAEAMHFBB(TNode ENBCMIAMCNO, TClaimant KNPECECOPOC, TClaimant EOLDODDJMFH);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x46E4440", Offset = "0x46E3440", VA = "0x1846E4440")]
	public OBIHPFPLCDC(JCFLIOIKAHJ PAMKEOLBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x46E31A0", Offset = "0x46E21A0", VA = "0x1846E31A0")]
	public void DBLOIPAADAK(TNode ENBCMIAMCNO, TNode OAKDFCNFIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x46E3980", Offset = "0x46E2980", VA = "0x1846E3980")]
	public void FGPKOLHBBLI(TClaimant MAGHOBEGAKI, TNode CHKFJLKHFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x46E33B0", Offset = "0x46E23B0", VA = "0x1846E33B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x46E3A80", Offset = "0x46E2A80", VA = "0x1846E3A80")]
	private void FLNFEIKNAGI(TClaimant MAGHOBEGAKI, TNode CPLNKAAOECJ, TNode CHKFJLKHFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x46E4130", Offset = "0x46E3130", VA = "0x1846E4130")]
	private int ODEIMEKKNLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x46E2E30", Offset = "0x46E1E30", VA = "0x1846E2E30")]
	private void BNGEFJEHEPO(TClaimant MAGHOBEGAKI, TNode NBKPNDLCALB, TNode IHJLCFDNLPK, int HCAIMDGIJNH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x46E2DA0", Offset = "0x46E1DA0", VA = "0x1846E2DA0")]
	private void BEDENKMKCFO(CGAPFCPGKBI BNAJFFGOBJA, FNCGEIDMIMI FPOJKMOAEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x46E3610", Offset = "0x46E2610", VA = "0x1846E3610")]
	private void EHLEBKCPOJD(TClaimant MAGHOBEGAKI, TNode NBKPNDLCALB, TNode IHJLCFDNLPK, int HCAIMDGIJNH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x46E3B20", Offset = "0x46E2B20", VA = "0x1846E3B20")]
	private void KICGDKPLKDH(CGAPFCPGKBI BNAJFFGOBJA, TNode ENBCMIAMCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x46E3880", Offset = "0x46E2880", VA = "0x1846E3880")]
	private void EJNMINMGMMB(CGAPFCPGKBI BNAJFFGOBJA, FNCGEIDMIMI FPOJKMOAEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x46E41A0", Offset = "0x46E31A0", VA = "0x1846E41A0")]
	private void OEHCMMCKNOJ(FNCGEIDMIMI FPOJKMOAEBG, bool BHKEMNPHCJJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x46E3C20", Offset = "0x46E2C20", VA = "0x1846E3C20")]
	private void NDMDNNKMECJ(FNCGEIDMIMI FPOJKMOAEBG, TNode OAKDFCNFIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x46E4060", Offset = "0x46E3060", VA = "0x1846E4060")]
	[IteratorStateMachine(typeof(global::OBIHPFPLCDC<, >.KADAIPLKGDN))]
	private IEnumerable<TNode> NEKBOIDNHLD(TNode NBKPNDLCALB, TNode IHJLCFDNLPK, bool OPJBFCLMCFB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x46E30E0", Offset = "0x46E20E0", VA = "0x1846E30E0")]
	private FNCGEIDMIMI DAHJOCNLHKL(TNode ENBCMIAMCNO, TNode NKNFLMKNNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x46E3220", Offset = "0x46E2220", VA = "0x1846E3220")]
	private FNCGEIDMIMI DCJFNAFODFF(TNode ENBCMIAMCNO, TNode NKNFLMKNNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x46E2BE0", Offset = "0x46E1BE0", VA = "0x1846E2BE0")]
	private void ABJMFPJDJGC(FNCGEIDMIMI FPOJKMOAEBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public class IDKNOAOOJGH<T> : IEnumerable<global::IDKNOAOOJGH<T>.JMJEPBNGPKL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public struct JMJEPBNGPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public T GGAFBKIEDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int GPNCGBOOKKF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class GPONDPNMBFF : IEnumerator<JMJEPBNGPKL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private global::IDKNOAOOJGH<T> DHECKNEMJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int GPNCGBOOKKF;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x2189470", Offset = "0x2188470", VA = "0x182189470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public JMJEPBNGPKL CNDEAJHHNAK
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x2189650", Offset = "0x2188650", VA = "0x182189650", Slot = "4")]
			get
			{
				return default(JMJEPBNGPKL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
		public GPONDPNMBFF(global::IDKNOAOOJGH<T> DHECKNEMJFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2189350", Offset = "0x2188350", VA = "0x182189350", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x81E480", Offset = "0x81D480", VA = "0x18081E480", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x852F80", Offset = "0x851F80", VA = "0x180852F80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private struct KPCOAHGLNMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public bool DADPAOLEADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public T GGAFBKIEDPG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private const int DFNMPDLMJAF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Dictionary<T, int> NFFIMMCIOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private KPCOAHGLNMB[] NJJHLEFJGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private int CDGEEMLKKMC;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int GBGPHFDAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x58DCC0", Offset = "0x58CCC0", VA = "0x18058DCC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E7EB0", Offset = "0x6E6EB0", VA = "0x1806E7EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2185A40", Offset = "0x2184A40", VA = "0x182185A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2193070", Offset = "0x2192070", VA = "0x182193070")]
	public IDKNOAOOJGH(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2192890", Offset = "0x2191890", VA = "0x182192890")]
	public IDKNOAOOJGH(JMJEPBNGPKL[] BCMOOGJJBNH, bool FCADBFBOAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2192390", Offset = "0x2191390", VA = "0x182192390")]
	public int MEHNOAEHJDJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2191E70", Offset = "0x2190E70", VA = "0x182191E70")]
	private int JLNKPPJCIPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x21924B0", Offset = "0x21914B0", VA = "0x1821924B0", Slot = "6")]
	protected virtual uint PAKKNAOPPCN(uint PBKICKIDADF, T GGAFBKIEDPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2192350", Offset = "0x2191350", VA = "0x182192350")]
	public bool KBANGCALFGP(T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2191A80", Offset = "0x2190A80", VA = "0x182191A80")]
	public bool DLIDMBPJNMO(int GPNCGBOOKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2191BF0", Offset = "0x2190BF0", VA = "0x182191BF0")]
	public bool FDJOBPPDLBD(Func<T, bool> KNGEIBIBOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2192450", Offset = "0x2191450", VA = "0x182192450")]
	public int OHPDGGBPFPJ(T GGAFBKIEDPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2192500", Offset = "0x2191500", VA = "0x182192500")]
	public T PEOIAIJJCKH(int GPNCGBOOKKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x2191230", Offset = "0x2190230", VA = "0x182191230")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x21917E0", Offset = "0x21907E0", VA = "0x1821917E0")]
	public bool DDECLGPGGGI(T GGAFBKIEDPG, bool KJOHCKFKLKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2191590", Offset = "0x2190590", VA = "0x182191590")]
	public bool DDECLGPGGGI(T GGAFBKIEDPG, int GPNCGBOOKKF, bool KJOHCKFKLKG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2191D60", Offset = "0x2190D60", VA = "0x182191D60")]
	public bool IDBFDJDECBI(T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21917C0", VA = "0x1821927C0")]
	public bool POJCEAPHLKE(int GPNCGBOOKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x21926D0", Offset = "0x21916D0", VA = "0x1821926D0")]
	private void PMNGOMLLIOM(int GPNCGBOOKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2191420", Offset = "0x2190420", VA = "0x182191420")]
	public JMJEPBNGPKL[] CJEOFMFDPCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2191CC0", Offset = "0x2190CC0", VA = "0x182191CC0")]
	private int GJDGDEBLELD(int EEMJGKOCJGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2192810", Offset = "0x2191810", VA = "0x182192810", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2192810", Offset = "0x2191810", VA = "0x182192810", Slot = "4")]
	private IEnumerator<JMJEPBNGPKL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class HLPAPAFHAHA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Stack<T> FJDGKEFMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly List<T> DMNHBEHCNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly int CGLKABNEIPC;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int MGKPOFMBGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DCA0", Offset = "0x1E0CCA0", VA = "0x181E0DCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int IECAKLDFPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2E08CB0", Offset = "0x2E07CB0", VA = "0x182E08CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x40C8650", Offset = "0x40C7650", VA = "0x1840C8650")]
	public static global::HLPAPAFHAHA<T> GPEECMJMLOI(int PGIGOJJPHFM = 0, int CGLKABNEIPC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x40C8320", Offset = "0x40C7320", VA = "0x1840C8320")]
	public static global::HLPAPAFHAHA<T> AKBLIOILCIP(int PGIGOJJPHFM = 0, int CGLKABNEIPC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x40C8C80", Offset = "0x40C7C80", VA = "0x1840C8C80")]
	public HLPAPAFHAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x40C8AF0", Offset = "0x40C7AF0", VA = "0x1840C8AF0")]
	public HLPAPAFHAHA(int PGIGOJJPHFM, int CGLKABNEIPC = int.MaxValue, bool JNCMPKOAOMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x40C8900", Offset = "0x40C7900", VA = "0x1840C8900")]
	public T OKDDLGJCBOH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x40C8A30", Offset = "0x40C7A30", VA = "0x1840C8A30")]
	public void PFDGBAGNHGC(T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x40C8260", Offset = "0x40C7260", VA = "0x1840C8260")]
	private void ACFJMBGPIBE(T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x40C8720", Offset = "0x40C7720", VA = "0x1840C8720")]
	private void HCDPANHCNED(T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x40C85B0", Offset = "0x40C75B0", VA = "0x1840C85B0")]
	[Conditional("DEBUG_BUILD")]
	private void FHKLKGFPODN(T FFACGEIJHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x40C83F0", Offset = "0x40C73F0", VA = "0x1840C83F0")]
	[Conditional("DEBUG_BUILD")]
	private void CBNCEOBDEPD(T FFACGEIJHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x40C84A0", Offset = "0x40C74A0", VA = "0x1840C84A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x40C8740", Offset = "0x40C7740", VA = "0x1840C8740")]
	private void KDKCOOGMNFD(IEnumerable<T> JPEDBNEBJEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class LMKHNOIKLDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private Dictionary<int, T> BOGBGEMPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private T IGOLLHAPDGP;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public virtual T JGLANJIFLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool JNDLJINNANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x2C032A0", Offset = "0x2C022A0", VA = "0x182C032A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2C034B0", Offset = "0x2C024B0", VA = "0x182C034B0")]
	public bool PNPEIPPMCOG(T GGAFBKIEDPG, int CADNKICEOGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2C02D10", Offset = "0x2C01D10", VA = "0x182C02D10")]
	public bool ABDICKAKOAL(int CADNKICEOGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2C03040", Offset = "0x2C02040", VA = "0x182C03040")]
	public T AKLKMILICMC(int BPGEMGKNOOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2C02D70", Offset = "0x2C01D70", VA = "0x182C02D70")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2C033F0", Offset = "0x2C023F0", VA = "0x182C033F0")]
	private bool JLAPFDFGDHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x2C03480", Offset = "0x2C02480", VA = "0x182C03480")]
	public bool NHHHDIDPJMI(int CADNKICEOGM, out T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2C03570", Offset = "0x2C02570", VA = "0x182C03570")]
	public LMKHNOIKLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class MNBKPGMEDBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	protected struct BBHEMPNAFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public T PDFBALCEGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int MBGHLGLIGKI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	protected readonly List<BBHEMPNAFEG> ABADPJGEKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private T NKANIJJOMLB;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2185A40", Offset = "0x2184A40", VA = "0x182185A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3785220", Offset = "0x3784220", VA = "0x183785220")]
	public bool FDJOBPPDLBD(T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3785180", Offset = "0x3784180", VA = "0x183785180")]
	public void CGEJAMCGIKA(T GGAFBKIEDPG, int CADNKICEOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3785470", Offset = "0x3784470", VA = "0x183785470")]
	public bool IDBFDJDECBI(T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3785090", Offset = "0x3784090", VA = "0x183785090")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x37850F0", Offset = "0x37840F0", VA = "0x1837850F0")]
	public T BHNEIPLNGBE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3785590", Offset = "0x3784590", VA = "0x183785590")]
	public T JMKPGIGGFIL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3785600", Offset = "0x3784600", VA = "0x183785600")]
	private void OILJGPPDGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x3785810", Offset = "0x3784810", VA = "0x183785810")]
	public MNBKPGMEDBE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[EJHKBJPGPJF(KPKOFHBALGN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x5119640", Offset = "0x5118640", VA = "0x185119640")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x5119B10", Offset = "0x5118B10", VA = "0x185119B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118930", VA = "0x185119930")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x5119CB0", Offset = "0x5118CB0", VA = "0x185119CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x5119500", Offset = "0x5118500", VA = "0x185119500")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x51199D0", Offset = "0x51189D0", VA = "0x1851199D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x51197F0", Offset = "0x51187F0", VA = "0x1851197F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5119460", Offset = "0x5118460", VA = "0x185119460")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface BGHPCAJIAAA
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public abstract class ResourcePrefabReference<T> : BGHPCAJIAAA where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1E21900", Offset = "0x1E20900", VA = "0x181E21900", Slot = "4")]
		public virtual T DPFAAGDEIEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class LMBLKAHGBHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<byte, GJBPNGFGGIA> DKMBMKENAPH;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GJBPNGFGGIA ELHMMMJEFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector2 HLBIECEHFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x13FFBB0", Offset = "0x13FEBB0", VA = "0x1813FFBB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x22EC1F0", Offset = "0x22EB1F0", VA = "0x1822EC1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public Vector2 DAHPOFBDOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x15A4790", Offset = "0x15A3790", VA = "0x1815A4790")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x15A4820", Offset = "0x15A3820", VA = "0x1815A4820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public Vector2 LIPFAOKDOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x51183E0", Offset = "0x51173E0", VA = "0x1851183E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x5117D50", Offset = "0x5116D50", VA = "0x185117D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int IADBBEFCEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x5B87E0", Offset = "0x5B77E0", VA = "0x1805B87E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9A0", Offset = "0x5DD9A0", VA = "0x1805DE9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5118400", Offset = "0x5117400", VA = "0x185118400")]
	public LMBLKAHGBHO(Bounds AGBEKIAPGEL, Vector2[] ABEDJPAIOOE, int ABOAKPCJLPG, byte EEMJGKOCJGH, float PGOJBKHCHGP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5118380", Offset = "0x5117380", VA = "0x185118380")]
	public GJBPNGFGGIA JBHKBFLFDGP(byte GPNCGBOOKKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5117D70", Offset = "0x5116D70", VA = "0x185117D70")]
	public void HCPAKACFIPN(Vector3 PFANDEKBLGD, float DNJDFIDOLOE, float NCMONAKLMCO, ref List<byte> JEKAMJCGMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5117D30", Offset = "0x5116D30", VA = "0x185117D30")]
	public void DNPCMKMIIFN(GJBPNGFGGIA.INIFCOOIADB FNDDFPPEBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5117C00", Offset = "0x5116C00", VA = "0x185117C00")]
	private GJBPNGFGGIA AEBCJJECMOK(byte GPNCGBOOKKF, GJBPNGFGGIA.CGLMLJMMDIH PIBBBBMHLDD, GJBPNGFGGIA NKNFLMKNNCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5117E60", Offset = "0x5116E60", VA = "0x185117E60")]
	private void IICHEFCNFOL(GJBPNGFGGIA NKNFLMKNNCC, Vector2[] ABEDJPAIOOE, int AEEEOODKNLO, int LHAIIPGELFI, int MOIDCKFCCLD, int MMBNLCDCOLG, float PGOJBKHCHGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class GJBPNGFGGIA
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public enum CGLMLJMMDIH
	{
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public enum INIFCOOIADB
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public byte ECLFPKHILEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Vector3 LDBMMPNNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Vector3 ECIOENCFCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Vector3 IFHCPPCJJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Vector3 BHHPNNAGBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public CGLMLJMMDIH FJAGKCCJFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public GJBPNGFGGIA IEJNLKPMFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public List<GJBPNGFGGIA> IDEEJJJBPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public bool AONCHPKJIFI;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5115C50", Offset = "0x5114C50", VA = "0x185115C50")]
	public GJBPNGFGGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5115BF0", Offset = "0x5114BF0", VA = "0x185115BF0")]
	public GJBPNGFGGIA(byte ICEKBLFEGDG, CGLMLJMMDIH PIBBBBMHLDD, GJBPNGFGGIA NKNFLMKNNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5115880", Offset = "0x5114880", VA = "0x185115880")]
	public void FENNPKKNDOA(GJBPNGFGGIA GEIEAAHLJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80")]
	public void DNPCMKMIIFN(int MNJEOKBABML, INIFCOOIADB FNDDFPPEBGL, int GMMIHMHKEBO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5115920", Offset = "0x5114920", VA = "0x185115920")]
	public void HCPAKACFIPN(List<byte> JEKAMJCGMLF, Vector3 PFANDEKBLGD, float DNJDFIDOLOE, float NCMONAKLMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5115820", Offset = "0x5114820", VA = "0x185115820")]
	public bool AMHEEPOOIKK(Vector3 DLKGDIEINAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5115BB0", Offset = "0x5114BB0", VA = "0x185115BB0")]
	public bool HEMPKLFCOHM(Vector3 DLKGDIEINAF, float FDELPMOILLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class CGHIINLOLGE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<T, object> CHLFAONMGKO;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2185BB0", Offset = "0x2184BB0", VA = "0x182185BB0")]
	public bool KGKEKPPPMAK(T HCPGAAIJGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x33E2640", Offset = "0x33E1640", VA = "0x1833E2640")]
	public bool KGKEKPPPMAK(T HCPGAAIJGJD, object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x33E2680", Offset = "0x33E1680", VA = "0x1833E2680")]
	public bool KGKEKPPPMAK(T HCPGAAIJGJD, object CNJNFLKBLCC, out object LPMAGPDIKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x33E2570", Offset = "0x33E1570", VA = "0x1833E2570")]
	public bool IANLANMELLG(T HCPGAAIJGJD, object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x33E2530", Offset = "0x33E1530", VA = "0x1833E2530")]
	public bool HJGOPIFKCEE(T HCPGAAIJGJD, object CNJNFLKBLCC, out object LPMAGPDIKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x33E25B0", Offset = "0x33E15B0", VA = "0x1833E25B0")]
	public bool IANLANMELLG(T HCPGAAIJGJD, object CNJNFLKBLCC, out object LPMAGPDIKEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x33E2780", Offset = "0x33E1780", VA = "0x1833E2780")]
	public void PODDLBBFOID(T HCPGAAIJGJD, object CNJNFLKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x33E26E0", Offset = "0x33E16E0", VA = "0x1833E26E0")]
	public void MELFNGKKOHG(T HCPGAAIJGJD, object CNJNFLKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x33E27B0", Offset = "0x33E17B0", VA = "0x1833E27B0")]
	public CGHIINLOLGE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public struct JGEIGKDCPLF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private readonly List<Component> BDIENPOHAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private readonly bool OFNBMOKICJN;

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x7CD060", Offset = "0x7CC060", VA = "0x1807CD060")]
			public JGEIGKDCPLF(List<Component> BDIENPOHAGP, bool OFNBMOKICJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x1E135F0", Offset = "0x1E125F0", VA = "0x181E135F0")]
			public FKNNPNFBAKE<T> LNOKBJIIFFP()
			{
				return default(FKNNPNFBAKE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x1E13660", Offset = "0x1E12660", VA = "0x181E13660", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x1E13660", Offset = "0x1E12660", VA = "0x181E13660", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public struct FKNNPNFBAKE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private readonly List<Component> BDIENPOHAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private readonly bool OFNBMOKICJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private int GPNCGBOOKKF;

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public T CNDEAJHHNAK
			{
				[Cpp2IlInjected.Token(Token = "0x600045F")]
				[Cpp2IlInjected.Address(RVA = "0x1E12B50", Offset = "0x1E11B50", VA = "0x181E12B50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x1E12AE0", Offset = "0x1E11AE0", VA = "0x181E12AE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x1E12B20", Offset = "0x1E11B20", VA = "0x181E12B20")]
			public FKNNPNFBAKE(List<Component> BDIENPOHAGP, bool OFNBMOKICJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x1E12A10", Offset = "0x1E11A10", VA = "0x181E12A10", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x1E12A20", Offset = "0x1E11A20", VA = "0x181E12A20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x1E12AD0", Offset = "0x1E11AD0", VA = "0x181E12AD0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x511B970", Offset = "0x511A970", VA = "0x18511B970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x511B930", Offset = "0x511A930", VA = "0x18511B930")]
		public ToolHierarchyCache(GameObject DEDHLGFLHEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x511B500", Offset = "0x511A500", VA = "0x18511B500")]
		private void JMPIMFJAEKM(GameObject DEDHLGFLHEK, bool FHPGFPLPMCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x511B470", Offset = "0x511A470", VA = "0x18511B470")]
		public static void JMPIMFJAEKM(GameObject DEDHLGFLHEK, ref ToolHierarchyCache PCIKPFNBFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x511B3A0", Offset = "0x511A3A0", VA = "0x18511B3A0")]
		public void IIJKNFHJCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x511B250", Offset = "0x511A250", VA = "0x18511B250")]
		public void FBJHHPNBJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x1BFDD20", Offset = "0x1BFCD20", VA = "0x181BFDD20")]
		public void HBBBGNBKKNE<T>(Action<T> HCHPGKLEJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x511B110", Offset = "0x511A110", VA = "0x18511B110")]
		public Component BKCFEPLDCMD(Type JFEPPDBLNIJ, bool OFNBMOKICJN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x1F75F60", Offset = "0x1F74F60", VA = "0x181F75F60")]
		public T BKCFEPLDCMD<T>(bool OFNBMOKICJN = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x511B310", Offset = "0x511A310", VA = "0x18511B310")]
		public JGEIGKDCPLF<Component> HKPEFMEPDDH(Type JFEPPDBLNIJ, bool OFNBMOKICJN = false)
		{
			return default(JGEIGKDCPLF<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1FE6AB0", Offset = "0x1FE5AB0", VA = "0x181FE6AB0")]
		public JGEIGKDCPLF<T> HKPEFMEPDDH<T>(bool OFNBMOKICJN = false) where T : class
		{
			return default(JGEIGKDCPLF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x511B620", Offset = "0x511A620", VA = "0x18511B620")]
		public List<Component> KEJCNIKGGIK(Type JFEPPDBLNIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x511B1D0", Offset = "0x511A1D0", VA = "0x18511B1D0", Slot = "4")]
		public bool Equals(ToolHierarchyCache BIBNBCIJJEK, ToolHierarchyCache AIHGENMJNEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x511B2A0", Offset = "0x511A2A0", VA = "0x18511B2A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NHBCHHMAJOK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class GGJNAAIENKO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private int PGIGOJJPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private int FMMKNBGHCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private List<T> ADKMLHHJHNB;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DCA0", Offset = "0x1E0CCA0", VA = "0x181E0DCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public T KICFPNAHFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x3B7DD80", Offset = "0x3B7CD80", VA = "0x183B7DD80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public T FBNHFDMELDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x3B7DF40", Offset = "0x3B7CF40", VA = "0x183B7DF40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public T OHDPHINIGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x3B7DCC0", Offset = "0x3B7CCC0", VA = "0x183B7DCC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x3B7E040", Offset = "0x3B7D040", VA = "0x183B7E040")]
	public GGJNAAIENKO(int PGIGOJJPHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DBE0", Offset = "0x3B7CBE0", VA = "0x183B7DBE0")]
	public void CGEJAMCGIKA(T BDECCGAOFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DAC0", Offset = "0x3B7CAC0", VA = "0x183B7DAC0")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DEA0", Offset = "0x3B7CEA0", VA = "0x183B7DEA0")]
	public void LBHHCCABHFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DFF0", Offset = "0x3B7CFF0", VA = "0x183B7DFF0")]
	public void PGOODELBCIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DCB0", Offset = "0x3B7CCB0", VA = "0x183B7DCB0")]
	public void FGMNHNPLHGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class GBAOLCMMBGN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private bool HDAILFODGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private Action HCHPGKLEJDC;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public static GBAOLCMMBGN PFDPDADFLED
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x51157A0", Offset = "0x51147A0", VA = "0x1851157A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool PHDEPDJEEBN
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5B87B0", Offset = "0x5B77B0", VA = "0x1805B87B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x8A4950", Offset = "0x8A3950", VA = "0x1808A4950")]
	public GBAOLCMMBGN(Action HCHPGKLEJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5115780", Offset = "0x5114780", VA = "0x185115780")]
	public void JHIPCMEIJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5115780", Offset = "0x5114780", VA = "0x185115780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class KBIFBEHCAIL
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80")]
	public static void EHDJONFPMOP(NBBIHMIFGME LGOFBGHKEKA, string FOKHPMHDAHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public class LNKJBDDPKIB<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private struct PLNKKHBFMMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int MBGHLGLIGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T PDFBALCEGGK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly Dictionary<object, PLNKKHBFMMH> BOGBGEMPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T IGOLLHAPDGP;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public virtual T JGLANJIFLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x13FFBB0", Offset = "0x13FEBB0", VA = "0x1813FFBB0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x22EC1F0", Offset = "0x22EB1F0", VA = "0x1822EC1F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool JNDLJINNANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2C057C0", Offset = "0x2C047C0", VA = "0x182C057C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public object CMKAPBAEPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x5B7D70", Offset = "0x5B6D70", VA = "0x1805B7D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x4113B80", Offset = "0x4112B80", VA = "0x184113B80")]
	public bool PNPEIPPMCOG(T GGAFBKIEDPG, object CNJNFLKBLCC, int CADNKICEOGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2C05750", Offset = "0x2C04750", VA = "0x182C05750")]
	public bool ABDICKAKOAL(object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2C087E0", Offset = "0x2C077E0", VA = "0x182C087E0")]
	public bool NHHHDIDPJMI(object CNJNFLKBLCC, out T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x22EC160", Offset = "0x22EB160", VA = "0x1822EC160")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2C07CA0", Offset = "0x2C06CA0", VA = "0x182C07CA0")]
	private bool JLAPFDFGDHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2C03570", Offset = "0x2C02570", VA = "0x182C03570")]
	public LNKJBDDPKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public class HIKICILHEJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Dictionary<object, float> BOGBGEMPIFC;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float HFGEJIAEPED
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x11753D0", Offset = "0x11743D0", VA = "0x1811753D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xDBE350", Offset = "0xDBD350", VA = "0x180DBE350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5116060", Offset = "0x5115060", VA = "0x185116060")]
	public void PNPEIPPMCOG(float GGAFBKIEDPG, object CNJNFLKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5115ED0", Offset = "0x5114ED0", VA = "0x185115ED0")]
	public void ABDICKAKOAL(object CNJNFLKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5115F40", Offset = "0x5114F40", VA = "0x185115F40")]
	private void OKENPFHFAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x51160D0", Offset = "0x51150D0", VA = "0x1851160D0")]
	public HIKICILHEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public class KDMKDMMBBID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public readonly string HIKCNLLEGEB;

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x6C2360", Offset = "0x6C1360", VA = "0x1806C2360")]
	public KDMKDMMBBID(string PNBDEALJMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5116F10", Offset = "0x5115F10", VA = "0x185116F10")]
	public KDMKDMMBBID(UnityEngine.Object OIECLBACNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5116EC0", Offset = "0x5115EC0", VA = "0x185116EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public sealed class NBBIHMIFGME
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class JEONAJGNMEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public JEONAJGNMEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5116950", Offset = "0x5115950", VA = "0x185116950")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly HashSet<object> DDNONFAFAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private int JLBDDKPGLCA;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public IReadOnlyCollection<object> LPDJKNIJOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool BICIAPMBONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5118D60", Offset = "0x5117D60", VA = "0x185118D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public int MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x619670", Offset = "0x618670", VA = "0x180619670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5118D70", Offset = "0x5117D70", VA = "0x185118D70")]
	public bool CGEJAMCGIKA(object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5118EB0", Offset = "0x5117EB0", VA = "0x185118EB0")]
	public bool IDBFDJDECBI(object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5118E50", Offset = "0x5117E50", VA = "0x185118E50")]
	public bool FDJOBPPDLBD(object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5118DF0", Offset = "0x5117DF0", VA = "0x185118DF0")]
	public void EPNINAJLLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5118F30", Offset = "0x5117F30", VA = "0x185118F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x51190A0", Offset = "0x51180A0", VA = "0x1851190A0")]
	public NBBIHMIFGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public class LPOOKAFGJNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private struct NEHCKPNMHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public float IBKBOPHOPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public T PDFBALCEGGK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private Dictionary<object, NEHCKPNMHGH> BOGBGEMPIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private T IHHIDPIIONP;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public virtual T LMPMMHCDGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x10D4210", Offset = "0x10D3210", VA = "0x1810D4210", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x17F6AD0", Offset = "0x17F5AD0", VA = "0x1817F6AD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public object MDMHNNKJJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x5B5A30", Offset = "0x5B4A30", VA = "0x1805B5A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool JNDLJINNANB
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x22EC190", Offset = "0x22EB190", VA = "0x1822EC190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x22EDFD0", Offset = "0x22ECFD0", VA = "0x1822EDFD0")]
	public bool PNPEIPPMCOG(T GGAFBKIEDPG, object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x22EC100", Offset = "0x22EB100", VA = "0x1822EC100")]
	public bool ABDICKAKOAL(object CNJNFLKBLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x22EC160", Offset = "0x22EB160", VA = "0x1822EC160")]
	public void ABPOABCICEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x22EDBA0", Offset = "0x22ECBA0", VA = "0x1822EDBA0")]
	public bool NHHHDIDPJMI(object CNJNFLKBLCC, out T GGAFBKIEDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x22ED030", Offset = "0x22EC030", VA = "0x1822ED030")]
	private bool JLAPFDFGDHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x22EE2C0", Offset = "0x22ED2C0", VA = "0x1822EE2C0")]
	public LPOOKAFGJNI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class IPBFNGMPFEA
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static byte[] FDFKLIHCMDI;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int IKEJBHOADAH;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int BADMEAGLBCG;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static BigInteger LKFKJFPDNAJ;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IPBFNGMPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x5116360", Offset = "0x5115360", VA = "0x185116360")]
	private static string OJNKOKJGCOH(byte[] BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5116460", Offset = "0x5115460", VA = "0x185116460")]
	public static string PLNHDMOHEMF(byte[] LNCIHJHIBKD, bool PDPJHLLFJEO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
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
