using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ARFaceCoefficients : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x334B40", Offset = "0x333D40", VA = "0x180334B40")]
	public ARFaceCoefficients()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ARSelfieController : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x334B40", Offset = "0x333D40", VA = "0x180334B40")]
	public ARSelfieController()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RequireComponent(typeof(ARFace))]
public class ARKitBlendShapeVisualizer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private float m_CoefficientScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private SkinnedMeshRenderer m_SkinnedMeshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ARFace m_Face;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float coefficientScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x33DF20", Offset = "0x33D120", VA = "0x18033DF20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69FC10", Offset = "0x69EE10", VA = "0x18069FC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public SkinnedMeshRenderer skinnedMeshRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3366D0", Offset = "0x3358D0", VA = "0x1803366D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2618450", Offset = "0x2617650", VA = "0x182618450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2617EA0", Offset = "0x26170A0", VA = "0x182617EA0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2617EF0", Offset = "0x26170F0", VA = "0x182617EF0")]
	private void CreateFeatureBlendMapping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2618200", Offset = "0x2617400", VA = "0x182618200")]
	private void SetVisible(bool visible)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2618350", Offset = "0x2617550", VA = "0x182618350")]
	private void UpdateVisibility()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2618060", Offset = "0x2617260", VA = "0x182618060")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2617FA0", Offset = "0x26171A0", VA = "0x182617FA0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2618120", Offset = "0x2617320", VA = "0x182618120")]
	private void OnSystemStateChanged(ARSessionStateChangedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2618130", Offset = "0x2617330", VA = "0x182618130")]
	private void OnUpdated(ARFaceUpdatedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2618290", Offset = "0x2617490", VA = "0x182618290")]
	private void UpdateFaceFeatures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2618440", Offset = "0x2617640", VA = "0x182618440")]
	public ARKitBlendShapeVisualizer()
	{
	}
}
namespace Cpp2IlInjected;

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
